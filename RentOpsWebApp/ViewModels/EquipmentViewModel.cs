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
        public Equipment newEquipment { get; set; } = new Equipment();


    }
}
