using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RentOpsObjects.Model;

[Table("AvailabilityStatus")]
public partial class AvailabilityStatus
{
    [Key]
    [Column("availabilityStatusID")]
    public int AvailabilityStatusId { get; set; }

    [Column("availabilityStatusTitle")]
    [StringLength(100)]
    public string AvailabilityStatusTitle { get; set; } = null!;

    [InverseProperty("AvailabilityStatus")]
    public virtual ICollection<Equipment> Equipment { get; set; } = new List<Equipment>();
}
