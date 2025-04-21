using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RentOpsObjects.Model;

[Table("ExternalCustomer")]
public partial class ExternalCustomer
{
    [Key]
    [Column("customerID")]
    public int CustomerId { get; set; }

    [Column("firstName")]
    [StringLength(50)]
    public string FirstName { get; set; } = null!;

    [Column("lastName")]
    [StringLength(50)]
    public string LastName { get; set; } = null!;

    [Column("email")]
    [StringLength(50)]
    public string Email { get; set; } = null!;

    [Column("phoneNumber")]
    [StringLength(10)]
    public string PhoneNumber { get; set; } = null!;
}
