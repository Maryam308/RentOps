using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentOpsObjects.Model;
using RentOpsWebApp.ViewModels;
using System.Collections.Generic;

namespace RentOpsWebApp.Controllers
{
    public class RentalRequestController : Controller
    {

        private  RentOpsDBContext _context;

        public RentalRequestController(RentOpsDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RentalRequest(string SearchRentalRequestId, string SearchRentalRequestStatusId, string searchequipmentId)
        {
            IEnumerable<RentalRequest> rentalRequestsList = _context.RentalRequests
                .Include(r => r.RentalRequestStatus)
                .Include(r => r.Equipment)
                .Include(r => r.User)
                .OrderByDescending(r => r.RentalStartDate)
                .ToList();

            //filtering system

            //If id is used, we filter the list retrieved above
            if (!String.IsNullOrEmpty(SearchRentalRequestId))
            {
                rentalRequestsList = rentalRequestsList.Where(p =>
                    p.RentalRequestId == Convert.ToInt32(SearchRentalRequestId)
                );
            }

            if (!String.IsNullOrEmpty(searchequipmentId))
            {
                rentalRequestsList = rentalRequestsList.Where(p =>
                    p.EquipmentId == Convert.ToInt32(searchequipmentId)
                );
            }

            if (!String.IsNullOrEmpty(SearchRentalRequestStatusId))
            {
                rentalRequestsList = rentalRequestsList.Where(p =>
                    p.RentalRequestStatusId == Convert.ToInt32(SearchRentalRequestStatusId)
                );
            }

            var rentalRequestViewModel = new RentalRequestViewModel
            {
                rentalRequests = rentalRequestsList,
                rentalRequestStatuses = _context.RentalRequestStatuses.ToList(),
                equipmentTitle = _context.Equipment.ToList(),
            };

            return View(rentalRequestViewModel);
        }


        //get to navigate to the review page
        public IActionResult Review(int id)
        {
            var rentalRequest = _context.RentalRequests
                .Include(r => r.RentalRequestStatus)
                .Include(r => r.Equipment)
                .Include(r => r.User)
                .FirstOrDefault(r => r.RentalRequestId == id);

            if (rentalRequest == null)
            {
                return NotFound();
            }
            var rentalRequestViewModel = new RentalRequestViewModel
            {
                RentalRequest = rentalRequest,
                rentalRequestStatuses = _context.RentalRequestStatuses.ToList(), 
            };
            return View(rentalRequestViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Review(RentalRequestViewModel model)
        {
            
            try
            {
                if (model.RentalRequest.RentalRequestId == 0) // Check if ID was passed
                {
                    TempData["Error"] = "Invalid Rental Request ID.";
                    return RedirectToAction("RentalRequest");
                }

                RentalRequest rentalRequest = _context.RentalRequests.FirstOrDefault(r => r.RentalRequestId == model.RentalRequest.RentalRequestId);

                if (!ModelState.IsValid)
                {
                    TempData["Error"] = "Something went wrong while creating the rental request.";
                    return RedirectToAction("Review", new { id = model.RentalRequest.RentalRequestId });
                }


                if (rentalRequest == null)
                {
                    TempData["Error"] = "Rental request not found.";
                    return RedirectToAction("Review", new { id = model.RentalRequest.EquipmentId });
                }

                //  Handle Pending Requests
                if (model.RentalRequest.RentalRequestStatusId == 1)
                {
                    return RedirectToAction("RentalRequest"); // Go to Rental Requests view  
                }

                //  Handle Rejected Requests
                if (model.RentalRequest.RentalRequestStatusId == 3)
                {
                    rentalRequest.RentalRequestStatusId = 3; // Update status to Rejected
                    _context.Entry(rentalRequest).Property(r => r.RentalRequestStatusId).IsModified = true;
                    _context.SaveChanges();

                    TempData["Rejected"] = "Rental request has been rejected.";
                    return RedirectToAction("RentalRequest"); // Go to Rental Requests view  
                }

                // Handle Approved Requests
                if (model.RentalRequest.RentalRequestStatusId == 2)
                {
                    rentalRequest.RentalRequestStatusId = 2; // Update status to Approved
                    _context.Entry(rentalRequest).Property(r => r.RentalRequestStatusId).IsModified = true;
                    _context.SaveChanges();

                    // Create a transaction
                    var transaction = new RentalTransaction
                    {
                        RentalTransactionTimestamp = DateTime.Now,
                        RentalRequestId = rentalRequest.RentalRequestId,
                        EquipmentId = rentalRequest.EquipmentId,
                        PickupDate = rentalRequest.RentalStartDate,
                        ReturnDate = rentalRequest.RentalReturnDate ,
                        RentalFee = model.RentalRequest.RentalTotalCost,
                        EmployeeId = 1, // You might want to fetch this dynamically
                        PaymentId = null
                    };

                    _context.RentalTransactions.Add(transaction);
                    _context.SaveChanges();

                    TempData["CreateSuccess"] = "Rental Request Approved! A transaction has been created.";
                }

                return RedirectToAction("RentalRequest"); // Go to Rental Requests view
            }
            catch (Exception ex)
            {
                TempData["Error"] = "An error occurred while processing the rental request.";
                Console.WriteLine(ex.Message);
                return RedirectToAction("Review", new { id = model.RentalRequest.EquipmentId });
            }
        }



    }
}
