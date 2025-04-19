using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RentOpsObjects.Model;

[Table("Log")]
public partial class Log
{
    [Key]
    [Column("logID")]
    public int LogId { get; set; }

    [Column("userID")]
    public int? UserId { get; set; }

    [Column("logTypeID")]
    public int LogTypeId { get; set; }

    [Column("exception")]
    [StringLength(500)]
    public string? Exception { get; set; }

    [Column("userAction")]
    [StringLength(200)]
    public string? UserAction { get; set; }

    [Column("logTimestamp")]
    public DateTime LogTimestamp { get; set; }

    [Column("affectedData")]
    [StringLength(200)]
    public string? AffectedData { get; set; }

    [Column("sourceID")]
    public int SourceId { get; set; }

    [ForeignKey("LogTypeId")]
    [InverseProperty("Logs")]
    public virtual LogType LogType { get; set; } = null!;

    [ForeignKey("SourceId")]
    [InverseProperty("Logs")]
    public virtual Source Source { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("Logs")]
    public virtual User? User { get; set; }
}
