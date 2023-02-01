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
using Quartz;
using Quartz.Impl;
using System.Text.RegularExpressions;

namespace MaterialMES2ERP
{
    public partial class MainWindow : Form
    {
        string dataIn;

        public MainWindow()
        {
            InitializeComponent();
            VariablesSave.isAddSubMat = false;
            VariablesSave.scaleTimes = 0;
            VariablesSave.totalScaleWeight = 0;
            VariablesSave.subRowIndex = -1;

            VariablesSave.addTempMatColumn();
            SupportClass.LoadData2DTGVScannedMat(dtgv_allScannedMat, VariablesSave.tempMat);

            //Adding 2 button column to add Subtitute Material & delete row action
            var editButtonColumn = new DataGridViewButtonColumn(); // Adding subtitute material
            editButtonColumn.Text = "Liệu phụ";
            editButtonColumn.UseColumnTextForButtonValue = true;
            dtgv_allScannedMat.Columns.Add(editButtonColumn);
            var deleteButtonColumn = new DataGridViewButtonColumn(); // Delete row 
            deleteButtonColumn.Text = "Nhập LOT";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dtgv_allScannedMat.Columns.Add(deleteButtonColumn);
            var returnButtonColumn = new DataGridViewButtonColumn(); // Delete row 

            
        }

        public bool checkExistMatOrder(string jobOrdUUID) // Check if Job order have Import material order
        {
            VariablesSave.ResetJobOrdMat();
            ComboBox cbx_checkExMat = new ComboBox();
            sqlMesPlanningExcutionCon sqlMesPlanning = new sqlMesPlanningExcutionCon();
            StringBuilder getAllMatOrdUUID = new StringBuilder();
            getAllMatOrdUUID.Append(@" SELECT DISTINCT UUID FROM job_order_material
 WHERE job_order_uuid = '" + jobOrdUUID + "' AND delete_flag = '0'");
            sqlMesPlanning.getComboBoxData(getAllMatOrdUUID.ToString(), ref cbx_checkExMat);
            if (cbx_checkExMat.Items.Count > 0)
            {
                //If job order exist material orders --> Save all uuid of job_order_material to later update task --> return true
                string tempMatOrdUUIDs = "";
                for (int i = 0; i < cbx_checkExMat.Items.Count; i++)
                {
                    if (i == 0)
                    {
                        tempMatOrdUUIDs = cbx_checkExMat.Items[i].ToString();
                    }
                    else
                    {
                        tempMatOrdUUIDs = tempMatOrdUUIDs + ";" + cbx_checkExMat.Items[i].ToString();
                    }
                }
                VariablesSave.MatOrder = tempMatOrdUUIDs.Split(';');
                return true;

            }
            else
            {
                //If nothing exist --> Not save --> return false
                return false;
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ScaleConnect scaleConnect = new ScaleConnect();
            scaleConnect.ShowDialog();
            LoadDTGV.OngoingOrdersDTGV_HeaderChange(dtgvOngoingWorkOrder, lbOngoingOrdersNodata, "");

            if (String.IsNullOrEmpty(Properties.Settings.Default.excelFileName))
            {
                Properties.Settings.Default.excelFileName = "Report_" + DateTime.Now.ToString("yyyyMMdd-hhmmss") + ".xlsx";
                Properties.Settings.Default.Save();
            }

            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler().Result;
            scheduler.Start();
            IJobDetail job = JobBuilder.Create<EmailJob>().Build();
            ITrigger trigger = TriggerBuilder.Create()
             .WithIdentity("IDGJob", "IDG")
               .WithSchedule(CronScheduleBuilder.DailyAtHourAndMinute(13, 42))
               .Build();
            scheduler.ScheduleJob(job, trigger);
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
            pickNewMES.FormClosed += pickMESFormClosed;
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

        private void pickMESFormClosed(object sender, EventArgs e)
        {
            ((Form)sender).FormClosed -= pickMESFormClosed;
            if (VariablesSave.WorkOrderUUID != null)
            {
                LoadDTGV.Load2LabelsOrderInfo(lbOrderNoInfo, lbProdNoInfo, lbOrderQtyInfo);
                LoadDTGV.LoadMESMatDosage(VariablesSave.WorkOrderUUID, VariablesSave.JobOrderUUID, dtgvWorkOrderMaterials);
            }
        }

        private void dtgvOngoingWorkOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvOngoingWorkOrder.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgvOngoingWorkOrder.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgvOngoingWorkOrder.Rows[selectedrowindex];
                VariablesSave.WorkOrderUUID = Convert.ToString(selectedRow.Cells["work_order_uuid"].Value);
                VariablesSave.JobOrderUUID = Convert.ToString(selectedRow.Cells["job_order_uuid"].Value);
                VariablesSave.OrderNo = Convert.ToString(selectedRow.Cells["erp_order_no"].Value);
                VariablesSave.ProdNo = Convert.ToString(selectedRow.Cells["product_no"].Value);
                VariablesSave.PlanQty = Convert.ToInt32(selectedRow.Cells["order_qty"].Value);
                LoadDTGV.Load2LabelsOrderInfo(lbOrderNoInfo, lbProdNoInfo, lbOrderQtyInfo);
                LoadDTGV.LoadMESMatDosage(VariablesSave.WorkOrderUUID, VariablesSave.JobOrderUUID, dtgvWorkOrderMaterials);
            }
        }

        private void cbxChooseReplenishmentType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (cbxChooseReplenishmentType.SelectedIndex)
            {
                case 0:
                    VariablesSave.replenishmentType = "领料";
                    break;
                case 1:
                    VariablesSave.replenishmentType = "补料";
                    break;
                case 2:
                    VariablesSave.replenishmentType = "退料";
                    break;
                default:
                    VariablesSave.replenishmentType = null;
                    break;
            }
        }

        private void btnSaveMES_Click(object sender, EventArgs e)
        {
            bool isReadyToSave = true;
            if (String.IsNullOrEmpty(VariablesSave.replenishmentType))
            {
                MessageBox.Show("Hãy chọn loại bổ sung vật liệu trước khi lưu!");
                isReadyToSave = false;
            }
            if (String.IsNullOrEmpty(VariablesSave.EmpCode))
            {
                MessageBox.Show("Xin hãy quét code nhân viên!");
                isReadyToSave = false;
            }
            if (isReadyToSave)
            {
                UploadMain.Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                //Save logic in UploadMain.cs
                UploadMain.transactionSupportUploadData(VariablesSave.tempMat, VariablesSave.matTempDatatable);
                LoadDTGV.OngoingOrdersDTGV_HeaderChange(dtgvOngoingWorkOrder, lbOngoingOrdersNodata, "");
                VariablesSave.addTempMatColumn();
                SupportClass.LoadData2DTGVScannedMat(dtgv_allScannedMat, VariablesSave.tempMat);
                VariablesSave.scaleTimes = 0;
                VariablesSave.totalScaleWeight = 0;
                VariablesSave.tempMatCode = null;
            }
        }

        private void add2tempMat(object sender, EventArgs e)
        {
            //Check & adding scaled data to tempMat datatable
            if (VariablesSave.tempMat.Rows.Count > 0)
            {
                for (int i = 0; i < VariablesSave.tempMat.Rows.Count; i++)
                {
                    if ((VariablesSave.tempMat.Rows[i]["MatCode"].ToString() == VariablesSave.matCode || VariablesSave.tempMat.Rows[i]["SubMat"].ToString() == VariablesSave.matCode))
                    {
                        VariablesSave.tempMat.Rows[i]["SumScale"] = VariablesSave.totalScaleWeight;
                        VariablesSave.tempMat.Rows[i]["ExpDate"] = VariablesSave.matExpDate;
                        VariablesSave.tempMat.Rows[i]["LOT"] = VariablesSave.matLotNo;
                        //checkExistMat = true;
                    }
                }
            }
            else
            {
                VariablesSave.tempMat.Rows.Add(VariablesSave.matCode, "", "", "", VariablesSave.matExpDate, VariablesSave.matLotNo, VariablesSave.totalScaleWeight, "");
            }
            VariablesSave.tempMatCode = VariablesSave.matCode;
        }

        #region Electronic Scale Logic
        private void showData(object sender, EventArgs e)
        {
            lb_scaleQty.Text = dataIn;   
            VariablesSave.returnValue = dataIn;
           
        }
        
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            StringBuilder getData = new StringBuilder();
            getData.Append(serialPort1.ReadExisting());
            dataIn = getData.ToString().Replace(Environment.NewLine, "").Replace("\r", "").Replace("\n", "").Replace("kg", "").Trim();
            //Problem about scale latency --> Config scale mode --> HOLD mode 0 --> Kinda ok when test multiple time ( must wait for COM port to finalizing conneection )
            this.Invoke(new EventHandler(showData));
        }

        private void dtgv_allScannedMat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0) // Lưu cột button = index 0 do thêm = hard code :v 
                {
                    VariablesSave.subRowIndex = e.RowIndex;
                    VariablesSave.isAddSubMat = true;

                    GetQRWaiting getQRWaiting = new GetQRWaiting();
                    VariablesSave.type = 2;
                    getQRWaiting.Show();
                }
                if (e.ColumnIndex == 1) // Lưu cột button = index 1 do thêm = hard code :v 
                {
                    DialogResult dialogResult = MessageBox.Show("Nhập số LOT ?", "Cảnh báo", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {
                        VariablesSave.tempMat.Rows[e.RowIndex]["LOT"] = txbLOTInput.Text.ToUpper().Trim();
                        VariablesSave.tempMat.AcceptChanges();
                        SupportClass.LoadData2DTGVScannedMat(dtgv_allScannedMat, VariablesSave.tempMat);
                        txbLOTInput.Text = "";
                    }

                }
                if (e.ColumnIndex == 3) // 2 3 4 5 ... 0 1 --> thứ tự cột khi thêm = hard code
                {
                    DialogResult dialogResult = MessageBox.Show("Xóa thông tin liệu phụ ?", "Warning", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {
                        VariablesSave.tempMat.Rows[e.RowIndex]["SubMat"] = "";
                        SupportClass.LoadData2DTGVScannedMat(dtgv_allScannedMat, VariablesSave.tempMat);
                    }
                }
            }
        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            VariablesSave.ResetEmployee();
            GetQRWaiting getQRWaiting = new GetQRWaiting();
            VariablesSave.type = 1;
            getQRWaiting.FormClosed += qrClose;
            getQRWaiting.Show();
        }
        private void qrClose(object sender, EventArgs e)
        {
            ((Form)sender).FormClosed -= qrClose;
            lbEmpName.Text = VariablesSave.EmpName;
            lbEmpCode.Text = VariablesSave.EmpCode;
        }

        private void btn_ReturnMat_Click(object sender, EventArgs e)
        {


        }
        private void ResetDataAfterSave()
        {
            lb_scaleQty.Text = "0.00";
            lb_sumScaleQty.Text = "0.00";
            VariablesSave.ResetAll();

            lbOrderNoInfo.Text = "";
            lbProdNoInfo.Text = "";
            lbOrderQtyInfo.Text = "";
            dtgvWorkOrderMaterials.DataSource = null;
        }


        private void btnSetting_Click(object sender, EventArgs e)
        {
            GetQRWaiting getQRWaiting = new GetQRWaiting();
            VariablesSave.type = 1;
            getQRWaiting.Show();
        }

        private void btnOKWeight_Click(object sender, EventArgs e)
        {

            VariablesSave.totalScaleWeight = VariablesSave.totalScaleWeight + Convert.ToDouble(VariablesSave.returnValue);
            lb_sumScaleQty.Text = VariablesSave.totalScaleWeight.ToString();
            // --> Not allow user to scale another time without scan material QR code
            pnl_scaleWait.BackColor = Color.Black;
            this.Invoke(new EventHandler(add2tempMat));
            SupportClass.LoadData2DTGVScannedMat(dtgv_allScannedMat, VariablesSave.tempMat);
            btnScan.Enabled = true;
        }

        private void btnDecreaseWeight_Click(object sender, EventArgs e)
        {
            VariablesSave.totalScaleWeight = VariablesSave.totalScaleWeight - Convert.ToDouble(VariablesSave.returnValue);
            lb_sumScaleQty.Text = VariablesSave.totalScaleWeight.ToString();
            VariablesSave.scaleTimes = 0; // --> Not allow user to scale another time without scan material QR code
            pnl_scaleWait.BackColor = Color.Black;
            this.Invoke(new EventHandler(add2tempMat));
            SupportClass.LoadData2DTGVScannedMat(dtgv_allScannedMat, VariablesSave.tempMat);
            btnScan.Enabled = true;
        }

        private void txbLOTInput_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            lb_scaleQty.Text = "0.00";
            GetQRWaiting getQRWaiting = new GetQRWaiting();
            VariablesSave.isAddSubMat = false;
            VariablesSave.type = 2;
            getQRWaiting.Show();
            btnScan.Enabled = false;
            pnl_scaleWait.BackColor = Color.ForestGreen;
            if (!serialPort1.IsOpen)
            {
                try
                {
                    if (VariablesSave.PortName != null)
                    {
                        serialPort1.PortName = VariablesSave.PortName;
                        serialPort1.BaudRate = Convert.ToInt32(VariablesSave.BaudRate);
                        serialPort1.DataBits = Convert.ToInt32(VariablesSave.DataBits);
                        serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), VariablesSave.StopBits);
                        serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), VariablesSave.Parity);
                        serialPort1.Open();

                    }

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
    }
}
