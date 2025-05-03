using System.Collections.Generic;
using RentOpsObjects.Model;
namespace RentOpsWebApp.ViewModels
{
    public class EquipmentViewModel
    {
        public IEnumerable<Equipment>? Equipment { get; set; }
        public IEnumerable<EquipmentCategory>? EquipmentCategories{ get; set; }

        public IEnumerable<ConditionStatus>? EquipmentStatuses { get; set; }

        public IEnumerable<AvailabilityStatus>? EquipmentAvailability { get; set; }

        public int? SearchEquipmentId { get; set; }

        public string? SearchEquipmentName { get; set; }

        public string? SearchCategory { get; set; }

        public string? SearchAvailability { get; set; }

        public string? SearchCondition { get; set; }

        // For form binding:
        public Equipment NewEquipment { get; set; } = new Equipment();

        //rental request object for the request form 
        public RentalRequest RentalRequest { get; set; } = new RentalRequest();

        //feedbacks related to the equipment
        public IEnumerable<Feedback>? EquipmentFeedbacks { get; set; }

    }
}
