using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RentOpsObjects.Model;

[Table("ConditionStatus")]
public partial class ConditionStatus
{
    [Key]
    [Column("conditionStatusID")]
    public int ConditionStatusId { get; set; }

    [Column("conditionStatusTitle")]
    [StringLength(100)]
    public string ConditionStatusTitle { get; set; } = null!;

    [InverseProperty("ConditionStatus")]
    public virtual ICollection<Equipment> Equipment { get; set; } = new List<Equipment>();

    [InverseProperty("ReturnCondition")]
    public virtual ICollection<ReturnRecord> ReturnRecords { get; set; } = new List<ReturnRecord>();
}
