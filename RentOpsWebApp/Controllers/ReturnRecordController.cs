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
            var returnRecordViewModel = new ReturnRecordViewModel
            {
                conditionStatuses = _context.ConditionStatuses.ToList(),
                rentalTransactions = _context.RentalTransactions.ToList(),
            };
            return View(returnRecordViewModel);
        }




        //create method
        [HttpPost]
        public IActionResult Create(ReturnRecord theReturnRecord)
        {
            if (ModelState.IsValid)
            {
                //if there is a document attached to the return record it should be added to the database
                if (theReturnRecord.Document != null)
                {
                    _context.Documents.Add(theReturnRecord.Document);
                    _context.SaveChanges();
                    theReturnRecord.DocumentId = theReturnRecord.Document.DocumentId;
                }

                try {

                    //add the return record object to the database
                    _context.ReturnRecords.Add(theReturnRecord);
                        _context.SaveChanges();

                    //add success message to tempdata
                    TempData["CreateSuccess"] = "Return Record Created Successfully.";


                }
                catch (Exception ex)
                {
                    
                    //log the error
                    Console.WriteLine(ex.Message);
                }

                
                return RedirectToAction("ReturnRecord");
            }
            else
            {
                return View(theReturnRecord);
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

        //post edit method
        [HttpPost]
        public IActionResult Edit(ReturnRecord theReturnRecord)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    //update the return record object
                    _context.ReturnRecords.Update(theReturnRecord);
                    _context.SaveChanges();

                    //add success message to tempdata
                    TempData["CreateSuccess"] = "Return Record Updated Successfully.";

                }
                catch (Exception ex)
                {
                    //log the error
                    Console.WriteLine(ex.Message);
                } 
                
                return RedirectToAction("ReturnRecord");

            }
            else
            {
                //if the model state is not valid, return the view with the model
                var viewmodel = new ReturnRecordViewModel
                {
                    theReturnRecord = theReturnRecord,
                    conditionStatuses = _context.ConditionStatuses.ToList(),
                    rentalTransactions = _context.RentalTransactions.ToList(),
                };
                return View("ReturnRecord",viewmodel);
            }
           

        }
        }
}
