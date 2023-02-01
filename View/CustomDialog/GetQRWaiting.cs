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
                            case 1: //Lưu mã nhân viên
                                {
                                    SaveEmp(QRtext);
                                    this.Close();
                                    break;
                                }
                            case 2:
                                {
                                    txbQRInput.Focus();
                                    if (QRtext.Substring(0, 1) == "s" && !String.IsNullOrEmpty(VariablesSave.WorkOrderUUID))
                                    {
                                        sqlMesPlanningExcutionCon sqlMesPlanningExcution = new sqlMesPlanningExcutionCon();
                                        ComboBox cbx_matCodeList = new ComboBox();
                                        StringBuilder getMatCode = new StringBuilder();
                                        getMatCode.Append(@"SELECT DISTINCT material_no FROM mes_planning_excution.work_order_material
where work_order_uuid = '" + VariablesSave.WorkOrderUUID + "' AND delete_flag = '0'");
                                        sqlMesPlanningExcution.getComboBoxData(getMatCode.ToString(), ref cbx_matCodeList);
                                        if (VariablesSave.isAddSubMat == true)
                                        {
                                            if (VariablesSave.subRowIndex != -1 && VariablesSave.tempMat.Rows[VariablesSave.subRowIndex]["MatCode"].ToString() != matCode[1].Trim())
                                            {
                                                VariablesSave.tempMat.Rows[VariablesSave.subRowIndex]["SubMat"] = matCode[1].Trim();
                                            }
                                            VariablesSave.isAddSubMat = false;
                                            this.Close();
                                        }
                                        else
                                        {
                                            bool checkSubMat = false;
                                            if (VariablesSave.tempMat.Rows.Count > 0)
                                            {
                                                for (int k = 0; k < VariablesSave.tempMat.Rows.Count; k++)
                                                {
                                                    if (VariablesSave.tempMat.Rows[k]["SubMat"].ToString() == matCode[1].Trim())
                                                        checkSubMat = true;
                                                }
                                            }
                                            if (cbx_matCodeList.Items.Contains(matCode[1].Trim()) || checkSubMat == true)
                                            {
                                                if (VariablesSave.scaleTimes == 0)
                                                {
                                                    int flag = 0;
                                                    //Show scanned material info and save to temporary variable
                                                    VariablesSave.matCode = matCode[1].Trim();
                                                    VariablesSave.matExpDate = matCode[3].Trim();
                                                    VariablesSave.matLotNo = matCode[4].Trim();

                                                    if (VariablesSave.tempMat.Rows.Count > 0)
                                                    {
                                                        for (int j = 0; j < VariablesSave.tempMat.Rows.Count; j++)
                                                        {
                                                            if (VariablesSave.tempMat.Rows[j]["MatCode"].ToString() == matCode[1])
                                                            {
                                                                flag = j;
                                                                if (String.IsNullOrEmpty(VariablesSave.tempMat.Rows[j]["SumScale"].ToString()))
                                                                {
                                                                    VariablesSave.totalScaleWeight = 0;
                                                                }
                                                                else
                                                                {
                                                                    VariablesSave.totalScaleWeight = double.Parse(VariablesSave.tempMat.Rows[j]["SumScale"].ToString());
                                                                }

                                                            }
                                                        }
                                                    }
                                                    
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Mã đã quét vui lòng cân liệu!");
                                                }
                                                this.Close();
                                            }
                                            else
                                            {
                                                DialogResult dialogResult = MessageBox.Show("Mã liệu vừa quét KHÔNG thuộc đơn đã chọn, vẫn tiếp tục ?", "Cảnh báo", MessageBoxButtons.OKCancel);
                                                if (dialogResult == DialogResult.OK)
                                                {
                                                    if (VariablesSave.scaleTimes == 0)
                                                    {
                                                        int flag = 0;
                                                        //Show scanned material info and save to temporary variable
                                                        VariablesSave.matCode = matCode[1].Trim();
                                                        VariablesSave.matExpDate = matCode[3].Trim();
                                                        VariablesSave.matLotNo = matCode[4].Trim();

                                                        if (VariablesSave.tempMat.Rows.Count > 0)
                                                        {
                                                            for (int j = 0; j < VariablesSave.tempMat.Rows.Count; j++)
                                                            {
                                                                if (VariablesSave.tempMat.Rows[j]["MatCode"].ToString() == matCode[1])
                                                                {
                                                                    flag = j;
                                                                    if (String.IsNullOrEmpty(VariablesSave.tempMat.Rows[j]["SumScale"].ToString()))
                                                                    {
                                                                        VariablesSave.totalScaleWeight = 0;
                                                                    }
                                                                    else
                                                                    {
                                                                        VariablesSave.totalScaleWeight = double.Parse(VariablesSave.tempMat.Rows[j]["SumScale"].ToString());
                                                                    }
                                                                }
                                                            }
                                                        }
                                                        
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Mã đã quét vui lòng cân liệu!");
                                                    }
                                                    this.Close();
                                                }
                                            }
                                        }
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
            catch (Exception)
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
