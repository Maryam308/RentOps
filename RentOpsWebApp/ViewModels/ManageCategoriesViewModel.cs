using RentOpsObjects.Model;

namespace RentOpsWebApp.ViewModels
{
    public class ManageCategoriesViewModel
    {
        public IEnumerable<Equipment>? Equipment { get; set; }
        public IEnumerable<EquipmentCategory>? EquipmentCategories { get; set; }

        public IEnumerable<ConditionStatus>? EquipmentStatuses { get; set; }

        public IEnumerable<AvailabilityStatus>? EquipmentAvailability { get; set; }

    }
}
