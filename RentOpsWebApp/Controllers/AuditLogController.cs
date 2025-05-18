using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentOpsObjects.Model;
using RentOpsWebApp.ViewModels;

namespace RentOpsWebApp.Controllers
{
    public class AuditLogController : Controller
    {
        private  RentOpsDBContext _context;

        public AuditLogController(RentOpsDBContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AuditLog(string SearchLogType, string SearchSource, string SearchTimestamp, string SearchException)
        {

            IEnumerable<Log> logList = _context.Logs
                .Include(e => e.User)
                .Include(e => e.LogType)
                .Include(e => e.Source)
                .ToList();


            //filter the logs based on the search criteria
            //if the search log type is not null or empty, we filter the logs based on the log type
            if (!string.IsNullOrEmpty(SearchLogType))
            {
                logList = logList.Where(e => e.LogType.LogTypeId == Convert.ToInt32(SearchLogType));
            }

            //if the search source is not null or empty, we filter the logs based on the source
            if (!string.IsNullOrEmpty(SearchSource))
            {
                logList = logList.Where(e => e.Source.SourceId == Convert.ToInt32(SearchSource));
            }

            //if the search timestamp is not null or empty, we filter the logs based on the date
            if (!string.IsNullOrEmpty(SearchTimestamp))
            {
                DateTime searchTimestamp;
                if (DateTime.TryParse(SearchTimestamp, out searchTimestamp))
                {
                    logList = logList.Where(l => l.LogTimestamp.Date == searchTimestamp.Date);
                }

            }



            //create a new instance of the viewmodel
            var auditLogViewModel = new AuditLogViewModel {

                Logs = logList,
                LogTypes = _context.LogTypes.ToList(),
                Sources = _context.Sources.ToList()

            };



            return View(auditLogViewModel);
        }

        public IActionResult Details(int? id)
        {
            if (id == null || id == 0)
                return NotFound();

            var logObject = _context.Logs.Include(e => e.LogType).Include(e => e.User).Include(e => e.Source).FirstOrDefault(e => e.LogId == id);

            if (logObject == null)
                return NotFound();

            var viewmodel = new AuditLogViewModel
            {
                LogObject = logObject        
            };

            return View(viewmodel);

        }




    }
}
