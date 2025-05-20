using System.Security.Cryptography.X509Certificates;
using RentOpsObjects.Model;

namespace RentOpsWebApp.ViewModels
{
    public class ReturnRecordViewModel
    {
        public IEnumerable<ReturnRecord>? returnRecords { get; set; }

        public IEnumerable<ConditionStatus>? conditionStatuses { get; set; }

        public IEnumerable<RentalTransaction>? rentalTransactions { get; set; }

        public IFormFile? UploadedFile { get; set; } // Document to be uploaded

        public string? SearchReturnRecordId { get; set; }

        public string? SearchRentalTransactionId { get; set; }

        public string? SearchConditionStatus { get; set; }
        public string? SearchActualReturnDate { get; set; }

        

        //object used for crud operations
        public ReturnRecord? theReturnRecord { get; set; }

        //properties used in the feedback form
        public Feedback? NewFeedback { get; set; }
        public Equipment? Equipment { get; set; }

        public List<int>? RentalTransactionIdsWithFeedback { get; set; }

        // pagination properties
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }

    }
}
