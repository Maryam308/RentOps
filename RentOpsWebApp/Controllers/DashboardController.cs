using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentOpsObjects.Model;
using RentOpsWebApp.ViewModels;
using RentOpsObjects.Services;

namespace RentOpsWebApp.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        RentOpsDBContext _context;
        AuditLogger logger;


        public DashboardController(RentOpsDBContext context)
        {
            _context = context;
            logger = new AuditLogger(_context);


        }
        public IActionResult Index()
        {
            return View();

        }
        public IActionResult Dashboard()
        {

            try
            {
                // Fetch the current user id
                var userEmail = User?.Identity?.Name;
                var currentUserId = _context.Users
                    .FirstOrDefault(u => u.Email == userEmail)?.UserId;

                //inside the try 
                int userId = 1;
                if (currentUserId != null)
                {
                    userId = (int)currentUserId;
                }

                //Equipmint Dashboard

                // Fetch the total number of current user equipment 
                var totalEquipment = _context.Equipment.Count();
                //fetch frequently rented equipment object
                var frequentlyRentedEquipment = _context.RentalTransactions
                    .Where(rt => rt.EquipmentId != null)
                    .GroupBy(rt => rt.EquipmentId)
                    .Select(g => new
                    {
                        EquipmentId = g.Key,
                        EquipmentName = _context.Equipment
                            .Where(e => e.EquipmentId == g.Key)
                            .Select(e => e.EquipmentName)
                            .FirstOrDefault(),
                        RentalCount = g.Count()
                    })
                    .OrderByDescending(g => g.RentalCount)
                    .FirstOrDefault();

                //fetch the frequently rented equipment name
                var frequentlyRentedEquipmentName = frequentlyRentedEquipment != null ? frequentlyRentedEquipment.EquipmentName : "";

                //fetch the condition status 
                ConditionStatus damaged = _context.ConditionStatuses.Where(cs => cs.ConditionStatusTitle == "Requires Maintenance").FirstOrDefault();

                ConditionStatus outOfOrder = _context.ConditionStatuses.Where(cs => cs.ConditionStatusTitle == "Out of Order").FirstOrDefault();


                //fech the number of the damaged equipment
                var damagedEquipment = _context.Equipment
                    .Count(e => e.ConditionStatusId == damaged.ConditionStatusId || e.ConditionStatusId == outOfOrder.ConditionStatusId); // under maintinance or out of service


                // Fetch the total number of available equipment
                var availableEquipment = _context.Equipment
                    .Count(e => e.AvailabilityStatusId == 1); // Assuming 1 is the ID for available status

                //Fetch the number of the rental requests for Heavy Machineries
                var heavyMachineryRequestCount = _context.RentalRequests
                    .Where(rr => rr.Equipment.EquipmentCategory.EquipmentCategoryTitle == "Heavy Machinery")
                    .Count();

                // Power Tools
                var powerToolsRequestCount = _context.RentalRequests
                    .Where(rr => rr.Equipment.EquipmentCategory.EquipmentCategoryTitle == "Power Tools")
                    .Count();

                // Safety Equipment
                var safetyEquipmentRequestCount = _context.RentalRequests
                    .Where(rr => rr.Equipment.EquipmentCategory.EquipmentCategoryTitle == "Safety Equipment")
                    .Count();

                // Surveying Instruments
                var surveyingInstrumentsRequestCount = _context.RentalRequests
                    .Where(rr => rr.Equipment.EquipmentCategory.EquipmentCategoryTitle == "Surveying Instruments")
                    .Count();

                // Ladders & Scaffolding
                var laddersScaffoldingRequestCount = _context.RentalRequests
                    .Where(rr => rr.Equipment.EquipmentCategory.EquipmentCategoryTitle == "Ladders & Scaffolding")
                    .Count();

                // Concrete Equipment
                var concreteEquipmentRequestCount = _context.RentalRequests
                    .Where(rr => rr.Equipment.EquipmentCategory.EquipmentCategoryTitle == "Concrete Equipment")
                    .Count();

                // Fetch the number of the damage reports
                var damageReportsCount = _context.Documents
                    .Count(d => d.FileTypeId == 3);



                //Rental Dashboard
                var totalIncome = _context.RentalTransactions
                    .Include(i => i.Equipment)
                    .ThenInclude(t => t.RentalRequests)
                    .Sum(k => k.RentalFee);

                var averageRentalPeriod = _context.RentalTransactions
                    .Include(r => r.Equipment)
                    .Include(r => r.RentalRequest)
                    .Select(r => EF.Functions.DateDiffDay(r.PickupDate, r.ReturnDate))
                    .Average();

                var availableEquipments = _context.Equipment
                    .Include(i => i.AvailabilityStatus)
                    .Where(r => r.AvailabilityStatus.AvailabilityStatusTitle == "Available")
                    .Count();

                //fetching the number of today's rental request 
                var today = DateTime.Today;
                var tomorrow = today.AddDays(1);
                var todayRentalRequests = _context.RentalRequests
                    .Count(r => r.RentalRequestTimestamp >= today && r.RentalRequestTimestamp < tomorrow);


                var now = DateTime.Now;
                //fetching the number of this month  rental request 
                var thisMonthRentals = _context.RentalTransactions
                    .Where(r => r.RentalTransactionTimestamp.Month == now.Month &&
                                r.RentalTransactionTimestamp.Year == now.Year)
                    .Count();

                //fetch the active rentals to a variable
                var activeRentals = _context.RentalTransactions
                    .Include(i => i.Equipment)
                    .Where(r => r.PickupDate <= DateOnly.FromDateTime(DateTime.Today.Date) && r.ReturnDate >= DateOnly.FromDateTime(DateTime.Today.Date))
                    .ToList();


                //fetch the number of pending requests
                var pendingRequestCount = _context.RentalRequests
                    .Where(r => r.RentalRequestId == 1)
                    .Count();

                //fetch the number of the completed requests
                var completedRequestCount = _context.RentalRequests
                    .Count(r => r.RentalRequestStatusId == 2 || r.RentalRequestStatusId == 3);

                //fetch the number of the approved requests
                var approvedRequestCount = _context.RentalRequests
                    .Count(r => r.RentalRequestStatusId == 2);

                //fetch the number of the rejected requests
                var rejectedRequestCount = _context.RentalRequests
                    .Count(r => r.RentalRequestStatusId == 3);

                //fetch the number of the overdue requests
                int overdueCount = _context.RentalTransactions
                    .Where(x => x.ReturnDate < DateOnly.FromDateTime(DateTime.Now))
                    .Count();

                var rentedStatus = _context.AvailabilityStatuses
                  .FirstOrDefault(s => s.AvailabilityStatusTitle == "Out for Rent");

                var currentlyRented = _context.Equipment
                    .Include(i => i.AvailabilityStatus)
                    .Where(r => r.AvailabilityStatus.AvailabilityStatusId == rentedStatus.AvailabilityStatusId)
                    .Count(); ;

                //loop through the active rentals and get the equipment id and mark it as rented
                foreach (var rental in activeRentals)
                {
                    //get the equipment id
                    var equipmentId = rental.EquipmentId;

                    //mark the equipment as rented
                    var equipment = _context.Equipment.Find(equipmentId);
                    if (equipment != null)
                    {
                        equipment.AvailabilityStatusId = rentedStatus.AvailabilityStatusId;

                        //log the changes 
                        logger.TrackChanges(userId,1);
                        _context.SaveChanges();
                    }
                }

                

                var viewModel = new UnifiedDashboardViewModel
                {
                    TotalIncome = Convert.ToDecimal(totalIncome),
                    AverageRentalPeriod = (int)Math.Round(Convert.ToDouble(averageRentalPeriod)),
                    AvailableEquipments = Convert.ToInt32(availableEquipments),
                    TodayRentalRequests = Convert.ToInt32(todayRentalRequests),
                    LastMonthRentals = Convert.ToInt32(thisMonthRentals),
                    CurrentlyRented = Convert.ToInt32(currentlyRented),
                    EquipmentCount = Convert.ToInt32(totalEquipment),
                    FrequentlyRented = frequentlyRentedEquipmentName,
                    DamagedEquipment = Convert.ToInt32(damagedEquipment),
                    AvailableForRental = Convert.ToInt32(availableEquipment),
                    PenndingRequests = Convert.ToInt32(pendingRequestCount),
                    CompletedRequests = Convert.ToInt32(completedRequestCount),
                    ApprovedRequests = Convert.ToInt32(approvedRequestCount),
                    RejectedRequests = Convert.ToInt32(rejectedRequestCount),
                    OverdueRequests = Convert.ToInt32(overdueCount),
                    HeavyMachineryRequests = Convert.ToInt32(heavyMachineryRequestCount),
                    PowerToolsRequests = Convert.ToInt32(powerToolsRequestCount),
                    SaftyEquipmentsRequests = Convert.ToInt32(safetyEquipmentRequestCount),
                    SurveyingInstrumentsRequests = Convert.ToInt32(surveyingInstrumentsRequestCount),
                    LaddersAndScaffoldingRequests = Convert.ToInt32(laddersScaffoldingRequestCount),
                    ConcreteEquipmentRequests = Convert.ToInt32(concreteEquipmentRequestCount),
                    DamageReports = Convert.ToInt32(damageReportsCount),

                };

                return View(viewModel);
            }
            catch (Exception ex)
            {
                //save the error message to the viewbag
                ViewBag.ErrorMessage = ex.Message;
                // return  error view 
                return View("Error");
            }
        }


    }
}