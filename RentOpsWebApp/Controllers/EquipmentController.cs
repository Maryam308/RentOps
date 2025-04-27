using Microsoft.AspNetCore.Mvc;

namespace RentOpsWebApp.Controllers
{
    public class EquipmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Equipment()
        {
            return View();
        }

    }
}
