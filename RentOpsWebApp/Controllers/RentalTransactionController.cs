using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentOpsObjects.Model;

namespace RentOpsWebApp.Controllers
{
    public class RentalTransactionController : Controller
    {

        private readonly RentOpsDBContext _context;

        public RentalTransactionController(RentOpsDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RentalTransaction()
        {
            
            var rentalTransactions = _context.RentalTransactions
                .Include(rt => rt.Equipment)
                .Include(rt => rt.Employee)
                .Include(rt => rt.RentalRequest)
                    .ThenInclude(rr => rr.User)
                .Include(rt => rt.User)
                .Include(rt => rt.Payment)
                .OrderByDescending(rt => rt.RentalTransactionTimestamp)
                .Where(rt => rt.CustomerId == null)
                .ToList();


            return View(rentalTransactions);
        }
    }
}
