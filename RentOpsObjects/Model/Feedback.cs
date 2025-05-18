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

    [Column("feedbackTimestamp", TypeName = "datetime")]
    public DateTime FeedbackTimestamp { get; set; }

    [Required(ErrorMessage = "Please enter a comment.")]
    [Column("commentText")]
    [StringLength(300)]
    public string? CommentText { get; set; }

    [Required(ErrorMessage = "Please select a rating.")]
    [Column("rating")]
    public int? Rating { get; set; }

    [Column("rentalTransactionID")]
    public int RentalTransactionId { get; set; }

    [Column("isHidden")]
    public bool IsHidden { get; set; }

    [ForeignKey("RentalTransactionId")]
    [InverseProperty("Feedbacks")]
    public virtual RentalTransaction? RentalTransaction { get; set; } //= null!;


}
