using System;
using System.Collections.Generic;

#nullable disable

namespace FarmerTracker.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string Pname { get; set; }
        public string Ptype { get; set; }
        public DateTime? Pdate { get; set; }
        public int? UserId { get; set; }

        public virtual User User { get; set; }
    }
}
