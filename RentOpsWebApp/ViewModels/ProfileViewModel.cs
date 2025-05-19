using System.Collections;
using System.Collections.Generic;
using RentOpsObjects.Model;

namespace RentOpsWebApp.ViewModels
{
    public class ProfileViewModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAddress { get; set; }
        public string? PhoneNumber { get; set; }
        public int? TotalRentals { get; set; }
        public int? UserId { get; set; }

    }
}
