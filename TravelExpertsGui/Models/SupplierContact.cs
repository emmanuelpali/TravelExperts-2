﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TravelExpertsGui.Models
{
    [Index("AffiliationId", Name = "AffiliationsSupCon")]
    [Index("SupplierId", Name = "SuppliersSupCon")]
    public partial class SupplierContact
    {
        [Key]
        public int SupplierContactId { get; set; }
        [StringLength(50)]
        public string? SupConFirstName { get; set; }
        [StringLength(50)]
        public string? SupConLastName { get; set; }
        [StringLength(255)]
        public string? SupConCompany { get; set; }
        [StringLength(255)]
        public string? SupConAddress { get; set; }
        [StringLength(255)]
        public string? SupConCity { get; set; }
        [StringLength(255)]
        public string? SupConProv { get; set; }
        [StringLength(255)]
        public string? SupConPostal { get; set; }
        [StringLength(255)]
        public string? SupConCountry { get; set; }
        [StringLength(50)]
        public string? SupConBusPhone { get; set; }
        [StringLength(50)]
        public string? SupConFax { get; set; }
        [StringLength(255)]
        public string? SupConEmail { get; set; }
        [Column("SupConURL")]
        [StringLength(255)]
        public string? SupConUrl { get; set; }
        [StringLength(10)]
        public string? AffiliationId { get; set; }
        public int? SupplierId { get; set; }

        [ForeignKey("AffiliationId")]
        [InverseProperty("SupplierContacts")]
        public virtual Affiliation? Affiliation { get; set; }
        [ForeignKey("SupplierId")]
        [InverseProperty("SupplierContacts")]
        public virtual Supplier? Supplier { get; set; }
    }
}
