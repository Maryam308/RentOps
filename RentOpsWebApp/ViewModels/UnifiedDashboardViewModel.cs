using RentOpsObjects.Model;

namespace RentOpsWebApp.ViewModels
{
    public class UnifiedDashboardViewModel
    {
        // Rental Dashboard Stats
        public decimal? TotalIncome { get; set; }
        public double? AverageRentalPeriod { get; set; }
        public int? AvailableEquipments { get; set; }
        public int? TodayRentalRequests { get; set; }
        public int? LastMonthRentals { get; set; }
        public int? CurrentlyRented { get; set; }
        public int? PenndingRequests { get; set; }
        public int? CompletedRequests { get; set; }
        public int? ApprovedRequests { get; set; }
        public int? RejectedRequests { get; set; }
        public int? OverdueRequests { get; set; }


        // Equipment Dashboard Stats
        public int? EquipmentCount { get; set; }
        public string? FrequentlyRented { get; set; }
        public int? DamagedEquipment { get; set; }
        public int? AvailableForRental { get; set; }
        public int? HeavyMachineryRequests { get; set; }
        public int? PowerToolsRequests { get; set; }
        public int? SaftyEquipmentsRequests { get; set; }
        public int? SurveyingInstrumentsRequests { get; set; }
        public int? LaddersAndScaffoldingRequests { get; set; }
        public int? ConcreteEquipmentRequests { get; set; }
        public int? DamageReports { get; set; }

    }
}