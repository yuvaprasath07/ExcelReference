using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    [Table("L_Utility", Schema = "COM")]
    public class UtilityModel
    {
        [Key]
        public int UtilityId { get; set; }

        public string? UtilityName { get;set; }

        public string? NativeDescription { get; set; }
    }
}
