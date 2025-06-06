﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RentOpsObjects.Model;

public partial class Equipment
{
    [Key]
    [Column("equipmentID")]
    public int EquipmentId { get; set; }

    
    [Column("equipmentName")]
    [StringLength(100)]
    [MinLength(3, ErrorMessage = "Equipment name must be at least 3 characters long.")]
    public string EquipmentName { get; set; } = null!;

    [Column("equipmentDescription")]
    [StringLength(250)]
    [MinLength(10, ErrorMessage = "Equipment description must be at least 3 characters long.")]
    public string EquipmentDescription { get; set; } = null!;

    //dont allow negative values or zero
    [Range(0.001, double.MaxValue, ErrorMessage = "Invalid Rental Price")]
    [Column("rentalPrice")]
    public double RentalPrice { get; set; }

    [Column("availabilityStatusID")]
    public int AvailabilityStatusId { get; set; }

    [Column("conditionStatusID")]
    public int ConditionStatusId { get; set; }

    [Column("equipmentCategoryID")]
    public int EquipmentCategoryId { get; set; }

    [Column("userID")]
    public int UserId { get; set; }

    [ForeignKey("AvailabilityStatusId")]
    [InverseProperty("Equipment")]
    public virtual AvailabilityStatus? AvailabilityStatus { get; set; } //= null!;

    [ForeignKey("ConditionStatusId")]
    [InverseProperty("Equipment")]
    public virtual ConditionStatus? ConditionStatus { get; set; } //= null!;

    [ForeignKey("EquipmentCategoryId")]
    [InverseProperty("Equipment")]
    public virtual EquipmentCategory? EquipmentCategory { get; set; } //= null!;

    [InverseProperty("Equipment")]
    public virtual ICollection<RentalRequest> RentalRequests { get; set; } = new List<RentalRequest>();

    [InverseProperty("Equipment")]
    public virtual ICollection<RentalTransaction> RentalTransactions { get; set; } = new List<RentalTransaction>();

    [ForeignKey("UserId")]
    [InverseProperty("Equipment")]
    public virtual User? User { get; set; } 
}
