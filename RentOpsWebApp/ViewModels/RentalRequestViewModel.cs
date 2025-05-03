using RentOpsObjects.Model;

namespace RentOpsWebApp.ViewModels
{
    public class RentalRequestViewModel
    {
        public IEnumerable<RentalRequest>? rentalRequests { get; set; }

        public IEnumerable<RentalRequestStatus>? rentalRequestStatuses { get; set; }

        public IEnumerable<Equipment>? equipmentTitle { get; set; }

        public string? SearchRentalRequestId { get; set; }

        public string? SearchRentalRequestStatusId { get; set; }

        public string? SearchEquipmentId { get; set; }


        public RentalRequest RentalRequest { get; set; } = new RentalRequest();

    }
}
