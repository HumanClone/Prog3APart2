using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;


#nullable disable

namespace FarmerTracker.Models
{
    public partial class User
    {
        public User()
        {
            Products = new HashSet<Product>();
        }

        [Display(Name = "User Id")]
        [Key]
        public int UserId { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }


        public bool? Farmer { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
