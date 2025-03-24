using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RentOpsObjects.Model;

[Table("Source")]
public partial class Source
{
    [Key]
    [Column("sourceID")]
    public int SourceId { get; set; }

    [Column("sourceTitle")]
    [StringLength(200)]
    public string SourceTitle { get; set; } = null!;

    [InverseProperty("Source")]
    public virtual ICollection<Log> Logs { get; set; } = new List<Log>();
}
