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
        public static void LoadData2DTGVScannedMat(DataGridView dataGridView, DataTable dt)
        {
            dataGridView.DataSource = dt;
            dataGridView.Columns["JOMatUUID"].Visible = false;
            dataGridView.Columns["MatUUID"].Visible = false;
            dataGridView.Columns["SubMatUUID"].Visible = false;
            dataGridView.Columns["MatCode"].HeaderText = "Mã liệu";
            dataGridView.Columns["SubMat"].HeaderText = "Liệu phụ";
            dataGridView.Columns["ExpDate"].HeaderText = "Hạn liệu";
            dataGridView.Columns["LOT"].HeaderText = "Số LOT";
            dataGridView.Columns["SumScale"].HeaderText = "Tổng KL Cân";

        }
    }
}
