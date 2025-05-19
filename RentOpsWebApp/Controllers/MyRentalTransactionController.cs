using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentOpsObjects.Model;
using RentOpsWebApp.ViewModels;

namespace RentOpsWebApp.Controllers
{
    public class MyRentalTransactionController : Controller
    {
        private readonly RentOpsDBContext _context;

        public MyRentalTransactionController(RentOpsDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RentalTransactionDetails(int id)
        {
            var transaction = _context.RentalTransactions
                .Include(rt => rt.Equipment)
                .ThenInclude(e => e.EquipmentCategory)
                .Include(rt => rt.Employee)
                .Include(rt => rt.User)
                .Include(rt => rt.RentalRequest)
                    .ThenInclude(rr => rr.User)
                .Include(rt => rt.Payment)
                .FirstOrDefault(rt => rt.RentalTransactionId == id);

            if (transaction == null)
                return NotFound();


            var viewModel = new RentalTransactionViewModel
            {
                rentalTransaction = transaction
            };

            return View("RentalTransctionDetails", viewModel);
        }


        public IActionResult MyRentalTransaction(string searchRentalTransactionId, string SearchRentalRequestId, string searchEmployeeId, string SearchEquipment, string SearchTransactionDate, string SearchPayment)
        {
            int currentUserId = 30;
            IEnumerable<RentalTransaction> rentalTransactions = _context.RentalTransactions
                .Include(rt => rt.Equipment)
                .Include(rt => rt.Employee)
                .Include(rt => rt.RentalRequest)
                    .ThenInclude(rr => rr.User)
                .Include(rt => rt.User)
                .Include(rt => rt.Payment)
                .OrderByDescending(rt => rt.RentalTransactionTimestamp)
                .Where(rt => rt.RentalRequest.UserId == currentUserId)
                .ToList();

            //filtering system

            //If return record id is used, we filter the list retrieved above
            if (!String.IsNullOrEmpty(searchRentalTransactionId))
            {
                rentalTransactions = rentalTransactions.Where(p =>
                    p.RentalTransactionId == Convert.ToInt32(searchRentalTransactionId)
                );
            }

            if (!String.IsNullOrEmpty(SearchRentalRequestId))
            {
                rentalTransactions = rentalTransactions.Where(p =>
                    p.RentalRequestId == Convert.ToInt32(SearchRentalRequestId)
                );
            }

            if (!String.IsNullOrEmpty(searchEmployeeId))
            {
                rentalTransactions = rentalTransactions.Where(p =>
                    p.EmployeeId == Convert.ToInt32(searchEmployeeId)
                );
            }

            if (!String.IsNullOrEmpty(SearchEquipment))
            {
                rentalTransactions = rentalTransactions.Where(p =>
                    p.EquipmentId == Convert.ToInt32(SearchEquipment)
                );
            }


            if (!String.IsNullOrEmpty(SearchPayment))
            {

                //if searchpayment is = paid then we filter the list to show only the paid transactions
                if (SearchPayment == "Paid")
                {
                    rentalTransactions = rentalTransactions.Where(p =>
                        p.Payment != null
                    );
                }
                else if (SearchPayment == "Not Paid")
                {

                    rentalTransactions = rentalTransactions.Where(p =>
                        p.Payment == null
                    );

                }
            }


            if (!string.IsNullOrEmpty(SearchTransactionDate))
            {
                DateTime searchTimestamp;
                if (DateTime.TryParse(SearchTransactionDate, out searchTimestamp))
                {
                    rentalTransactions = rentalTransactions.Where(p => p.RentalTransactionTimestamp.Date == searchTimestamp.Date);
                }
            }




            var rentalTransactionViewModel = new RentalTransactionViewModel
            {
                rentalTransactions = rentalTransactions,
                equipmentTitle = _context.Equipment.ToList(),
            };

            return View(rentalTransactionViewModel);
        }
    }
}
