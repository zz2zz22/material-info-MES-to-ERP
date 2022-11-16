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
            DataTable dt = new DataTable();
            LoadingDialog loadingDialog = new LoadingDialog();
            
            Thread backgroundThreadLoadOngoingOrders = new Thread(
                    new ThreadStart(() =>
                    {
                        dt = OngoingOrders(keyWord);
                        loadingDialog.BeginInvoke(new Action(() => loadingDialog.Close()));
                    }));
            backgroundThreadLoadOngoingOrders.Start();
            loadingDialog.ShowDialog();

            if (dt.Rows.Count > 0)
            {
                lbData.Visible = false;
                dataGrid.DataSource = dt;
                dataGrid.Columns["job_order_uuid"].Visible = false;
                dataGrid.Columns["work_order_uuid"].Visible = false;
                dataGrid.Columns["job_no"].HeaderText = "Đơn làm việc";
                dataGrid.Columns["erp_order_no"].HeaderText = "Mã sản xuất";
                dataGrid.Columns["product_no"].HeaderText = "Mã sản phẩm";
                dataGrid.Columns["dispatch_qty"].HeaderText = "Số lượng của đơn";
                dataGrid.Columns["finish_qty"].HeaderText = "Số lượng đã làm";
                dataGrid.Columns["update_employee"].HeaderText = "Nhân viên";
                dataGrid.Columns["newest_update_date"].HeaderText = "T.Gian cập nhật";
                dataGrid.Columns["material_custom_no"].Visible = false;
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
 WHERE (dispatch_quantity - finish_quantity) > 0 
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
 JOIN work_order_process AS b ON a.order_uuid = b.work_order_uuid
 WHERE a.delete_flag = '0' AND b.delete_flag = '0' AND c.delete_flag = '0'
 AND a.order_uuid LIKE '" + cbxWOUUID_.Items[i].ToString() + "' AND a.order_no LIKE '%SEMI%' AND c.job_status < 4");
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
    }
}
