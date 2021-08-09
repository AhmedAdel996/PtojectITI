using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectITI.Models
{
    public class BlogCategoryTypes
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BlogCategoryTypes_ID { get; set; }
        public int? Blog_ID { get; set; }
        public int? CategoryType_ID { get; set; }

        [ForeignKey("Blog_ID")]
        public virtual Blog Blog { get; set; }

        [ForeignKey("CategoryType_ID")]
        public virtual CategoryType CategoryType { get; set; }
    }
}
