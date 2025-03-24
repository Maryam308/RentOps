using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RentOpsObjects.Model;

[Table("PaymentStatus")]
public partial class PaymentStatus
{
    [Key]
    [Column("paymentStatusID")]
    public int PaymentStatusId { get; set; }

    [Column("paymentStatusTitle")]
    [StringLength(100)]
    public string PaymentStatusTitle { get; set; } = null!;

    [InverseProperty("PaymentStatus")]
    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
