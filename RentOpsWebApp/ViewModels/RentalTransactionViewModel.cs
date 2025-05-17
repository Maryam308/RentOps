using RentOpsObjects.Model;

namespace RentOpsWebApp.ViewModels
{
    public class RentalTransactionViewModel
    {
        public IEnumerable<RentalTransaction>? rentalTransactions { get; set; }

        public RentalTransaction? rentalTransaction { get; set; }

        public IEnumerable<Equipment>? equipmentTitle { get; set; }

        public IEnumerable<PaymentMethod>? PaymentMethod { get; set; }

        public IEnumerable<PaymentStatus>? PaymentStatus { get; set; }

        public IFormFile? UploadedAgreement { get; set; } // agreements are allowed to be uploaded from the manager / admin side and the customer can download them and replace them as well

        public IFormFile? UploadedIdVerification { get; set; } // Nullable to allow optional upload

        public Document? idVerification { get; set; } // Nullable to allow optional upload

        public Document? rentalAgreement { get; set; } // Nullable to allow optional upload

        public string? SearchRentalTransactionId { get; set; }

        public string? SearchRentalRequestId { get; set; }

        public string? SearchEmployeeId { get; set; }
        public string? SearchTransactionDate { get; set; }

        public string? SearchPayment { get; set; }
        public string? SearchEquipment { get; set; }

        public bool agreementIsModified { get; set; } = false;//used to track if the agreement is modified or not

        public bool idVerificationIsModified { get; set; } = false; //used to track if the agreement is modified or not


    }
}
