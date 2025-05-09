namespace RentOpsWebApp.ViewModels
{
    public class NotificationDetailsViewModel
    {
        public string MessageContentText { get; set; }
        public string NotificationStatusTitle { get; set; }
        public DateTime NotificationTimestamp { get; set; }

        
        public int? RentalRequestId { get; set; }
        public string RentalRequestStatusTitle { get; set; }
        public string EquipmentTitle { get; set; }
        public string UserFullName { get; set; }
        public DateTime? RentalStartDate { get; set; }
        public DateTime? RentalReturnDate { get; set; }

       
    }

}
