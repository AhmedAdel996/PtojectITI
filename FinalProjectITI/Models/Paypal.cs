using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectITI.Models
{
    [Table("Paypal")]
    public class Paypal
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Paypal_ID { get; set; }

        [Required , EmailAddress]
        public string Account { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
    }
}
