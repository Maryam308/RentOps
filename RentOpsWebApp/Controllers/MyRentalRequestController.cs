using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentOpsObjects.Model;
using RentOpsWebApp.ViewModels;
using System.Collections.Generic;

namespace RentOpsWebApp.Controllers
{
    public class MyRentalRequestController : Controller
    {
        private readonly RentOpsDBContext _context;

        public MyRentalRequestController(RentOpsDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyRentalRequest(string SearchRentalRequestId, string SearchRentalRequestStatusId, string searchequipmentId)
        {
            int currentUserId = 30;

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

        //[Authorize(Roles = "Customer")]
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

            var model = new RentalRequestViewModel
            {
                RentalRequest = request
            };

            return View("RentalRequestDetails", model);
        }



    }
}
