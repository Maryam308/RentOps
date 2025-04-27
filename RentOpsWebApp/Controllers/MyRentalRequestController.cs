using Microsoft.AspNetCore.Mvc;

namespace RentOpsWebApp.Controllers
{
    public class MyRentalRequestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MyRentalRequest()
        {
            return View();
        }
    }
}
