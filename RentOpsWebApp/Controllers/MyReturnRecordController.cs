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
        public IActionResult MyReturnRecord(string searchReturnRecordId, string searchRentalTransactionId, string searchActualReturnDate, string searchConditionStatus)
        {

            //for now the user id is hardcoded to 1
            int userId = 1; 

            IEnumerable<ReturnRecord> returnRecords = _context.ReturnRecords
                .Include(e => e.ReturnCondition)
                .Include(e => e.RentalTransaction)
                .Include(e => e.Document)
                .Where(e => e.RentalTransaction.UserId == userId  || e.RentalTransaction.RentalRequest.UserId == userId)
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

    }
}
