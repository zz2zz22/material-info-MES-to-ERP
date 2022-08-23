using MiniExcelLibs.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialMES2ERP
{
    class SaveWHB
    {
        public string uuid { get; set; }
        public string material_uuid { get; set; }
        public double book_quantity { get; set; }
        public string create_day { get; set; }
        public string update_date { get; set; }
    }
}
