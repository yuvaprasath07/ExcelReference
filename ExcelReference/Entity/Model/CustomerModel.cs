using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Model
{
    [Table("L_CustomerType", Schema = "COM")]
    public class L_CustomerType
    {
        [Key]
        public int CustomerTypeId { get; set; }
        public string? CustomerTypeName { get; set; }
        public string? CustomerTypeCode { get; set; }
        public bool IsActive { get; set; }
        public int SortOrder { get; set; }
        public int CreatedBy { get; set; }
        public string? NativeDescription { get; set; }
    }


}