using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RentOpsObjects.Model;

[Table("RentalRequest")]
public partial class RentalRequest
{
    [Key]
    [Column("rentalRequestID")]
    public int RentalRequestId { get; set; }

    [Column("rentalStartDate")]
    public DateOnly RentalStartDate { get; set; }

    [Column("rentalReturnDate")]
    public DateOnly RentalReturnDate { get; set; }

    [Column("rentalTotalCost")]
    public double RentalTotalCost { get; set; }

    [Column("rentalRequestStatusID")]
    public int? RentalRequestStatusId { get; set; }

    [Column("equipmentID")]
    public int? EquipmentId { get; set; }

    [Column("userID")]
    public int? UserId { get; set; }

    [Column("rentalRequestTimestamp")]
    public DateTime RentalRequestTimestamp { get; set; }

    [ForeignKey("EquipmentId")]
    [InverseProperty("RentalRequests")]
    public virtual Equipment? Equipment { get; set; }

    [ForeignKey("RentalRequestStatusId")]
    [InverseProperty("RentalRequests")]
    public virtual RentalRequestStatus? RentalRequestStatus { get; set; }

    [InverseProperty("RentalRequest")]
    public virtual ICollection<RentalTransaction> RentalTransactions { get; set; } = new List<RentalTransaction>();

    [ForeignKey("UserId")]
    [InverseProperty("RentalRequests")]
    public virtual User? User { get; set; }
}
