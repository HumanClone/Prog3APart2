using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;

#nullable disable
//estblishing the model and using data annotations to validate the data
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
        [Required(ErrorMessage = "Please enter full name")]
        public string FullName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter email address")]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please enter phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please select an option")]
        public string Farmer { get; set; }
        
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please enter password")]
        public string UserPassword { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
    }
}