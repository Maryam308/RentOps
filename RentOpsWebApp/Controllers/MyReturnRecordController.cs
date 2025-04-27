using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentOpsObjects.Model;
using RentOpsWebApp.Models; 

namespace RentOpsWebApp.Controllers
{
    public class MyReturnRecordController : Controller
    {
        

        public IActionResult Index()
        {

            return View();
        }
        public IActionResult MyReturnRecord()
        {

            return View();
        }
    }
}
