using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectITI.Models
{
    [Table("Visa")]
    public class Visa
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Visa_ID { get; set; }

        [Required , RegularExpression(@"\d{16}")]
        public int Visa_Number { get; set; }

        [Column(TypeName = "date")]
        public DateTime Expire_Date { get; set; }

        [Required, RegularExpression(@"\d{3}")]
        public int SecureCode { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
    }
}
