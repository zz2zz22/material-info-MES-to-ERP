using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialMES2ERP
{
    public partial class GetQRWaiting : Form
    {
        public GetQRWaiting()
        {
            InitializeComponent();
        }

        private void GetQRWaiting_Load(object sender, EventArgs e)
        {
            txbQRInput.Focus();
        }

        private void SaveEmp(string UUID)
        {
            sqlMesBaseDataCon sqlMesBaseData = new sqlMesBaseDataCon();
            string result = UUID.ToString().Substring(1, UUID.IndexOf(';') - 1);
            VariablesSave.EmpUUID = result;
            VariablesSave.EmpName = sqlMesBaseData.sqlExecuteScalarString("select name from employee_info where uuid = '" + result.Trim() + "'");
            VariablesSave.EmpCode = sqlMesBaseData.sqlExecuteScalarString("select code from employee_info where uuid = '" + result.Trim() + "'");
        }

        
        private void txbQRInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)13)
                {
                    string QRtext = txbQRInput.Text.Trim();
                    txbQRInput.Text = null;
                    string[] matCode = QRtext.Split(';'); ;
                    if (!String.IsNullOrEmpty(QRtext))
                    {
                        switch (VariablesSave.type)
                        {
                            //case 1:
                            //    {
                            //        if (QRtext.Substring(0, 1) == "s")
                            //        {
                            //            //VariablesSave.qrScanResult = matCode[1];
                            //            PickNewMESOrders pickNewMESOrders = new PickNewMESOrders();
                            //            this.Close();
                            //            pickNewMESOrders.ShowDialog();
                            //        }
                            //        else
                            //        {
                            //            this.Close();
                            //            MessageBox.Show("Không nhận diện được mã nguyên liệu vui lòng thử lại!");
                            //        }
                            //        break;
                            //    }
                            case 1:
                                {
                                    if (VariablesSave.EmpUUID != null)
                                    {
                                        DialogResult dialogResultCheckExistEmp = MessageBox.Show("Bạn có muốn thay đổi nhân viên ? Hiện tại đang là " + VariablesSave.EmpName, "Cảnh báo", MessageBoxButtons.OKCancel);
                                        if (dialogResultCheckExistEmp == DialogResult.OK)
                                        {
                                            SaveEmp(QRtext);
                                            this.Close();
                                        }
                                    }
                                    else
                                    {
                                        SaveEmp(QRtext);
                                        this.Close();
                                    }
                                    break;
                                }
                            default:
                                this.Close();
                                break;
                        }
                        VariablesSave.ResetWindowType();
                    }
                    else
                    {
                        MessageBox.Show("Không thể đọc được mã QR xin hãy kiểm tra USB port và quét lại!");
                        txbQRInput.Focus();
                    }
                }
            }
            catch(Exception)
            {
                txbQRInput.Text = null;
                txbQRInput.Focus();
            }
        }

        private void GetQRWaiting_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
