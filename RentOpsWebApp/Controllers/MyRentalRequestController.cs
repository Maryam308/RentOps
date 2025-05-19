using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentOpsObjects.Model;
using RentOpsWebApp.ViewModels;
using System.Collections.Generic;
using RentOpsObjects.Services;
using Azure.Core;

namespace RentOpsWebApp.Controllers
{
    [Authorize(Roles = "Customer")]
    public class MyRentalRequestController : Controller
    {
        private RentOpsDBContext _context;
        AuditLogger auditLogger;
        IHttpContextAccessor _httpContextAccessor;

        public MyRentalRequestController(RentOpsDBContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            auditLogger = new AuditLogger(_context);
            _httpContextAccessor = httpContextAccessor;


        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyRentalRequest(string SearchRentalRequestId, string SearchRentalRequestStatusId, string searchequipmentId)
        {
            //fetch the current user id
            int? currentUserId = _context.Users
                    .FirstOrDefault(u => u.Email == User.Identity.Name)?.UserId;

            if (currentUserId == null) return Unauthorized(); // Ensure user exists


            IEnumerable<RentalRequest> rentalRequestsList = _context.RentalRequests
                .Include(r => r.RentalRequestStatus)
                .Include(r => r.Equipment)
                .Include(r => r.User)
                .Where(r => r.UserId == currentUserId)
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

        public IActionResult ViewDetails(int id)
        {
            var request = _context.RentalRequests
                .Include(r => r.User)
                .Include(r => r.Equipment)
                .ThenInclude(e => e.EquipmentCategory)
                .Include(r => r.RentalRequestStatus)
                .FirstOrDefault(r => r.RentalRequestId == id);

            if (request == null)
                return NotFound();

            // Fetch the current user id
            var userEmail = User?.Identity?.Name;
            var currentUserId = _context.Users
                .FirstOrDefault(u => u.Email == userEmail)?.UserId;

            if (currentUserId == null || currentUserId != request.UserId)
                return Forbid(); // Only allow the owner



            var model = new RentalRequestViewModel
            {
                RentalRequest = request
            };

            return View("RentalRequestDetails", model);
        }

        //get for the edit page
        public IActionResult Edit(int id)
        {
            var rentalRequest = _context.RentalRequests
                .Include(r => r.Equipment)
                .Include(r => r.RentalRequestStatus)
                .FirstOrDefault(r => r.RentalRequestId == id);
            
            if (rentalRequest == null)
                return NotFound();


            // Fetch the current user id
            var userEmail = User?.Identity?.Name;
            var currentUserId = _context.Users
                .FirstOrDefault(u => u.Email == userEmail)?.UserId;

            if (currentUserId == null || currentUserId != rentalRequest.UserId)
                return Unauthorized(); // Only allow the owner

            var model = new RentalRequestViewModel
            {
                RentalRequest = rentalRequest,
                equipmentTitle = _context.Equipment.ToList()
            };

            return View("Edit", model);
        }

        //function to get the rental price of an equipment
        [HttpGet]
        public IActionResult GetRentalPrice(int id)
        {
            Console.WriteLine("GetRentalPrice called with id: " + id);

            var equipment = _context.Equipment.FirstOrDefault(e => e.EquipmentId == id);
            if (equipment == null)
                return NotFound();
            return Json(new { rentalPrice = equipment.RentalPrice });
        }

        //post for the edit page
        [HttpPost]
        public IActionResult Edit(RentalRequest rentalRequest)
        {
            if (ModelState.IsValid)
            {

                var userEmail = User.Identity.Name;
                var currentUser = _context.Users.FirstOrDefault(u => u.Email == userEmail);

                if (currentUser == null) return Unauthorized();
                
                int currentUserId = currentUser.UserId;


                var existingRequest = _context.RentalRequests.FirstOrDefault(r => r.RentalRequestId == rentalRequest.RentalRequestId && r.UserId == currentUser.UserId);

                if (existingRequest == null)
                    return Forbid(); // Ensure user owns the request before modifying it



                if (existingRequest != null)
                {
                    existingRequest.RentalStartDate = rentalRequest.RentalStartDate;
                    existingRequest.RentalReturnDate = rentalRequest.RentalReturnDate;
                    existingRequest.EquipmentId = rentalRequest.EquipmentId;
                    existingRequest.RentalTotalCost = rentalRequest.RentalTotalCost;

                    //track the changes
                    auditLogger.TrackChanges(currentUserId, 2);

                    _context.SaveChanges();
                    return RedirectToAction("MyRentalRequest");
                }
            }
            return View(rentalRequest);
        }


    }
}
