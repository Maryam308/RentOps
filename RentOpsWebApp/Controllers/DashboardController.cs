using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentOpsObjects.Model;
using RentOpsWebApp.ViewModels;

namespace RentOpsWebApp.Controllers
{
    public class DashboardController : Controller
    {
        RentOpsDBContext _context;

        public DashboardController(RentOpsDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();

        }
        public IActionResult Dashboard()
        {
            int currentUserId = 2; // Replace with your actual logic

            var totalIncome = _context.RentalTransactions
                .Include(i => i.Equipment)
                .ThenInclude(t => t.RentalRequests)
                .Where(r => r.Equipment.UserId == currentUserId || r.RentalRequest.Equipment.UserId == currentUserId).Sum(k => k.RentalFee);

            var averageRentalPeriod = _context.RentalTransactions
                .Include(r => r.Equipment)
                .Include(r => r.RentalRequest)
                .Where(r => r.Equipment.UserId == currentUserId || r.RentalRequest.Equipment.UserId == currentUserId)
                .Select(r => EF.Functions.DateDiffDay(r.PickupDate, r.ReturnDate))
                .Average();

            var availableEquipments = _context.Equipment
                .Include(i => i.AvailabilityStatus)
                .Where(r => r.UserId == currentUserId && r.AvailabilityStatus.AvailabilityStatusTitle == "Available")
                .Count();

            var todayRentalRequests = _context.RentalRequests
                .Include(i => i.Equipment)
                .ThenInclude(t => t.RentalRequests)
                .Where(r => r.Equipment.UserId == currentUserId && r.RentalRequestTimestamp == DateTime.Now.Date)
                .Count();


            var lastMonthRentals = _context.RentalTransactions
                .Include(i => i.Equipment)
                .ThenInclude(t => t.RentalRequests)
                .Where(r => r.Equipment.UserId == currentUserId && r.RentalTransactionTimestamp.Month == DateTime.Now.Month)
                .Count();

            //fetch the active rentals to a variable
            var activeRentals = _context.RentalTransactions
                .Include(i => i.Equipment)
                .ThenInclude(t => t.RentalRequests)
                .Where(r => r.Equipment.UserId == currentUserId && r.PickupDate <= DateOnly.FromDateTime(DateTime.Today.Date) && r.ReturnDate >= DateOnly.FromDateTime(DateTime.Today.Date))
                .ToList();

            //loop through the active rentals and get the equipment id and mark it as rented
            foreach (var rental in activeRentals)
            {
                //get the equipment id
                var equipmentId = rental.EquipmentId;
                //mark the equipment as rented
                var equipment = _context.Equipment.Find(equipmentId);
                if (equipment != null)
                {
                    equipment.AvailabilityStatusId = 2; // 2 is the id for rented
                    _context.SaveChanges();
                }
            }

            var currentlyRented = _context.Equipment
                .Include(i => i.AvailabilityStatus)
                .Where(r => r.UserId == currentUserId && r.AvailabilityStatus.AvailabilityStatusTitle == "Rented")
                .Count();

            var viewModel = new RentalDashboardViewModel
            {
                TotalIncome = Convert.ToDecimal(totalIncome),
                AverageRentalPeriod = Convert.ToDouble(averageRentalPeriod),
                AvailableEquipments = Convert.ToInt32(availableEquipments),
                TodayRentalRequests = Convert.ToInt32(todayRentalRequests),
                LastMonthRentals = Convert.ToInt32(lastMonthRentals),
                CurrentlyRented = Convert.ToInt32(currentlyRented)
            };


            return View(viewModel); ;
        }


    }
}