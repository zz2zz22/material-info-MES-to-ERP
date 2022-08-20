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
        [ExcelColumn(Name = "UUID", Width = 16)]
        [ExcelColumnWidth(16)]
        public string uuid { get; set; }

        [ExcelColumn(Name = "Mã nguyên liệu", Width = 18)]
        public string material_uuid { get; set; }

        [ExcelColumn(Name = "Số lượng", Width = 13)]
        public double book_quantity { get; set; }

        [ExcelColumn(Name = "Ngày tạo", Width = 20)]
        public string create_day { get; set; }

        [ExcelColumn(Name = "Ngày cập nhập", Width = 20)]
        public string update_date { get; set; }
    }
}
