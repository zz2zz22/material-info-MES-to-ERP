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
            sqlMesPlanningExcutionCon sqlMesPlanningExcution = new sqlMesPlanningExcutionCon();
            StringBuilder getMatDosage = new StringBuilder();
        }

        private void MainWindow_Activated(object sender, EventArgs e)
        {
            if (VariablesSave.WorkOrderUUID != null)
            {
                Load2Labels();
                
                
            }
        }
    }
}
