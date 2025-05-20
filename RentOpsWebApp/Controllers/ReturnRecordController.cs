using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentOpsObjects.Model;
using RentOpsWebApp.ViewModels;
using RentOpsObjects.Services;

namespace RentOpsWebApp.Controllers
{
    [Authorize(Roles = "Administrator,Rental Manager")]
    public class ReturnRecordController : Controller
    {
        private  RentOpsDBContext _context;
        AuditLogger _auditLogger;

        public ReturnRecordController(RentOpsDBContext context)
        {
            _context = context;
            _auditLogger = new AuditLogger(context);
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ReturnRecord(string searchReturnRecordId, string searchRentalTransactionId, string searchActualReturnDate, string searchConditionStatus)
        {

            IEnumerable<ReturnRecord> returnRecords = _context.ReturnRecords
                .Include(e => e.ReturnCondition)
                .Include(e => e.RentalTransaction)
                .Include(e => e.Document)
                .OrderByDescending(d => d.ActualReturnDate)
                .ToList();
 
            
            
           

            //filtering system

            //If return record id is used, we filter the list retrieved above
            if (!String.IsNullOrEmpty(searchReturnRecordId))
            {
                returnRecords = returnRecords.Where(p =>
                    p.ReturnRecordId == Convert.ToInt32(searchReturnRecordId)
                );
            }

            if (!String.IsNullOrEmpty(searchRentalTransactionId))
            {
                returnRecords = returnRecords.Where(p =>
                    p.RentalTransactionId == Convert.ToInt32(searchRentalTransactionId)
                );
            }

            if (!String.IsNullOrEmpty(searchConditionStatus))
            {
                returnRecords = returnRecords.Where(p =>
                    p.ReturnConditionId == Convert.ToInt32(searchConditionStatus)
                );
            }


            if (!string.IsNullOrEmpty(searchActualReturnDate))
            {
                DateOnly searchDate;
                if (DateOnly.TryParse(searchActualReturnDate, out searchDate))
                {
                    returnRecords = returnRecords.Where(p => p.ActualReturnDate == searchDate);
                }
            }



            var returnRecordViewModel = new ReturnRecordViewModel
            {
                returnRecords = returnRecords,
                conditionStatuses = _context.ConditionStatuses.ToList(),
            };

            return View(returnRecordViewModel);
        }


        //navigating to the create page
        public IActionResult Create()
        {

            //fetch only the rental transactions without return records


            //save the ids of the rental transactions that has a return record in a list
            List<int> rentalTransactionIds = new List<int>();

            //loop through the return records and add the ids of the transactions to the list
            var returnRecords = _context.ReturnRecords.ToList();
            foreach (var returnRecord in returnRecords)
            {
                rentalTransactionIds.Add(returnRecord.RentalTransactionId);
            }

            // Get all rental transactions that are not in the list
            List<RentalTransaction> notReturnedRentalTransactions = _context.RentalTransactions
                .Where(x => !rentalTransactionIds.Contains(x.RentalTransactionId))
                .ToList();


            var returnRecordViewModel = new ReturnRecordViewModel
            {
                conditionStatuses = _context.ConditionStatuses.ToList(),
                rentalTransactions = notReturnedRentalTransactions,
            };
            return View(returnRecordViewModel);
        }




        
        [HttpPost]
        public async Task<IActionResult> Create(ReturnRecordViewModel model)
        {

            //check if the model state is valid else return the view with the error message
            if (!ModelState.IsValid)
            {
                IEnumerable<ReturnRecord> returnRecords = _context.ReturnRecords
                    .Include(e => e.ReturnCondition)
                    .Include(e => e.RentalTransaction)
                    .Include(e => e.Document)
                    .OrderByDescending(d => d.ActualReturnDate)
                    .ToList();

                var returnRecordViewModel = new ReturnRecordViewModel
                {
                    returnRecords = returnRecords,
                    conditionStatuses = _context.ConditionStatuses.ToList(),
                };

                //add to the temp data that the return record was not created because of invalid model state
                TempData["RuturnRecordError"] = "Return Record was not created because of invalid entries.";


                return View("ReturnRecord");
            }

            // Fetch the current user id
            var userEmail = User?.Identity?.Name;
            var currentUserId = _context.Users
                .FirstOrDefault(u => u.Email == userEmail)?.UserId;



            //try to add the return record to the database if the model state is valid
            try
            {
                int userId = 1; 
                if (currentUserId != null)
                {
                    userId = (int)currentUserId;
                }

                var returnRecord = model.theReturnRecord;

                //check for  uploaded file
                if (model.UploadedFile != null && model.UploadedFile.Length > 0)
                {
                    if (Path.GetExtension(model.UploadedFile.FileName).ToLower() != ".pdf")
                    {
                        ModelState.AddModelError("UploadedFile", "Only PDF files are allowed.");
                        return View("Error");
                    }

                    //create a new document object and save it to the database
                    using var memoryStream = new MemoryStream();
                    await model.UploadedFile.CopyToAsync(memoryStream);

                    var document = new Document
                    {
                        UserId = userId,
                        FileName = model.UploadedFile.FileName,
                        UploadDate = DateTime.UtcNow,
                        FileTypeId = 3, //file type id for damage report
                        StoragePath = "",
                        FileData = memoryStream.ToArray()
                    };

                    _context.Documents.Add(document);

                    await _context.SaveChangesAsync();

                    returnRecord.DocumentId = document.DocumentId;
                }

                //notify the user that the record has been created and request for a feedback

                //get the user from the transaction
                var rentalTransaction = _context.RentalTransactions
                    .Include(rt => rt.Equipment)
                    .Include(rt => rt.User)
                    .Include(rt => rt.RentalRequest)
                    .ThenInclude(rt => rt.User)
                    .FirstOrDefault(rt => rt.RentalTransactionId == returnRecord.RentalTransactionId);

                //check if the rental transaction is null
                if (rentalTransaction == null)
                {

                        var feedbackMessageContent = _context.MessageContents.Include(mc => mc.MessageType)
                                    .FirstOrDefault(m => m.MessageType.MessageTypeTitle == "Returned Request Feedback");

                        if (feedbackMessageContent == null)
                        {
                           //create a new message content
                            feedbackMessageContent = new MessageContent
                            {
                                 MessageTypeId = _context.MessageTypes.Where(mt => mt.MessageTypeTitle == "Feedback Request").Select(mt => mt.MessageTypeId).FirstOrDefault(),
                                 MessageContentText = "Your rented equipment has been returned. Please provide us with your feedback through My Return Record Page.",
                            };
                        }

                         if (feedbackMessageContent != null)
                         {
                              var notification = new Notification
                              {
                                        UserId = userId,
                                        MessageContentId = feedbackMessageContent.MessageContentId,
                                        NotificationStatusId = 1,
                                        NotificationTimestamp = DateTime.Now
                              };

                              _context.Notifications.Add(notification);

                        _auditLogger.TrackChanges(userId, 1); // 1 is the source id for website

                        _context.SaveChanges();
                              
                         }
                    

                }
                //before adding set the equipment condition to the one selected
                var equipment = _context.Equipment
                    .Include(e => e.ConditionStatus)
                    .FirstOrDefault(e => e.EquipmentId == rentalTransaction.EquipmentId);


                //update the condition status of the equipment
                if (equipment != null)
                {
                    equipment.ConditionStatusId = returnRecord.ReturnConditionId;

                    //update the availability status of the equipment
                    equipment.AvailabilityStatusId = 1; // Set to available

                    _context.Equipment.Update(equipment);
                }


                _context.ReturnRecords.Add(returnRecord);
                //track the changes 
                _auditLogger.TrackChanges(userId, 1); // 1 is the source id for website
                await _context.SaveChangesAsync();

                TempData["CreateSuccess"] = "Return Record Created Successfully.";
                return RedirectToAction("ReturnRecord");
            }
            catch (Exception ex)
            {
                //track the exception
                _auditLogger.LogException(currentUserId, ex.Message, ex.StackTrace, 1); // 1 is the source id for website
                //save the error message to the viewbag
                ViewBag.ErrorMessage = ex.Message;
                // return  error view 
                return View("Error");
            }

        }


        //navigate to the delete page
        public IActionResult Delete(int id)
        {
            try { 
                //check if the id is null or 0
                if (id == null || id == 0)
                    return NotFound();

                //find the return record object in the database
                var returnRecordObj = _context.ReturnRecords.Find(id);

                //check if the return record object is null
                if (returnRecordObj == null)
                    return NotFound();

                var viewmodel = new ReturnRecordViewModel
                {
                    theReturnRecord = returnRecordObj,
                    conditionStatuses = _context.ConditionStatuses.ToList(),
                    rentalTransactions = _context.RentalTransactions.ToList(),
                };
                return View(viewmodel);
            
            }
            catch (Exception ex)
            {
                //save the error message to the viewbag
                ViewBag.ErrorMessage = ex.Message;
                // return  error view 
                return View("Error");
            }


            
        }


        //post delete method
        [HttpPost]
        public IActionResult Delete(ReturnRecord theReturnRecord)
        {
                        
            try {

                //find the return record object in the database
                var returnRecordObj = _context.ReturnRecords.Find(theReturnRecord.ReturnRecordId);
                //check if the return record object is null
                if (returnRecordObj == null)
                    return NotFound();
                _context.ReturnRecords.Remove(returnRecordObj);
                _context.SaveChanges();

                //add success message to tempdata
                TempData["CreateSuccess"] = "Return Record Deleted Successfully.";
                return RedirectToAction("ReturnRecord");
            }
            catch (Exception ex)
            {
                //save the error message to the viewbag
                ViewBag.ErrorMessage = ex.Message;
                // return  error view 
                return View("Error");
            }
  

        }

        //get the edit page
        public IActionResult Edit(int id)
        {
            try { 
                //check if the id is null or 0
                if (id == null || id == 0)
                    return NotFound();

                //find the return record object in the database
                var returnRecordObj = _context.ReturnRecords.Include(rr => rr.Document).FirstOrDefault(rr => rr.ReturnRecordId == id);

                //check if the return record object is null
                if (returnRecordObj == null)
                    return NotFound();

                var viewmodel = new ReturnRecordViewModel
                {
                    theReturnRecord = returnRecordObj,
                    conditionStatuses = _context.ConditionStatuses.ToList(),
                    rentalTransactions = _context.RentalTransactions.ToList(),
                };
                return View(viewmodel);
            
            }
            catch (Exception ex)
            {
                //save the error message to the viewbag
                ViewBag.ErrorMessage = ex.Message;
                // return  error view 
                return View("Error");
            }
            
        }

        //post edit method
        [HttpPost]
        public async Task<IActionResult> Edit(ReturnRecordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ReturnRecord> returnRecords = _context.ReturnRecords
                    .Include(e => e.ReturnCondition)
                    .Include(e => e.RentalTransaction)
                    .Include(e => e.Document)
                    .OrderByDescending(d => d.ActualReturnDate)
                    .ToList();

                var returnRecordViewModel = new ReturnRecordViewModel
                {
                    returnRecords = returnRecords,
                    conditionStatuses = _context.ConditionStatuses.ToList(),
                };

                return View(returnRecordViewModel);
            }

            try
            {
                var returnRecord = model.theReturnRecord;

                if (model.UploadedFile != null && model.UploadedFile.Length > 0)
                {
                    if (Path.GetExtension(model.UploadedFile.FileName).ToLower() != ".pdf")
                    {
                        ModelState.AddModelError("UploadedFile", "Only PDF files are allowed.");
                        return View(model);
                    }

                    using var memoryStream = new MemoryStream();
                    await model.UploadedFile.CopyToAsync(memoryStream);

                    var document = new Document
                    {
                        UserId = 1, // Replace with actual user context
                        FileName = model.UploadedFile.FileName,
                        UploadDate = DateTime.UtcNow,
                        FileTypeId = 3,
                        StoragePath = "",
                        FileData = memoryStream.ToArray()
                    };

                    _context.Documents.Add(document);
                    await _context.SaveChangesAsync();

                    returnRecord.DocumentId = document.DocumentId;
                }

                _context.ReturnRecords.Update(returnRecord);
                await _context.SaveChangesAsync();

                TempData["CreateSuccess"] = "Return Record Updatedd Successfully.";
                return RedirectToAction("ReturnRecord");
            }
            catch (Exception ex)
            {
                //save the error message to the viewbag
                ViewBag.ErrorMessage = ex.Message;
                // return  error view 
                return View("Error");
            }

        }

        //a method to download a document
        public async Task<IActionResult> Download(int id)
        {
            try { 
            
                var document = await _context.Documents.FindAsync(id);


                if (document == null)
                {
                    return NotFound();
                }

                // Return the file as a downloadable response
                return File(
                    fileContents: document.FileData,
                    contentType: "application/pdf", // Assuming all stored files are PDFs
                    fileDownloadName: document.FileName
                );
            
            }
            catch (Exception ex)
            {
                //save the error message to the viewbag
                ViewBag.ErrorMessage = ex.Message;
                // return  error view 
                return View("Error");
            }
            

        }





    }


}
