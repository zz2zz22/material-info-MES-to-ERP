using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialMES2ERP
{
    public partial class ScaleConnect : Form
    {
        string dataIn;
        bool checkIsConnected = false;
        public ScaleConnect()
        {
            InitializeComponent();
        }

        private void ScaleConnect_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cbComPort.Items.AddRange(ports);

            serialPort1.DtrEnable = false;
            serialPort1.RtsEnable = false;
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cbComPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(cbBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cbDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cbParityBits.Text);
                serialPort1.Open();
                txtDataIn.Clear();
                if (serialPort1.IsOpen)
                {
                    txtDataIn.Text = "Kết nối với cân thành công!";
                    checkIsConnected = true;
                }
                else
                {
                    txtDataIn.Text = "Kết nối với cân thất bại. Vui lòng kiểm tra lại thông tin!";
                    checkIsConnected = false;
                }
            }
            catch (Exception ex)
            {
                txtDataIn.Clear();
                txtDataIn.Text = "Kết nối với cân thất bại : " + ex.Message;
                checkIsConnected = false;
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIn = serialPort1.ReadLine();
            this.Invoke(new EventHandler(showData));
        }

        private void showData(object sender, EventArgs e)
        {            
            txtDataIn.Text += dataIn.ToString().Trim().TrimEnd('\r', '\n').Replace("kg", "") + Environment.NewLine; //xuống hàng khi nhấn Enter
        }

        private void txtDataIn_TextChanged(object sender, EventArgs e)
        {
            txtDataIn.SelectionStart = txtDataIn.Text.Length;
            txtDataIn.ScrollToCaret();
        }

        private void btnSaveScaleInformation_Click(object sender, EventArgs e)
        {
            if(checkIsConnected == true)
            {
                VariablesSave.PortName = cbComPort.Text;
                VariablesSave.BaudRate = cbBaudRate.Text;
                VariablesSave.DataBits = cbDataBits.Text;
                VariablesSave.StopBits = cbStopBits.Text;
                VariablesSave.Parity = cbParityBits.Text;
            }
            else
            {
                MessageBox.Show("Chưa test kết nối hoặc lỗi kết nối với cân");
            }
        }
    }
}
