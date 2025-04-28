namespace RentOpsWebApp.ViewModels
{
    public class RentalDashboardViewModel
    {
        public decimal? TotalIncome { get; set; }
        public double? AverageRentalPeriod { get; set; }
        public int? AvailableEquipments { get; set; }
        public int? TodayRentalRequests { get; set; }
        public int? LastMonthRentals { get; set; }
        public int? CurrentlyRented { get; set; }
    }
}