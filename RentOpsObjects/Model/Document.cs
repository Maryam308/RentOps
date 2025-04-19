using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RentOpsObjects.Model;

[Table("Document")]
public partial class Document
{
    [Key]
    [Column("documentID")]
    public int DocumentId { get; set; }

    [Column("userID")]
    public int UserId { get; set; }

    [Column("fileName")]
    [StringLength(100)]
    public string FileName { get; set; } = null!;

    [Column("uploadDate")]
    public DateTime UploadDate { get; set; }

    [Column("fileTypeID")]
    public int FileTypeId { get; set; }

    [Column("storagePath")]
    [StringLength(100)]
    public string StoragePath { get; set; } = null!;

    [Column("fileData")]
    public byte[] FileData { get; set; } = null!;

    [ForeignKey("FileTypeId")]
    [InverseProperty("Documents")]
    public virtual FileType FileType { get; set; } = null!;

    [InverseProperty("Document")]
    public virtual ICollection<ReturnRecord> ReturnRecords { get; set; } = new List<ReturnRecord>();

    [ForeignKey("UserId")]
    [InverseProperty("Documents")]
    public virtual User User { get; set; } = null!;
}
