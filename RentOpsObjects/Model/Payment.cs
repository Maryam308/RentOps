using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RentOpsObjects.Model;

[Table("Payment")]
public partial class Payment
{
    [Key]
    [Column("paymentID")]
    public int PaymentId { get; set; }

    [Column("paymentStatusID")]
    public int PaymentStatusId { get; set; }

    [Column("paymentMethodID")]
    public int PaymentMethodId { get; set; }

    [ForeignKey("PaymentMethodId")]
    [InverseProperty("Payments")]
    public virtual PaymentMethod? PaymentMethod { get; set; } 

    [ForeignKey("PaymentStatusId")]
    [InverseProperty("Payments")]
    public virtual PaymentStatus? PaymentStatus { get; set; }

    [InverseProperty("Payment")]
    public virtual ICollection<RentalTransaction> RentalTransactions { get; set; } = new List<RentalTransaction>();
}
