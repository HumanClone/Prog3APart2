using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Permissions;


#nullable disable

namespace FarmerTracker.Models
{
    public partial class Product
    {
        [Display(Name = "Product Id")]
        public int ProductId { get; set; }

        [Display(Name = "Product Name")]
        public string Pname { get; set; }
        
        [Display(Name = "Product Type")]
        public string Ptype { get; set; }

        [Display(Name = "Product Date")]
        [DataType(DataType.Date)]
        public DateTime? Pdate { get; set; }

        [Display(Name = "Farmer Id")]
        public int? UserId { get; set; }

        public virtual User User { get; set; }
    }
}
