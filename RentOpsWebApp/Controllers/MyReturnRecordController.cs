using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentOpsObjects.Model;
using RentOpsWebApp.ViewModels;

namespace RentOpsWebApp.Controllers
{
    public class MyReturnRecordController : Controller
    {

        private readonly RentOpsDBContext _context;

        public MyReturnRecordController(RentOpsDBContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {

            return View();
        }

        public IActionResult ReturnRecordDetails(int id)
        {
            var record = _context.ReturnRecords
                .Include(r => r.RentalTransaction)
                .ThenInclude(rt => rt.Employee)
                .Include(r => r.ReturnCondition)
                .Include(r => r.Document)
                .FirstOrDefault(r => r.ReturnRecordId == id);

            if (record == null)
                return NotFound();

            var viewModel = new ReturnRecordViewModel
            {
                theReturnRecord = record
            };

            return View("ReturnRecordDetails", viewModel);
        }

        public IActionResult MyReturnRecord(string searchReturnRecordId, string searchRentalTransactionId, string searchActualReturnDate, string searchConditionStatus)
        {

            //for now the user id is hardcoded to 1
            int userId = 16;

            IEnumerable<ReturnRecord> returnRecords = _context.ReturnRecords
                .Include(e => e.ReturnCondition)
                .Include(e => e.RentalTransaction)
                .Include(e => e.Document)
                .Where(e => e.RentalTransaction.UserId == userId || e.RentalTransaction.RentalRequest.UserId == userId)
                .OrderByDescending(d => d.ActualReturnDate)
                .ToList();


            var transactionIdsWithFeedback = _context.Feedbacks
            .Select(f => f.RentalTransactionId)
            .Distinct()
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
                RentalTransactionIdsWithFeedback = transactionIdsWithFeedback,
            };

            return View(returnRecordViewModel);
        }

        [HttpGet]
        public IActionResult AddFeedback(int rentalTransactionId)
        {
            var transaction = _context.RentalTransactions
                .Include(t => t.Equipment)
                .ThenInclude(e => e.EquipmentCategory)
                .FirstOrDefault(t => t.RentalTransactionId == rentalTransactionId);

            if (transaction == null)
                return NotFound();

            var viewModel = new ReturnRecordViewModel
            {
                NewFeedback = new Feedback
                {
                    RentalTransactionId = rentalTransactionId // link to correct transaction
                },
                Equipment = transaction.Equipment // for display only
            };

            return View("AddFeedback", viewModel);
        }


        [HttpPost]
        public IActionResult AddFeedback(ReturnRecordViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.NewFeedback.FeedbackTimestamp = DateTime.Now;
                model.NewFeedback.IsHidden = false;

                _context.Feedbacks.Add(model.NewFeedback);
                _context.SaveChanges();

                //Find the return record for this transaction to redirect to details view
                var returnRecord = _context.ReturnRecords
                    .FirstOrDefault(r => r.RentalTransactionId == model.NewFeedback.RentalTransactionId);

                if (returnRecord != null)
                {
                    TempData["CreateSuccess"] = "Feedback added successfully!";
                    return RedirectToAction("MyReturnRecord", new { id = returnRecord.ReturnRecordId });
                }

                return RedirectToAction("MyReturnRecord");
            }

            // If validation fails, re-fetch equipment to redisplay
            model.Equipment = _context.RentalTransactions
                .Include(rt => rt.Equipment)
                .ThenInclude(e => e.EquipmentCategory)
                .Where(rt => rt.RentalTransactionId == model.NewFeedback.RentalTransactionId)
                .Select(rt => rt.Equipment)
                .FirstOrDefault();

            return View(model);
        }




    }
}
