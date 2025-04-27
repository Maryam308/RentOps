using Microsoft.AspNetCore.Mvc;

namespace RentOpsWebApp.Controllers
{
    public class NotificationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Notification()
        {
            return View();
        }

    }
}
