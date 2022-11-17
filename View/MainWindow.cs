using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace MaterialMES2ERP
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            VariablesSave.ResetAll();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            LoadDTGV.OngoingOrdersDTGV_HeaderChange(dtgvOngoingWorkOrder, lbOngoingOrdersNodata, "");
        }

        private void btnRefreshOngoingOrdersList_Click(object sender, EventArgs e)
        {
            LoadDTGV.OngoingOrdersDTGV_HeaderChange(dtgvOngoingWorkOrder, lbOngoingOrdersNodata, "");
        }

        private void txbSearchOngoingOrders_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                dtgvOngoingWorkOrder.ClearSelection();
                LoadDTGV.OngoingOrdersDTGV_HeaderChange(dtgvOngoingWorkOrder, lbOngoingOrdersNodata, txbSearchOngoingOrders.Text.Trim());
            }
        }

        private void btnSelectOrderFromMES_Click(object sender, EventArgs e)
        {
            PickNewMESOrders pickNewMES = new PickNewMESOrders();
            pickNewMES.ShowDialog();
        }

        private void btnScaleConnect_Click(object sender, EventArgs e)
        {
            ScaleConnect scaleConnect = new ScaleConnect();
            scaleConnect.ShowDialog();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            VariablesSave.ResetAll();
        }
        private void Load2Labels()
        {
            lbOrderNoInfo.Text = VariablesSave.OrderNo;
            lbProdNoInfo.Text = VariablesSave.ProdNo;
            lbOrderQtyInfo.Text = VariablesSave.PlanQty.ToString();
            lbFinishQtyInfo.Text = VariablesSave.FinishQty.ToString();
        }

        private void LoadMESMatDosage(string woUUID, DataGridView dataGridView)
        {
            sqlMesPlanningExcutionCon sqlMesPlanningExcution = new sqlMesPlanningExcutionCon();
            sqlMesBaseDataCon sqlMesBaseData = new sqlMesBaseDataCon();
            StringBuilder getMatIDS = new StringBuilder();
            ComboBox cbxMatIDs_ = new ComboBox();
            getMatIDS.Append("SELECT CONCAT(material_uuid , ';', unit_dosage) AS result ");
            getMatIDS.Append("FROM work_order_material ");
            getMatIDS.Append("WHERE work_order_uuid = '" + woUUID + "'");
            sqlMesPlanningExcution.getComboBoxData(getMatIDS.ToString(), ref cbxMatIDs_);
            VariablesSave.GenerateMatTempDatatable();
            for (int i = 0; i < cbxMatIDs_.Items.Count; i++)
            {
                DataRow dr = VariablesSave.matTempDatatable.NewRow();
                string[] splitResult = cbxMatIDs_.Items[i].ToString().Split(';');
                string matNo = sqlMesBaseData.sqlExecuteScalarString("Select distinct material_no from material_info where material_uuid = '" + splitResult[0].ToString() + "'");
                string matName = sqlMesBaseData.sqlExecuteScalarString("Select distinct material_name from material_info where material_uuid = '" + splitResult[0].ToString() + "'");
                dr["matNo"] = matNo;
                dr["matName"] = matName;
                dr["totalDosage"] = VariablesSave.PlanQty * Convert.ToDouble(splitResult[1].ToString().TrimEnd('0'));
                dr["scaleDosage"] = "0";
                VariablesSave.matTempDatatable.Rows.Add(dr);
            }
            VariablesSave.matTempDatatable.AcceptChanges();
            dataGridView.DataSource = VariablesSave.matTempDatatable;
            if (VariablesSave.matTempDatatable.Rows.Count > 0)
            {
                dataGridView.Columns["matNo"].HeaderText = "Mã liệu";
                dataGridView.Columns["matName"].HeaderText = "Tên liệu";
                dataGridView.Columns["totalDosage"].HeaderText = "Khối lượng liệu dự kiến";
                dataGridView.Columns["scaleDosage"].HeaderText = "Khối lượng liệu đang lưu tạm/ đang làm";
            }
        }

        private void MainWindow_Activated(object sender, EventArgs e)
        {
            if (VariablesSave.WorkOrderUUID != null)
            {
                Load2Labels();
                LoadMESMatDosage(VariablesSave.WorkOrderUUID, dtgvWorkOrderMaterials);
                
            }
        }
    }
}
