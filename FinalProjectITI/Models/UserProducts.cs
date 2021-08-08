using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectITI.Models
{
    public class UserProducts
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserProducts_ID { get; set; }
        [Required]
        public string Customer_ID { get; set; }
        public int Product_ID { get; set; }
        public int Product_Quantity { get; set; }

        [ForeignKey("Customer_ID")]
        public virtual IdentityUser Customer { get; set; }

        [ForeignKey("Product_ID")]
        public virtual Product Product { get; set; }
    }
}
