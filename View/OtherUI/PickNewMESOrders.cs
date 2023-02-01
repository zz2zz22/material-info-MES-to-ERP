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
    public partial class PickNewMESOrders : Form
    {
        string WOUUID;
        string JOUUID;
        public PickNewMESOrders()
        {
            InitializeComponent();
        }

        private void checkNull(Label txb, String value)
        {
            if(String.IsNullOrWhiteSpace(value))
            {
                txb.Text = "0";
            }
            else
            {
                txb.Text = value;
            }
        }

        private void PickNewMESOrders_Load(object sender, EventArgs e)
        {
            LoadDTGV.MESOrdersDTGV_HeaderChange(dtgvSearchMESOrders, "");
        }

        private void txbSearchMESOrders_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                LoadDTGV.MESOrdersDTGV_HeaderChange(dtgvSearchMESOrders, txbSearchMESOrders.Text);
            }
        }

        private void dtgvSearchMESOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvSearchMESOrders.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgvSearchMESOrders.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgvSearchMESOrders.Rows[selectedrowindex];
                WOUUID = Convert.ToString(selectedRow.Cells["ID"].Value);
                JOUUID = Convert.ToString(selectedRow.Cells["jobOrdUUID"].Value);
                lbERPCodeInfo.Text = Convert.ToString(selectedRow.Cells["orderNo"].Value);
                lbSemiProdInfo.Text = Convert.ToString(selectedRow.Cells["prodNo"].Value);
                checkNull(lbFinishQtyInfo, Convert.ToString(Convert.ToString(selectedRow.Cells["finishQty"].Value)));
                checkNull(lbPlanQtyInfo, Convert.ToString(Convert.ToString(selectedRow.Cells["orderQty"].Value)));
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            VariablesSave.ResetTempMat();
            VariablesSave.WorkOrderUUID = WOUUID;
            VariablesSave.JobOrderUUID = JOUUID;
            VariablesSave.OrderNo = lbERPCodeInfo.Text;
            VariablesSave.ProdNo = lbSemiProdInfo.Text;
            VariablesSave.PlanQty = Convert.ToInt32(lbPlanQtyInfo.Text);
            VariablesSave.FinishQty = Convert.ToInt32(lbFinishQtyInfo.Text);
            this.Close();
        }

    }
}
