using Microsoft.AspNetCore.Mvc;

namespace RentOpsWebApp.Controllers
{
    public class MyRentalTransactionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
