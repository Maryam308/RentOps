﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RentOpsObjects.Model;

[Table("Notification")]
public partial class Notification
{
    [Key]
    [Column("notificationID")]
    public int NotificationId { get; set; }

    [Column("userID")]
    public int UserId { get; set; }

    [Column("messageContentID")]
    public int MessageContentId { get; set; }

    [Column("notificationStatusID")]
    public int NotificationStatusId { get; set; }

    [Column("notificationTimestamp")]
    public DateTime NotificationTimestamp { get; set; }

    [ForeignKey("MessageContentId")]
    [InverseProperty("Notifications")]
    public virtual MessageContent MessageContent { get; set; } = null!;

    [ForeignKey("NotificationStatusId")]
    [InverseProperty("Notifications")]
    public virtual NotificationStatus NotificationStatus { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("Notifications")]
    public virtual User User { get; set; } = null!;
}
