using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RentOpsObjects.Model;

[Table("MessageType")]
public partial class MessageType
{
    [Key]
    [Column("messageTypeID")]
    public int MessageTypeId { get; set; }

    [Column("messageTypeTitle")]
    [StringLength(100)]
    public string MessageTypeTitle { get; set; } = null!;

    [InverseProperty("MessageType")]
    public virtual ICollection<MessageContent> MessageContents { get; set; } = new List<MessageContent>();
}
