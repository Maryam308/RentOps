using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RentOpsObjects.Model;

[Table("User")]
public partial class User
{
    [Key]
    [Column("userID")]
    public int UserId { get; set; }

    [Column("firstName")]
    [StringLength(50)]
    public string FirstName { get; set; } = null!;

    [Column("lastName")]
    [StringLength(50)]
    public string LastName { get; set; } = null!;

    [Column("email")]
    [StringLength(50)]
    public string Email { get; set; } = null!;

    [Column("roleID")]
    public int RoleId { get; set; }

    [Column("phoneNumber")]
    [StringLength(10)]
    public string? PhoneNumber { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();

    [InverseProperty("User")]
    public virtual ICollection<Equipment> Equipment { get; set; } = new List<Equipment>();

    [InverseProperty("User")]
    public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

    [InverseProperty("User")]
    public virtual ICollection<Log> Logs { get; set; } = new List<Log>();

    [InverseProperty("User")]
    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    [InverseProperty("User")]
    public virtual ICollection<RentalRequest> RentalRequests { get; set; } = new List<RentalRequest>();

    [InverseProperty("Employee")]
    public virtual ICollection<RentalTransaction> RentalTransactionEmployees { get; set; } = new List<RentalTransaction>();

    [InverseProperty("User")]
    public virtual ICollection<RentalTransaction> RentalTransactionUsers { get; set; } = new List<RentalTransaction>();

    [ForeignKey("RoleId")]
    [InverseProperty("Users")]
    public virtual Role Role { get; set; } = null!;
}
