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
    public int? LogTypeId { get; set; }

    [Column("exception")]
    [StringLength(500)]
    public string Exception { get; set; } = null!;

    [Column("userAction")]
    [StringLength(200)]
    public string UserAction { get; set; } = null!;

    [Column("logTimestamp")]
    public byte[] LogTimestamp { get; set; } = null!;

    [Column("affectedData")]
    [StringLength(200)]
    public string AffectedData { get; set; } = null!;

    [Column("sourceID")]
    public int? SourceId { get; set; }

    [ForeignKey("LogTypeId")]
    [InverseProperty("Logs")]
    public virtual LogType? LogType { get; set; }

    [ForeignKey("SourceId")]
    [InverseProperty("Logs")]
    public virtual Source? Source { get; set; }
}
