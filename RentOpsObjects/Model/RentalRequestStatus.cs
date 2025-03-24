using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RentOpsObjects.Model;

[Table("RentalRequestStatus")]
public partial class RentalRequestStatus
{
    [Key]
    [Column("rentalRequestStatusID")]
    public int RentalRequestStatusId { get; set; }

    [Column("rentalRequestStatusTitle")]
    [StringLength(100)]
    public string RentalRequestStatusTitle { get; set; } = null!;

    [InverseProperty("RentalRequestStatus")]
    public virtual ICollection<RentalRequest> RentalRequests { get; set; } = new List<RentalRequest>();
}
