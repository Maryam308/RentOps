using Microsoft.AspNetCore.Mvc;

namespace RentOpsWebApp.Controllers
{
    public class AuditLogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AuditLog()
        {
            return View();
        }
    }
}
