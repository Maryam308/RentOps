using Microsoft.AspNetCore.Mvc;
using RentOpsObjects.Model;
using RentOpsWebApp.Models;
using RentOpsWebApp.ViewModels;
using System.Diagnostics;

namespace RentOpsWebApp.Controllers
{
    public class HomeController : Controller
    {
        RentOpsDBContext _context;

        private readonly ILogger<HomeController> _logger;
        public HomeController(RentOpsDBContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }


        public IActionResult Index()
        {
            var totalCustomers = _context.Users
                .Where(e => e.RoleId == 3)
                .Count();

            var totalEquipments = _context.Equipment.Count();


            var totalEmployees = _context.Users
                .Where(e => e.RoleId == 2)
                .Count();

            var totalRentals = _context.RentalRequests.Count();

            var viewModel = new HomeViewModel
            {
                TotalCustomers = Convert.ToInt32(totalCustomers),
                TotalEquipments = Convert.ToInt32(totalEquipments),
                TotalEmployees = Convert.ToInt32(totalEmployees),
                TotalRentals = Convert.ToInt32(totalRentals)
            };
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
