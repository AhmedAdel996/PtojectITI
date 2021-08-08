using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectITI.Models
{
    [Table("Payment")]
    public class Payment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Payment_ID { get; set; }
        public string Payment_Method { get; set; }
        public int Payment_Status { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
