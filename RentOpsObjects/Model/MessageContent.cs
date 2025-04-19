using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RentOpsObjects.Model;

[Table("MessageContent")]
public partial class MessageContent
{
    [Key]
    [Column("messageContentID")]
    public int MessageContentId { get; set; }

    [Column("messageTypeID")]
    public int MessageTypeId { get; set; }

    [Column("messageContentText")]
    [StringLength(300)]
    public string MessageContentText { get; set; } = null!;

    [ForeignKey("MessageTypeId")]
    [InverseProperty("MessageContents")]
    public virtual MessageType MessageType { get; set; } = null!;

    [InverseProperty("MessageContent")]
    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();
}
