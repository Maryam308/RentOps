using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RentOpsObjects.Model;

[Table("LogType")]
public partial class LogType
{
    [Key]
    [Column("logTypeID")]
    public int LogTypeId { get; set; }

    [Column("logTypeTitle")]
    [StringLength(100)]
    public string LogTypeTitle { get; set; } = null!;

    [InverseProperty("LogType")]
    public virtual ICollection<Log> Logs { get; set; } = new List<Log>();
}
