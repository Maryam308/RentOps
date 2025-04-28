using RentOpsObjects.Model;

namespace RentOpsWebApp.ViewModels
{
    public class ReturnRecordViewModel
    {
        public IEnumerable<ReturnRecord>? returnRecords { get; set; }

        public IEnumerable<ConditionStatus>? conditionStatuses { get; set; }

        public string? SearchReturnRecordId { get; set; }

        public string? SearchRentalTransactionId { get; set; }

        public string? SearchConditionStatus { get; set; }
        public string? SearchActualReturnDate { get; set; }

    }
}
