using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Windows.Forms;
using System.Threading;

namespace MaterialMES2ERP
{
    public class LoadDTGV
    {
        //Thread backgroundThreadLoadOngoingOrders = new Thread(
        //        new ThreadStart(() =>
        //        {
        //        }));


        //
        //Ongoing Orders Datagridview
        //
        public static void OngoingOrdersDTGV_HeaderChange(DataGridView dataGrid, Label lbData, string keyWord)
        {
            sqlMesPlanningExcutionCon sqlMesPlanning = new sqlMesPlanningExcutionCon();
            dataGrid.DataSource = null;
            DataTable dts = new DataTable();
            dts.Columns.Add("work_order_uuid", typeof(String));
            dts.Columns.Add("job_order_uuid", typeof(String));
            dts.Columns.Add("job_no", typeof(String));
            
            dts.Columns.Add("erp_order_no", typeof(String));
            dts.Columns.Add("product_no", typeof(String));
            dts.Columns.Add("order_qty", typeof(String));
            dts.Columns.Add("newest_update_date", typeof(String));
            DataTable dt =  OngoingOrders(keyWord);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dts.NewRow();
                dr["work_order_uuid"] = dt.Rows[i]["work_order_uuid"].ToString();
                dr["job_order_uuid"] = dt.Rows[i]["job_order_uuid"].ToString();
                dr["job_no"] = sqlMesPlanning.sqlExecuteScalarString("select job_no from job_order where uuid = '" + dt.Rows[i]["job_order_uuid"].ToString() + "' and work_order_uuid = '" + dt.Rows[i]["work_order_uuid"].ToString() + "'");
                dr["erp_order_no"] = sqlMesPlanning.sqlExecuteScalarString("select erp_order_no from work_order where order_uuid = '" + dt.Rows[i]["work_order_uuid"].ToString() + "'");
                dr["product_no"] = sqlMesPlanning.sqlExecuteScalarString("select product_no from job_order where uuid = '" + dt.Rows[i]["job_order_uuid"].ToString() + "' and work_order_uuid = '" + dt.Rows[i]["work_order_uuid"].ToString() + "'");
                dr["order_qty"] = sqlMesPlanning.sqlExecuteScalarString("select job_quantity from job_order where uuid = '" + dt.Rows[i]["job_order_uuid"].ToString() + "' and work_order_uuid = '" + dt.Rows[i]["work_order_uuid"].ToString() + "'");
                dr["newest_update_date"] = sqlMesPlanning.sqlExecuteScalarString("select create_date from job_order where uuid = '" + dt.Rows[i]["job_order_uuid"].ToString() + "' and work_order_uuid = '" + dt.Rows[i]["work_order_uuid"].ToString() + "'");
                dts.Rows.Add(dr);
            }
            if (dt.Rows.Count > 0)
            {
                lbData.Visible = false;
                dataGrid.DataSource = dts;
                dataGrid.Columns["work_order_uuid"].Visible = false;
                dataGrid.Columns["job_order_uuid"].Visible = false;
                dataGrid.Columns["job_no"].HeaderText = "Đơn làm việc";
                dataGrid.Columns["erp_order_no"].HeaderText = "Mã sản xuất";
                dataGrid.Columns["product_no"].HeaderText = "Mã sản phẩm";
                dataGrid.Columns["order_qty"].HeaderText = "Số lượng của đơn";
                dataGrid.Columns["newest_update_date"].HeaderText = "T.Gian cập nhật";
            }
            else
            {
                lbData.Visible = true;
            }
        }
        public static DataTable OngoingOrders(string keyWord) //Load on soft database
        {
            DataTable dt = new DataTable();
            try
            {
                sqlSOFTCon sqlSOFT = new sqlSOFTCon();
                StringBuilder getData = new StringBuilder();
                getData.Append("select * from Scale_OngoingOrder");
                sqlSOFT.sqlDataAdapterFillDatatable(getData.ToString(), ref dt);
                if (!String.IsNullOrEmpty(keyWord))
                {
                    string selectExpression = "job_no LIKE '%" + keyWord.Trim() + "%' OR erp_order_no like '%" + keyWord.Trim() + "%' OR product_no like '%" + keyWord.Trim() + "%'";
                    DataRow[] rows = dt.Select(selectExpression);
                    if (rows.Count() > 0)
                    {
                        DataTable dts = new DataTable();
                        dts = rows.CopyToDataTable();
                        return dts;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }


        //
        //MES Orders Datagridview
        //
        public static void MESOrdersDTGV_HeaderChange(DataGridView dataGrid, string keyWord)
        {
            DataTable dt = new DataTable();
            LoadingDialog loadingDialog = new LoadingDialog();

            Thread backgroundThreadLoadOngoingOrders = new Thread(
                    new ThreadStart(() =>
                    {
                        dt = MESOrders(keyWord);
                        loadingDialog.BeginInvoke(new Action(() => loadingDialog.Close()));
                    }));
            backgroundThreadLoadOngoingOrders.Start();
            loadingDialog.ShowDialog();

            if (dt.Rows.Count > 0)
            {
                dataGrid.DataSource = dt;
                dataGrid.Columns["ID"].Visible = false;
                dataGrid.Columns["jobOrdUUID"].Visible = false;
                dataGrid.Columns["orderNo"].HeaderText = "Mã ERP";
                dataGrid.Columns["jobNo"].HeaderText = "Mã đơn";
                dataGrid.Columns["prodNo"].HeaderText = "Mã sản phẩm";

                dataGrid.Columns["orderQty"].HeaderText = "Số lượng của đơn";
                dataGrid.Columns["finishQty"].HeaderText = "Số lượng đã làm";

                dataGrid.Columns["createDate"].HeaderText = "Ngày tạo đơn";
            }

        }

        public static DataTable MESOrders(string keyword)
        {
            DataTable dt = new DataTable();
            try
            {
                sqlMesPlanningExcutionCon sqlMesPlanningExcution = new sqlMesPlanningExcutionCon();
                ComboBox cbxWOUUID_ = new ComboBox();
                StringBuilder sqlGetWOfromMatCode = new StringBuilder();
                sqlGetWOfromMatCode.Append(@"SELECT DISTINCT work_order_uuid 
 FROM work_order_process 
 WHERE (dispatch_quantity - COALESCE(finish_quantity, 0)) > 0 
 AND delete_flag = '0'");
                sqlMesPlanningExcution.getComboBoxData(sqlGetWOfromMatCode.ToString(), ref cbxWOUUID_);

                if (cbxWOUUID_.Items.Count > 0)
                {
                    for (int i = 0; i < cbxWOUUID_.Items.Count; i++)
                    {
                        StringBuilder sqlGetDTGVData = new StringBuilder();
                        sqlGetDTGVData.Append(@"SELECT c.uuid AS jobOrdUUID, a.order_uuid AS ID,a.order_no AS orderNo, c.job_no AS jobNo, a.product_no AS prodNo, c.job_quantity AS orderQty, c.actual_finish_qty AS finishQty, c.create_date AS createDate 
 FROM job_order AS c
 JOIN work_order AS a ON a.order_uuid = c.work_order_uuid
 WHERE a.delete_flag = '0'  AND c.delete_flag = '0'
 AND a.order_uuid LIKE '" + cbxWOUUID_.Items[i].ToString() + "' AND c.operation_uuid = '3Y78FWT1GSW1' AND c.job_status < 4 order by c.create_date desc");
                        sqlMesPlanningExcution.sqlDataAdapterFillDatatable(sqlGetDTGVData.ToString(), ref dt);
                    }
                }
                else
                {
                    MessageBox.Show("Không có đơn nào có mã liệu này được sinh quản phát đơn!");
                }

                if (!String.IsNullOrWhiteSpace(keyword))
                {
                    DataTable selectDT = new DataTable();
                    string expression = "orderNo like '%" + keyword + "%' or jobNo like '%" + keyword + "%' or prodNo like '%" + keyword + "%'";
                    string sortOrder = "createDate DESC";
                    DataRow[] dataRows;
                    dataRows = dt.Select(expression, sortOrder);
                    selectDT = dataRows.CopyToDataTable();
                    return selectDT;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }


        ///
        ///Load MES material dosage
        ///
        public static void Load2LabelsOrderInfo(Label lb1, Label lb2, Label lb3)
        {
            lb1.Text = VariablesSave.OrderNo;
            lb2.Text = VariablesSave.ProdNo;
            lb3.Text = VariablesSave.PlanQty.ToString();
        }
        public static void LoadMESMatDosage(string woUUID, string jobUUID, DataGridView dataGridView)
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
            VariablesSave.ResetTempMat();
            for (int i = 0; i < cbxMatIDs_.Items.Count; i++)
            {
                DataRow dr = VariablesSave.matTempDatatable.NewRow();
                DataRow dr2 = VariablesSave.tempMat.NewRow();
                string[] splitResult = cbxMatIDs_.Items[i].ToString().Split(';');
                string matNo = sqlMesBaseData.sqlExecuteScalarString("Select distinct material_no from material_info where material_uuid = '" + splitResult[0].ToString() + "'");
                string matWeight = sqlMesPlanningExcution.sqlExecuteScalarString("select actual_material_qty from job_order_material where job_order_uuid = '" + jobUUID + "' and actual_material_no = '" + matNo + "'");
                string subMatCode = sqlMesPlanningExcution.sqlExecuteScalarString("select substitute_material_code from job_order_material where job_order_uuid = '" + jobUUID + "' and actual_material_no = '" + matNo + "'");
                string subMatUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select substitute_material_uuid from job_order_material where job_order_uuid = '" + jobUUID + "' and actual_material_no = '" + matNo + "'");
                if (String.IsNullOrEmpty(matWeight))
                {
                    matWeight = "0";
                }
                dr["matUUID"] = splitResult[0].ToString();
                dr2["MatUUID"] = splitResult[0].ToString();
                dr["matNo"] = matNo;
                dr2["MatCode"] = matNo;
                dr["actualMatUUID"] = subMatUUID;
                dr2["SubMatUUID"] = subMatUUID;
                dr["actualMatNo"] = subMatCode;
                dr2["SubMat"] = subMatCode; ;
                dr["totalDosage"] = VariablesSave.PlanQty * Convert.ToDouble(splitResult[1].ToString().TrimEnd('0'));
                dr["scaleDosage"] = matWeight;
                dr2["SumScale"] = Convert.ToDouble(matWeight);
                dr2["ExpDate"] = sqlMesPlanningExcution.sqlExecuteScalarString("select material_exp_date from job_order_material where job_order_uuid = '" + jobUUID + "' and actual_material_no = '" + matNo + "'");
                dr2["LOT"] = sqlMesPlanningExcution.sqlExecuteScalarString("select actual_finish_lot_no from job_order_material where job_order_uuid = '" + jobUUID + "' and actual_material_no = '" + matNo + "'"); ;
                VariablesSave.matTempDatatable.Rows.Add(dr);
                VariablesSave.tempMat.Rows.Add(dr2);
            }
            VariablesSave.matTempDatatable.AcceptChanges();
            dataGridView.DataSource = VariablesSave.matTempDatatable;
            if (VariablesSave.matTempDatatable.Rows.Count > 0)
            {
                dataGridView.Columns["matUUID"].Visible = false;
                dataGridView.Columns["matNo"].HeaderText = "Mã liệu";
                dataGridView.Columns["actualMatUUID"].Visible = false;
                dataGridView.Columns["actualMatNo"].HeaderText = "Mã liệu thực tế";

                dataGridView.Columns["totalDosage"].HeaderText = "Khối lượng liệu dự kiến";
                dataGridView.Columns["scaleDosage"].HeaderText = "Khối lượng liệu đang đã làm";
            }
        }

        public static void LoadTempMatDosage(string woUUID, string joUUID, DataGridView dataGridView)
        {
            VariablesSave.ResetTempMat();
            sqlMesPlanningExcutionCon sqlMesPlanningExcution = new sqlMesPlanningExcutionCon();
            sqlMesBaseDataCon sqlMesBaseData = new sqlMesBaseDataCon();
            sqlSOFTCon sqlSOFT = new sqlSOFTCon();
            StringBuilder getMatIDS = new StringBuilder();
            ComboBox cbxMatIDs_ = new ComboBox();
            getMatIDS.Append("SELECT CONCAT(material_uuid , ';', unit_dosage) AS result ");
            getMatIDS.Append("FROM work_order_material ");
            getMatIDS.Append("WHERE work_order_uuid = '" + woUUID + "'");
            sqlMesPlanningExcution.getComboBoxData(getMatIDS.ToString(), ref cbxMatIDs_);
            VariablesSave.GenerateMatTempDatatable();
            string matCustomUUID = sqlSOFT.sqlExecuteScalarString("select distinct material_no_uuid from Scale_OngoingOrder where work_order_uuid = '" + woUUID + "' and job_order_uuid = '" + joUUID + "'");
            for (int i = 0; i < cbxMatIDs_.Items.Count; i++)
            { 
                DataRow dr = VariablesSave.matTempDatatable.NewRow();
                DataRow dr2 = VariablesSave.tempMat.NewRow();
                string[] splitResult = cbxMatIDs_.Items[i].ToString().Split(';');
                string matNo = sqlMesBaseData.sqlExecuteScalarString("Select distinct material_no from material_info where material_uuid = '" + splitResult[0].ToString() + "'");
                string tempSaveScale = sqlSOFT.sqlExecuteScalarString("select distinct actual_weight from Scale_OngoingMaterialInfo where material_no_uuid = '" + matCustomUUID + "' and (material_uuid = '" + splitResult[0].ToString() + "' or actual_material_uuid = '" + splitResult[0].ToString() + "')");
                string actualMatUUID = sqlSOFT.sqlExecuteScalarString("select distinct actual_material_uuid from Scale_OngoingMaterialInfo where material_no_uuid = '" + matCustomUUID + "'");
                if (!String.IsNullOrWhiteSpace(actualMatUUID))
                {
                    string actualMatName = sqlMesBaseData.sqlExecuteScalarString("Select distinct material_no from material_info where material_uuid = '" + actualMatUUID + "'");
                    dr["actualMatUUID"] = actualMatUUID;
                    dr["actualMatNo"] = actualMatName;
                    dr2["SubMat"] = actualMatName;
                    dr2["SubMatUUID"] = actualMatUUID;
                }
                else
                {
                    dr["actualMatUUID"] = "";
                    dr["actualMatNo"] = "";
                    dr2["SubMat"] = "";
                    dr2["SubMatUUID"] = "";
                }
                dr["matUUID"] = splitResult[0].ToString();
                dr["matNo"] = matNo;
                dr2["MatCode"] = matNo;
                dr2["MatUUID"] = splitResult[0].ToString();
                dr2["ExpDate"] = sqlSOFT.sqlExecuteScalarString("select expDate from Scale_OngoingMaterialInfo where material_no_uuid = '" + matCustomUUID + "'");
                dr2["LOT"] = sqlSOFT.sqlExecuteScalarString("select LOT from Scale_OngoingMaterialInfo where material_no_uuid = '" + matCustomUUID + "'");
                dr["totalDosage"] = VariablesSave.PlanQty * Convert.ToDouble(splitResult[1].ToString().TrimEnd('0'));
                if (!String.IsNullOrWhiteSpace(tempSaveScale))
                {
                    dr["scaleDosage"] = Convert.ToDouble(tempSaveScale);
                    dr2["SumScale"] = Convert.ToDouble(tempSaveScale);
                    VariablesSave.totalScaleWeight = Convert.ToDouble(tempSaveScale);
                }
                else
                {
                    dr["scaleDosage"] = "0";
                    dr2["SumScale"] = "0";
                }
                VariablesSave.matTempDatatable.Rows.Add(dr);
                VariablesSave.tempMat.Rows.Add(dr2);
            }
            VariablesSave.matTempDatatable.AcceptChanges();
            if (VariablesSave.matTempDatatable.Rows.Count > 0)
            {
                dataGridView.DataSource = VariablesSave.matTempDatatable;
                dataGridView.Columns["matUUID"].Visible = false;
                dataGridView.Columns["matNo"].HeaderText = "Mã liệu";
                dataGridView.Columns["actualMatUUID"].Visible = false;
                dataGridView.Columns["actualMatNo"].HeaderText = "Mã liệu thực tế";

                dataGridView.Columns["totalDosage"].HeaderText = "Khối lượng liệu dự kiến";
                dataGridView.Columns["scaleDosage"].HeaderText = "Khối lượng liệu đang lưu tạm/ đang làm";
            }
        }
    }
}
