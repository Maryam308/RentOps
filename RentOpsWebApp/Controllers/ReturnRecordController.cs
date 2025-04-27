using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentOpsObjects.Model;
using RentOpsWebApp.ViewModels;

namespace RentOpsWebApp.Controllers
{
    public class ReturnRecordController : Controller
    {
        private readonly RentOpsDBContext _context;

        public ReturnRecordController(RentOpsDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ReturnRecord()
        {
            var returnRecords = _context.ReturnRecords.Join(
            _context.ConditionStatuses,
            rr => rr.ReturnConditionId,
            rc => rc.ConditionStatusId,
            (returnRecord, returnCond) => new ReturnRecord // Ensure return type is ReturnRecord
            {
                ReturnRecordId = returnRecord.ReturnRecordId,
                RentalTransactionId = returnRecord.RentalTransactionId,
                ActualReturnDate = returnRecord.ActualReturnDate,
                LateReturnFee = returnRecord.LateReturnFee,
                AdditionalCharge = returnRecord.AdditionalCharge,
                DocumentId = returnRecord.DocumentId,
                ReturnCondition = returnCond // Assuming `ConditionStatus` is a navigation property
            })
            .OrderByDescending(d => d.ActualReturnDate)
            .ToList();

            return View(returnRecords);
        }
    }
}
