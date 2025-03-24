using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RentOpsObjects.Model;

[Table("EquipmentCategory")]
public partial class EquipmentCategory
{
    [Key]
    [Column("equipmentCategoryID")]
    public int EquipmentCategoryId { get; set; }

    [Column("equipmentCategoryTitle")]
    [StringLength(100)]
    public string EquipmentCategoryTitle { get; set; } = null!;

    [InverseProperty("EquipmentCategory")]
    public virtual ICollection<Equipment> Equipment { get; set; } = new List<Equipment>();
}
