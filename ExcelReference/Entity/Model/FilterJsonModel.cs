using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class FilterJsonModel
    {
        public object customerName { get; set; }
        public object CompanyNameKana { get; set; }

        public object FirstName  { get; set; }

        public object MiddleName { get; set; }

        public object SPID { get; set; }

        public object Area { get; set; }

        public object ClientCode { get; set; }

        public object LoadProfileCode { get; set; }

        public object DivisionId { get; set; }

        public object DivisionName { get; set; }
    }
}
