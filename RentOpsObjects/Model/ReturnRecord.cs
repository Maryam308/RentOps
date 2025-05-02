using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RentOpsObjects.Model;

[Table("ReturnRecord")]
public partial class ReturnRecord
{
    [Key]
    [Column("returnRecordID")]
    public int ReturnRecordId { get; set; }

    [Column("rentalTransactionID")]
    public int RentalTransactionId { get; set; }

    [Column("actualReturnDate")]
    public DateOnly ActualReturnDate { get; set; }

    [Column("returnConditionID")]
    public int ReturnConditionId { get; set; }

    [Column("lateReturnFee")]
    public double LateReturnFee { get; set; }

    [Column("additionalCharge")]
    public double AdditionalCharge { get; set; }

    [Column("documentID")]
    public int? DocumentId { get; set; }

    [ForeignKey("DocumentId")]
    [InverseProperty("ReturnRecords")]
    public virtual Document? Document { get; set; }

    [ForeignKey("RentalTransactionId")]
    [InverseProperty("ReturnRecords")]
    public virtual RentalTransaction? RentalTransaction { get; set; } //= null!;

    [ForeignKey("ReturnConditionId")]
    [InverseProperty("ReturnRecords")]
    public virtual ConditionStatus? ReturnCondition { get; set; } //= null!;
}
