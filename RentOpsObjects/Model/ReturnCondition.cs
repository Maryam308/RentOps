using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RentOpsObjects.Model;

[Table("ReturnCondition")]
public partial class ReturnCondition
{
    [Key]
    [Column("returnConditionID")]
    public int ReturnConditionId { get; set; }

    [Column("returnConditionTitle")]
    [StringLength(100)]
    public string ReturnConditionTitle { get; set; } = null!;

    [InverseProperty("ReturnCondition")]
    public virtual ICollection<ReturnRecord> ReturnRecords { get; set; } = new List<ReturnRecord>();
}
