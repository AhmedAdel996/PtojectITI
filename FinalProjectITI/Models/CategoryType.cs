using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectITI.Models
{
    [Table("CategoryType")]
    public class CategoryType
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryType_ID { get; set; }
        [Required, MaxLength(50)]
        public string CategoryType_Name { get; set; }
        public string CategoryType_Description { get; set; }

        public virtual ICollection<ProductCategoryTypes> ProductCategoryTypes { get; set; }
    }
}
