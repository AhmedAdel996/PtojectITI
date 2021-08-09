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
        
        public int? Visa_ID { get; set; }

        public int? Paypal_ID { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        [ForeignKey("Paypal_ID")]
        public virtual Paypal Paypal { get; set; }

        [ForeignKey("Visa_ID")]
        public Visa Visa { get; set; }
    }
}
