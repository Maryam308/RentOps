using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RentOpsObjects.Model;

[Table("RentalTransaction")]
public partial class RentalTransaction
{
    [Key]
    [Column("rentalTransactionID")]
    public int RentalTransactionId { get; set; }

    [Column("pickupDate")]
    public DateOnly PickupDate { get; set; }

    [Column("returnDate")]
    public DateOnly ReturnDate { get; set; }

    [Column("paymentID")]
    public int? PaymentId { get; set; }

    [Column("rentalRequestID")]
    public int? RentalRequestId { get; set; }

    [Column("deposit")]
    public double Deposit { get; set; }

    [Column("employeeID")]
    public int EmployeeId { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("RentalTransactions")]
    public virtual User Employee { get; set; } = null!;

    [ForeignKey("PaymentId")]
    [InverseProperty("RentalTransactions")]
    public virtual Payment? Payment { get; set; }

    [ForeignKey("RentalRequestId")]
    [InverseProperty("RentalTransactions")]
    public virtual RentalRequest? RentalRequest { get; set; }

    [InverseProperty("RentalTransaction")]
    public virtual ICollection<ReturnRecord> ReturnRecords { get; set; } = new List<ReturnRecord>();
}
