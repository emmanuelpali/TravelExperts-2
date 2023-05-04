using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TravelExpertsData
{
    [Index("AgentId", Name = "EmployeesCustomers")]
    public partial class Customer
    {
        public Customer()
        {
            Bookings = new HashSet<Booking>();
            CreditCards = new HashSet<CreditCard>();
            CustomersRewards = new HashSet<CustomersReward>();
        }

        [Key]
        public int CustomerId { get; set; }
        [StringLength(25)]
        [Required]
        [Display(Name = "First Name")]
        public string CustFirstName { get; set; } = null!;
        [StringLength(25)]
        [Required]
        [Display(Name = "Last Name")]
        public string CustLastName { get; set; } = null!;
        [StringLength(75)]
        [Required]
        [Display(Name = "Address")]
        public string CustAddress { get; set; } = null!;
        [StringLength(50)]
        [Required]
        [Display(Name = "City")]
        public string CustCity { get; set; } = null!;
        [StringLength(2)]
        [Required]
        [Display(Name = "Province")]
        public string CustProv { get; set; } = null!;
        [StringLength(7)]
        [Required]
        [Display(Name = "Postal Code")]
        public string CustPostal { get; set; } = null!;
        [StringLength(25)]
        [Required]
        [Display(Name = "Country")]
        public string? CustCountry { get; set; }
        [StringLength(20)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone")]
        public string? CustHomePhone { get; set; }
        [StringLength(20)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Business Phone")]
        public string CustBusPhone { get; set; } = null!;
        [StringLength(50)]
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string CustEmail { get; set; } = null!;
        public int? AgentId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        [Required]
        public string? Username { get; set; }
        [StringLength(50)]
        [Required]
        [Unicode(false)]
        public string? Password { get; set; }
        [Required(ErrorMessage = "Please confirm your password.")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        [StringLength(30)]
        [Display(Name = "Confirm Password")]
        [NotMapped]
        public string ConfirmPassword { get; set; }

        [ForeignKey("AgentId")]
        [InverseProperty("Customers")]
        public virtual Agent? Agent { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<Booking> Bookings { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<CreditCard> CreditCards { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<CustomersReward> CustomersRewards { get; set; }
    }
}
