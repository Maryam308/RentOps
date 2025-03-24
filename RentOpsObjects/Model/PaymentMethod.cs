using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RentOpsObjects.Model;

[Table("PaymentMethod")]
public partial class PaymentMethod
{
    [Key]
    [Column("paymentMethodID")]
    public int PaymentMethodId { get; set; }

    [Column("paymentMethodTitle")]
    [StringLength(100)]
    public string PaymentMethodTitle { get; set; } = null!;

    [InverseProperty("PaymentMethod")]
    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
