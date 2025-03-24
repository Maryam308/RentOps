using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RentOpsObjects.Model;

[Table("FileType")]
public partial class FileType
{
    [Key]
    [Column("fileTypeID")]
    public int FileTypeId { get; set; }

    [Column("fileTypeTitle")]
    [StringLength(100)]
    public string FileTypeTitle { get; set; } = null!;

    [InverseProperty("FileType")]
    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();
}
