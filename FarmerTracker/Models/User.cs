using System;
using System.Collections.Generic;

#nullable disable

namespace FarmerTracker.Models
{
    public partial class User
    {
        public User()
        {
            Products = new HashSet<Product>();
        }

        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool? Farmer { get; set; }
        public string UserPassword { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
