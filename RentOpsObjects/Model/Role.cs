﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RentOpsObjects.Model;

[Table("Role")]
public partial class Role
{
    [Key]
    [Column("roleID")]
    public int RoleId { get; set; }

    [Column("roleTitle")]
    [StringLength(50)]
    public string RoleTitle { get; set; } = null!;

    [InverseProperty("Role")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
