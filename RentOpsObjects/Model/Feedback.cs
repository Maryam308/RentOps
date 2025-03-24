using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RentOpsObjects.Model;

[Table("Feedback")]
public partial class Feedback
{
    [Key]
    [Column("feedbackID")]
    public int FeedbackId { get; set; }

    [Column("userID")]
    public int? UserId { get; set; }

    [Column("equipmentID")]
    public int? EquipmentId { get; set; }

    [Column("feedbackTimestamp", TypeName = "datetime")]
    public DateTime FeedbackTimestamp { get; set; }

    [Column("commentText")]
    [StringLength(300)]
    public string? CommentText { get; set; }

    [Column("rating")]
    public int Rating { get; set; }

    [ForeignKey("EquipmentId")]
    [InverseProperty("Feedbacks")]
    public virtual Equipment? Equipment { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("Feedbacks")]
    public virtual User? User { get; set; }
}
