using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectITI.Models
{
    [Table("Product")]
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Product_ID { get; set; }
        [Required, MaxLength(50)]
        public string Product_Name { get; set; }
        public int? Category_ID { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Product_Price { get; set; }
        [Required]
        public string Product_Image { get; set; }
        [Required]
        public string Product_Size { get; set; }
        [Required]
        public string Product_Color { get; set; }

        [ForeignKey("Category_ID")]
        public virtual Category Category { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }

        public virtual ICollection<ProductCategoryTypes> ProductCategoryTypes { get; set; }

        public virtual ICollection<UserProducts> UserProducts { get; set; }
    }
}
