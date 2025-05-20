using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentOpsObjects.Model;
using RentOpsWebApp.ViewModels;

namespace RentOpsWebApp.Controllers
{
    [Authorize(Roles = "Administrator")]
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

        public IActionResult AuditLog(string SearchLogType, string SearchSource, string SearchTimestamp, string SearchException, int page = 1)
        {
            try
            {
                int pageSize = 25;

                // Start with full logs query including relations
                var logsQuery = _context.Logs
                    .Include(e => e.User)
                    .Include(e => e.LogType)
                    .Include(e => e.Source)
                    .AsQueryable();

                // Apply filters if provided
                if (!string.IsNullOrEmpty(SearchLogType))
                    logsQuery = logsQuery.Where(e => e.LogType.LogTypeId == Convert.ToInt32(SearchLogType));

                if (!string.IsNullOrEmpty(SearchSource))
                    logsQuery = logsQuery.Where(e => e.Source.SourceId == Convert.ToInt32(SearchSource));

                if (!string.IsNullOrEmpty(SearchTimestamp) && DateTime.TryParse(SearchTimestamp, out DateTime parsedDate))
                    logsQuery = logsQuery.Where(e => e.LogTimestamp.Date == parsedDate.Date);

                // Get total count for pagination
                int totalLogs = logsQuery.Count();

                // Fetch the paged logs
                var logs = logsQuery
                    .OrderByDescending(e => e.LogTimestamp)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

                // Create the view model with pagination info
                var auditLogViewModel = new AuditLogViewModel
                {
                    Logs = logs,
                    LogTypes = _context.LogTypes.ToList(),
                    Sources = _context.Sources.ToList(),
                    SearchLogType = SearchLogType,
                    SearchSource = SearchSource,
                    SearchTimestamp = SearchTimestamp,
                    SearchException = SearchException,
                    CurrentPage = page,
                    TotalPages = (int)Math.Ceiling(totalLogs / (double)pageSize)
                };

                return View(auditLogViewModel);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View("Error");
            }
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
