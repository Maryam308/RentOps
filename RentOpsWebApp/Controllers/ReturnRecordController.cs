using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentOpsObjects.Model;
using RentOpsWebApp.ViewModels;

namespace RentOpsWebApp.Controllers
{
    public class ReturnRecordController : Controller
    {
        private  RentOpsDBContext _context;

        public ReturnRecordController(RentOpsDBContext context)
        {
            _context = context;
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

                _context.ReturnRecords.Add(returnRecord);
                await _context.SaveChangesAsync();

                TempData["CreateSuccess"] = "Return Record Created Successfully.";
                return RedirectToAction("ReturnRecord");
            }
            catch (Exception ex)
            {
                // Log the error
                Console.WriteLine(ex.Message);
                // Optionally, return an error view or message
                return View(model);
            }
        }


        //navigate to the delete page
        public IActionResult Delete(int id)
        {
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

            }
            catch (Exception ex)
            {
                //log the error
                Console.WriteLine(ex.Message);
            }
            
            return RedirectToAction("ReturnRecord");

        }

        //get the edit page
        public IActionResult Edit(int id)
        {
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
                // Log the error
                Console.WriteLine(ex.Message);
                // Optionally, return an error view or message
                return View(model);
            }

        }

        //a method to download a document
        public async Task<IActionResult> Download(int id)
        {
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


        }
}
