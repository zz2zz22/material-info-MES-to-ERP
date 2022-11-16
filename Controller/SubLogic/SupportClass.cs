using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace MaterialMES2ERP
{
    public class SupportClass
    {
        public void OpenScaleSerialPort(SerialPort serialPort)
        {
            serialPort.PortName = VariablesSave.PortName;
            serialPort.BaudRate = Convert.ToInt32(VariablesSave.BaudRate);
            serialPort.DataBits = Convert.ToInt32(VariablesSave.DataBits);
            serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), VariablesSave.StopBits);
            serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), VariablesSave.Parity);
            serialPort.Open();
        }
        public static void LoadData2DTGVChooseWO(DataGridView dataGridView, DataTable dt)
        {
            dataGridView.DataSource = dt;
            dataGridView.Columns["ID"].Visible = false;
            dataGridView.Columns["jobOrdUUID"].Visible = false;
            dataGridView.Columns["orderNo"].HeaderText = "Mã ERP";
            dataGridView.Columns["jobNo"].HeaderText = "Mã đơn";
            dataGridView.Columns["prodNo"].HeaderText = "Mã sản phẩm";

            dataGridView.Columns["orderQty"].HeaderText = "Số lượng của đơn";
            dataGridView.Columns["finishQty"].HeaderText = "Số lượng đã làm";

            dataGridView.Columns["createDate"].HeaderText = "Ngày tạo đơn";
        }
    }
}
