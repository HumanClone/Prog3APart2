using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Permissions;

#nullable disable
//estblishing the model and using data annotations to validate the data
namespace FarmerTracker.Models
{
    public partial class Product
    {
        [Display(Name = "Product Id")]
        [Key]

        public int ProductId { get; set; }

        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "Please enter product name")]
        public string Pname { get; set; }
        
        [Display(Name = "Product Type")]
        [Required(ErrorMessage = "Please select product type")]
        public string Ptype { get; set; }

        [Display(Name = "Product Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter product date")]
        public DateTime? Pdate { get; set; }

        [Display(Name = "Product Price")]
        [Required(ErrorMessage = "Please enter product price")]
        public decimal? Price { get; set; }

        [Display(Name = "Farmer Id")]
        public int? UserId { get; set; }

        public virtual User User { get; set; }
    }
}
