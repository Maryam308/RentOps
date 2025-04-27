using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentOpsObjects.Model;

namespace RentOpsWebApp.Controllers
{
    public class RentalRequestController : Controller
    {

        private readonly RentOpsDBContext _context;

        public RentalRequestController(RentOpsDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RentalRequest()
        {
            var rentalRequestsList = _context.RentalRequests
                .Include(r => r.RentalRequestStatus)
                .Include(r => r.Equipment)
                .Include(r => r.User)
                .OrderByDescending(r => r.RentalStartDate)
                .ToList();

            return View(rentalRequestsList);
        }
    }
}
