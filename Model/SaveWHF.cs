using MiniExcelLibs.Attributes;

namespace MaterialMES2ERP
{
    class SaveWHF
    {
        [ExcelColumn(Name = "UUID", Width = 16)]
        public string uuid { get; set; }

        [ExcelColumn(Name = "Mã nguyên liệu", Width = 18)]
        public string material_uuid { get; set; }

        [ExcelColumn(Name = "Số lượng", Width = 8)]
        public double book_quantity { get; set; }

        [ExcelColumn(Name = "Số lượng xuất-nhập", Width = 14)]
        public double in_out_quantity { get; set; }

        [ExcelColumn(Name = "Số lượng hiện tại", Width = 14)]
        public double this_quantity { get; set; }

        [ExcelColumn(Name = "Ngày tạo", Width = 20)]
        public string create_day { get; set; }

        [ExcelColumn(Name = "Ngày cập nhập", Width = 20)]
        public string update_date { get; set; }
    }
}
