using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentOpsObjects.Model;
using RentOpsWebApp.ViewModels;
using System.Collections.Generic;

namespace RentOpsWebApp.Controllers
{
    public class RentalRequestController : Controller
    {

        private readonly RentOpsDBContext _context;

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
               

            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Something went wrong while creating the rental request.";
                return RedirectToAction("Review", new { id = model.RentalRequest.EquipmentId });
            }

            try
            {


                if (model.RentalRequest.RentalRequestStatusId == 2)
                {

                    //update the rental request status
                    var rentalRequest = _context.RentalRequests
                        .Include(r => r.RentalRequestStatus)
                        .Include(r => r.Equipment)
                        .Include(r => r.User)
                        .FirstOrDefault(r => r.RentalRequestId == model.RentalRequest.RentalRequestId);

                    if (rentalRequest == null)
                    {

                        TempData["Error"] = "Rental request not found.";
                        return RedirectToAction("Review", new { id = model.RentalRequest.EquipmentId });

                    }

                    // Update the rental request status
                    rentalRequest.RentalRequestStatusId = 2;

                    // Update in the database
                    _context.RentalRequests.Update(rentalRequest);
                    _context.SaveChanges();

                    // If the request is approved, create a transaction
                    if (rentalRequest.RentalRequestStatusId == 2)
                    {
                        RentalTransaction transaction;

                        //assign the values to the already created transaction from the model
                        transaction = model.NewRentalTransaction;
                        transaction.RentalTransactionTimestamp = DateTime.Now;
                        transaction.RentalRequestId = rentalRequest.RentalRequestId;
                        transaction.EquipmentId = rentalRequest.EquipmentId;
                        transaction.RentalFee = model.RentalRequest.RentalTotalCost;
                        transaction.EmployeeId = 1; // You might want to set this based on business logic
                        transaction.PaymentId = null;


                        _context.RentalTransactions.Add(transaction);
                        _context.SaveChanges();

                        TempData["CreateSuccess"] = "Rental Request Approved! A transaction has been created.";
                    }

                    var rentalRequestViewModel = new RentalRequestViewModel
                    {
                        rentalRequests = _context.RentalRequests
                            .Include(r => r.RentalRequestStatus)
                            .Include(r => r.Equipment)
                            .Include(r => r.User)
                            .OrderByDescending(r => r.RentalStartDate)
                            .ToList(),
                        rentalRequestStatuses = _context.RentalRequestStatuses.ToList(),
                        equipmentTitle = _context.Equipment.ToList(),
                    };

                    return View("RentalRequest", rentalRequestViewModel);

                }
                else {

                    
                    var rentalRequestViewModel = new RentalRequestViewModel
                    {
                        rentalRequests = _context.RentalRequests
                            .Include(r => r.RentalRequestStatus)
                            .Include(r => r.Equipment)
                            .Include(r => r.User)
                            .OrderByDescending(r => r.RentalStartDate)
                            .ToList(),
                        rentalRequestStatuses = _context.RentalRequestStatuses.ToList(),
                        equipmentTitle = _context.Equipment.ToList(),
                    };

                    return View("RentalRequest",rentalRequestViewModel);

                }
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
