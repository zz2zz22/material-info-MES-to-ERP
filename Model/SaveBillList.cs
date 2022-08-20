using MiniExcelLibs.Attributes;

namespace MaterialMES2ERP
{
    class SaveBillList
    {
        [ExcelColumn(Name = "UUID", Width = 16)]
        public string uuid { get; set; }

        [ExcelColumn(Name = "Mã nguyên liệu", Width = 18)]
        public string material_uuid { get; set; }

        [ExcelColumn(Name = "Số lượng", Width = 8)]
        public double wms_in_quantity { get; set; }

        [ExcelColumn(Name = "Đơn vị", Width = 6)]
        public string unit_code { get; set; }

        [ExcelColumn(Name = "Ngày tạo", Width = 20)]
        public string create_day { get; set; }

        [ExcelColumn(Name = "Ngày cập nhập", Width = 20)]
        public string update_date { get; set; }
    }
}
