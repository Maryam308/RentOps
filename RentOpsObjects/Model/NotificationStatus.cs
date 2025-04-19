using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RentOpsObjects.Model;

[Table("NotificationStatus")]
public partial class NotificationStatus
{
    [Key]
    [Column("notificationStatusID")]
    public int NotificationStatusId { get; set; }

    [Column("notificationStatusTitle")]
    [StringLength(200)]
    public string NotificationStatusTitle { get; set; } = null!;

    [InverseProperty("NotificationStatus")]
    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();
}
