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

    //dont allow negative values
    [Range(0, double.MaxValue, ErrorMessage = "Deposit cannot be negative or zero.")]
    [Column("deposit")]
    public double Deposit { get; set; }

    [Column("employeeID")]
    public int EmployeeId { get; set; }

    [Column("customerID")]
    public int? CustomerId { get; set; }

    // dont allow negative values
    [Range(0, double.MaxValue, ErrorMessage = "Rental Fee cannot be negative.")]
    [Column("rentalFee")]
    public double RentalFee { get; set; }

    [Column("userID")]
    public int? UserId { get; set; }

    [Column("equipmentID")]
    public int? EquipmentId { get; set; }

    [Column("rentalTransactionTimestamp")]
    public DateTime RentalTransactionTimestamp { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("RentalTransactions")]
    public virtual ExternalCustomer? Customer { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("RentalTransactionEmployees")]
    public virtual User? Employee { get; set; } //= null!;

    [ForeignKey("EquipmentId")]
    [InverseProperty("RentalTransactions")]
    public virtual Equipment? Equipment { get; set; }

    [InverseProperty("RentalTransaction")]
    public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

    [ForeignKey("PaymentId")]
    [InverseProperty("RentalTransactions")]
    public virtual Payment? Payment { get; set; }

    [ForeignKey("RentalRequestId")]
    [InverseProperty("RentalTransactions")]
    public virtual RentalRequest? RentalRequest { get; set; }

    [InverseProperty("RentalTransaction")]
    public virtual ICollection<ReturnRecord> ReturnRecords { get; set; } = new List<ReturnRecord>();

    [ForeignKey("UserId")]
    [InverseProperty("RentalTransactionUsers")]
    public virtual User? User { get; set; }

    [ForeignKey("RentalTransactionId")]
    [InverseProperty("RentalTransactions")]
    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();
}
