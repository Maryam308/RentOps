using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentOpsObjects.Model;
using RentOpsWebApp.ViewModels;
using RentOpsWebApp.Services;
using System.Collections.Generic;
using RentOpsObjects.Services;
using Azure.Core;

namespace RentOpsWebApp.Controllers
{
    [Authorize(Roles = "Customer")]
    public class MyRentalTransactionController : Controller
    {
        private readonly RentOpsDBContext _context;
        AuditLogger auditLogger;
        IHttpContextAccessor _httpContextAccessor;

        public MyRentalTransactionController(RentOpsDBContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            auditLogger = new AuditLogger(_context);
            _httpContextAccessor = httpContextAccessor;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RentalTransactionDetails(int id)
        {


            var transaction = _context.RentalTransactions
                .Include(rt => rt.Equipment)
                .ThenInclude(e => e.EquipmentCategory)
                .Include(rt => rt.Employee)
                .Include(rt => rt.User)
                .Include(rt => rt.RentalRequest)
                    .ThenInclude(rr => rr.User)
                .Include(rt => rt.Payment)
                .FirstOrDefault(rt => rt.RentalTransactionId == id);

            if (transaction == null)
                return NotFound();

            //the user id could be saved in the rental transaction or the rental request
            int? userId = transaction.UserId ?? transaction.RentalRequest?.UserId;


            // Fetch the current user id
            var userEmail = User?.Identity?.Name;
            var currentUserId = _context.Users
                .FirstOrDefault(u => u.Email == userEmail)?.UserId;

            if (currentUserId == null || currentUserId != userId)
                return Forbid(); // Only allow the owner


            var viewModel = new RentalTransactionViewModel
            {
                rentalTransaction = transaction
            };

            return View("RentalTransctionDetails", viewModel);
        }


        public IActionResult MyRentalTransaction(string searchRentalTransactionId, string SearchRentalRequestId, string searchEmployeeId, string SearchEquipment, string SearchTransactionDate, string SearchPayment)
        {
            //fetch the current user id
            int? currentUserId = _context.Users
                    .FirstOrDefault(u => u.Email == User.Identity.Name)?.UserId;

            if (currentUserId == null) return Unauthorized(); // Ensure user exists

            try { 
                IEnumerable<RentalTransaction> rentalTransactions = _context.RentalTransactions
                    .Include(rt => rt.Equipment)
                    .Include(rt => rt.Employee)
                    .Include(rt => rt.RentalRequest)
                        .ThenInclude(rr => rr.User)
                    .Include(rt => rt.User)
                    .Include(rt => rt.Payment)
                    .OrderByDescending(rt => rt.RentalTransactionTimestamp)
                    .Where(rt => rt.RentalRequest.UserId == currentUserId)
                    .ToList();


                //filtering system

                //If return record id is used, we filter the list retrieved above
                if (!String.IsNullOrEmpty(searchRentalTransactionId))
                {
                    rentalTransactions = rentalTransactions.Where(p =>
                        p.RentalTransactionId == Convert.ToInt32(searchRentalTransactionId)
                    );
                }

                if (!String.IsNullOrEmpty(SearchRentalRequestId))
                {
                    rentalTransactions = rentalTransactions.Where(p =>
                        p.RentalRequestId == Convert.ToInt32(SearchRentalRequestId)
                    );
                }

                if (!String.IsNullOrEmpty(searchEmployeeId))
                {
                    rentalTransactions = rentalTransactions.Where(p =>
                        p.EmployeeId == Convert.ToInt32(searchEmployeeId)
                    );
                }

                if (!String.IsNullOrEmpty(SearchEquipment))
                {
                    rentalTransactions = rentalTransactions.Where(p =>
                        p.EquipmentId == Convert.ToInt32(SearchEquipment)
                    );
                }


                if (!String.IsNullOrEmpty(SearchPayment))
                {

                    //if searchpayment is = paid then we filter the list to show only the paid transactions
                    if (SearchPayment == "Paid")
                    {
                        rentalTransactions = rentalTransactions.Where(p =>
                            p.Payment != null
                        );
                    }
                    else if (SearchPayment == "Not Paid")
                    {

                        rentalTransactions = rentalTransactions.Where(p =>
                            p.Payment == null
                        );

                    }
                }


                if (!string.IsNullOrEmpty(SearchTransactionDate))
                {
                    DateTime searchTimestamp;
                    if (DateTime.TryParse(SearchTransactionDate, out searchTimestamp))
                    {
                        rentalTransactions = rentalTransactions.Where(p => p.RentalTransactionTimestamp.Date == searchTimestamp.Date);
                    }
                }




                var rentalTransactionViewModel = new RentalTransactionViewModel
                {
                    rentalTransactions = rentalTransactions,
                    equipmentTitle = _context.Equipment.ToList(),
                };

                return View(rentalTransactionViewModel);
            
            
            }
            catch (Exception ex)
            {
                //log the exception
                auditLogger.LogException(currentUserId, ex.Message, ex.StackTrace, 1);
                //save the error message to the viewbag
                ViewBag.ErrorMessage = ex.Message;
                // return  error view 
                return View("Error");
            }

            
        }
    }
}
