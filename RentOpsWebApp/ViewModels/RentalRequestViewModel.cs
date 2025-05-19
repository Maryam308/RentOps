using RentOpsObjects.Model;

namespace RentOpsWebApp.ViewModels
{
    public class RentalRequestViewModel
    {
        public IEnumerable<RentalRequest>? rentalRequests { get; set; }

        public RentalRequest? rentalRequest { get; set; }

        public IEnumerable<RentalRequestStatus>? rentalRequestStatuses { get; set; }

        public IEnumerable<Equipment>? equipmentTitle { get; set; }
        public IFormFile? UploadedAgreement { get; set; } // agreements are allowed to be uploaded from the manager / admin side and the customer can download them and replace them as well

        public string? SearchRentalRequestId { get; set; }

        public string? SearchRentalRequestStatusId { get; set; }

        public string? SearchEquipmentId { get; set; }


        public RentalRequest? RentalRequest { get; set; } = new RentalRequest();


        public RentalTransaction? NewRentalTransaction { get; set; } = new RentalTransaction();

    }
}
