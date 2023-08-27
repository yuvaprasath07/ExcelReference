using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    [Table("L_PaymentCategory", Schema = "COM")]
    public class L_PaymentCategory
    {
        [Key]
        public int PaymentCategoryId { get; set; }

        public string? PaymentCategoryCode { get; set; }

        public string? NativeDescription { get; set; }
    }
}
