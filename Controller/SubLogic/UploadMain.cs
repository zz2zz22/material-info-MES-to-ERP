using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MaterialMES2ERP
{
    public class UploadMain
    {
        public static string nextNoFill;
        public static string returnedOrderUUID;
        public static string Date;
        public static string matCustomUUID;

        //Report variable save
        public static string jobMatUUID;
        public static string updateAutoCodeHis() //return SQL query to update 
        {
            try
            {
                int nextNo = 0;
                int remainChar;
                string empCode = VariablesSave.EmpCode;
                sqlMesBaseDataCon sqlMesBaseData = new sqlMesBaseDataCon();
                StringBuilder sqlUpdateAutoCodeHis = new StringBuilder();
                string NumStr = sqlMesBaseData.sqlExecuteScalarString("SELECT current_number FROM autocode_his WHERE autocode_rule_uuid = '4E8DQFCD9BK1' AND delete_flag = '0'");
                if (!String.IsNullOrEmpty(NumStr))
                {
                    remainChar = Convert.ToInt32(sqlMesBaseData.sqlExecuteScalarString("SELECT LENGTH FROM autocode_info WHERE autocode_rule_uuid = '4E8DQFCD9BK1' AND line_no = '2' AND delete_flag = '0'"));
                    string curNumStr = NumStr.TrimStart('0');
                    curNumStr = curNumStr.Length > 0 ? curNumStr : "0";
                    if (int.TryParse(curNumStr, out int curNo))
                    {
                        curNo = int.Parse(curNumStr);
                        nextNo = curNo + 1;
                        remainChar = remainChar - nextNo.ToString().Length;
                        nextNoFill = nextNo.ToString().PadLeft(nextNo.ToString().Length + remainChar, '0');
                        sqlUpdateAutoCodeHis.Append(@"update autocode_his set current_number = '" + nextNoFill + "', update_by = '" + empCode + "', update_date  = '" + Date + "' where autocode_rule_uuid = '4E8DQFCD9BK1' AND delete_flag = '0'");
                    }
                    else
                    {
                        throw new ArgumentException("Không chuyển được mã autocode sang số nguyên!");
                    }
                }
                else
                {
                    throw new ArgumentException("Không thể lấy mã autocode!");
                }
                return sqlUpdateAutoCodeHis.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update to autocode_his: Exception thrown!");
                return null;
            }
        }

        public static bool checkUpdate()
        {
            sqlMesPlanningExcutionCon sqlMesPlanningExcution = new sqlMesPlanningExcutionCon();
            sqlMesBaseDataCon sqlMesBaseData = new sqlMesBaseDataCon();
            string jobOrderUUID, jobOrderMatUUID;
            if (!String.IsNullOrEmpty(VariablesSave.JobOrderUUID))
            {
                jobOrderUUID = VariablesSave.JobOrderUUID;
            }
            else
            {
                throw new ArgumentException("Job Order UUID không thể bị rỗng!");
            }

            jobOrderMatUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select uuid from job_order_material where job_order_uuid = '" + jobOrderUUID + "'");
            if (!String.IsNullOrEmpty(jobOrderMatUUID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string updateJobOrderMat(DataTable matDT, int i)
        {
            try
            {
                sqlMesPlanningExcutionCon sqlMesPlanningExcution = new sqlMesPlanningExcutionCon();
                sqlMesBaseDataCon sqlMesBaseData = new sqlMesBaseDataCon();
                StringBuilder updateJOrderMat = new StringBuilder();
                // Get or Generate data to insert to job_order_material for each line of data in tempMat datatable
                string jobOrderMatUUID, jobOrderUUID, actMaterialNo, actMaterialUUID, actMaterialName, actMatUnitID, subMatNo, subMatUUID, subMatName, actMaterialLOT, matExpDate, empCode, actBeginMatQty;

                if (!String.IsNullOrEmpty(VariablesSave.JobOrderUUID))
                {
                    jobOrderUUID = VariablesSave.JobOrderUUID;
                }
                else
                {
                    throw new ArgumentException("Job Order UUID không thể bị rỗng!");
                }
                bool isMissingData = false;
                jobOrderMatUUID = sqlMesPlanningExcution.sqlExecuteScalarString("select uuid from job_order_material where job_order_uuid = '" + jobOrderUUID + "'");

                matDT.Rows[i]["JOMatUUID"] = jobOrderMatUUID;
                actMaterialNo = matDT.Rows[i]["MatCode"].ToString();
                actMaterialUUID = sqlMesBaseData.sqlExecuteScalarString("SELECT material_uuid FROM material_info WHERE material_no = '" + actMaterialNo + "' AND delete_flag = '0'");
                matDT.Rows[i]["MatUUID"] = actMaterialUUID;
                actMaterialName = sqlMesBaseData.sqlExecuteScalarString("SELECT material_name FROM material_info WHERE material_uuid = '" + actMaterialUUID + "' AND delete_flag = '0'");
                actMatUnitID = sqlMesBaseData.sqlExecuteScalarString("SELECT unit_uuid FROM material_info WHERE material_uuid = '" + actMaterialUUID + "' and delete_flag = '0'");

                //Check if order have subtitute material ?
                if (!String.IsNullOrEmpty(matDT.Rows[i]["SubMat"].ToString()))
                {
                    subMatNo = "'" + matDT.Rows[i]["SubMat"].ToString() + "'";
                    subMatUUID = "'" + sqlMesBaseData.sqlExecuteScalarString("SELECT material_uuid FROM material_info WHERE material_no = '" + matDT.Rows[i]["SubMat"].ToString() + "' AND delete_flag = '0'") + "'";
                    matDT.Rows[i]["SubMatUUID"] = subMatUUID;
                    subMatName = "'" + sqlMesBaseData.sqlExecuteScalarString("SELECT material_name FROM material_info WHERE material_no = '" + matDT.Rows[i]["SubMat"].ToString() + "' AND delete_flag = '0'") + "'";
                }
                else
                {
                    //Generate null values
                    subMatNo = "NULL";
                    subMatUUID = "NULL";
                    matDT.Rows[i]["SubMatUUID"] = subMatUUID;
                    subMatName = "NULL";
                }
                if (!String.IsNullOrEmpty(matDT.Rows[i]["LOT"].ToString()))
                {
                    actMaterialLOT = "'" + matDT.Rows[i]["LOT"].ToString() + "'";
                }
                else
                {
                    actMaterialLOT = "NULL";
                }
                if (!String.IsNullOrEmpty(matDT.Rows[i]["ExpDate"].ToString()))
                {
                    string[] tempExpDate = matDT.Rows[i]["ExpDate"].ToString().Split('/');
                    matExpDate = "'" + tempExpDate[2] + "-" + tempExpDate[1] + "-" + tempExpDate[0] + "'";
                }
                else
                {
                    matExpDate = "NULL";
                }
                actBeginMatQty = matDT.Rows[i]["SumScale"].ToString();
                empCode = VariablesSave.EmpCode;
                if ( String.IsNullOrEmpty(empCode))
                {
                    isMissingData = true;
                }
                if (!isMissingData)
                {
                    updateJOrderMat.Append("update job_order_material set ");
                    updateJOrderMat.Append("substitute_material_uuid = " + subMatUUID + ", substitute_material_code = " + subMatNo + ", substitute_material_name = " + subMatName + ", ");
                    updateJOrderMat.Append("actual_finish_lot_no = " + actMaterialLOT + ", actual_material_begin_qty = " + actBeginMatQty + ", actual_material_end_qty = " + actBeginMatQty + ", actual_material_qty = " + actBeginMatQty + ", ");
                    updateJOrderMat.Append("update_by = '" + empCode + "', update_date = '" + Date + "' where job_order_uuid = '" + jobOrderUUID + "' and actual_material_no = '" + actMaterialNo + "'");
                    return updateJOrderMat.ToString();
                }
                else
                {
                    throw new ArgumentException("Thiếu dữ liệu đầu vào !");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert to job_order_material: Exception thrown!");
                return null;
            }
        }

        public static string insertJobOrderMat(DataTable matDT, int i) //Truyền vào datatable + vị trí dòng để thực hiện sqlCommand trong transaction cho nhiều dòng bằng vòng lặp for
        {
            try
            {
                sqlSOFTCon sqlSOFT = new sqlSOFTCon();
                sqlMesPlanningExcutionCon sqlMesPlanningExcution = new sqlMesPlanningExcutionCon();
                sqlMesBaseDataCon sqlMesBaseData = new sqlMesBaseDataCon();
                StringBuilder sqlInsertJOrderMat = new StringBuilder();
                // Get or Generate data to insert to job_order_material for each line of data in tempMat datatable
                string jobOrderMatUUID, jobOrderUUID, actMaterialNo, actMaterialUUID, actMaterialName, actMatUnitID, subMatNo, subMatUUID, subMatName, actMaterialLOT, matExpDate, empCode, actBeginMatQty;

                if (!String.IsNullOrEmpty(VariablesSave.JobOrderUUID))
                {
                    jobOrderUUID = VariablesSave.JobOrderUUID;
                }
                else
                {
                    throw new ArgumentException("Job Order UUID không thể bị rỗng!");
                }
                bool isMissingData = false;
                jobOrderMatUUID = UUIDGenerator.getAscId();
                jobMatUUID = jobOrderMatUUID;
                matDT.Rows[i]["JOMatUUID"] = jobOrderMatUUID;
                actMaterialNo = matDT.Rows[i]["MatCode"].ToString();
                actMaterialUUID = sqlMesBaseData.sqlExecuteScalarString("SELECT material_uuid FROM material_info WHERE material_no = '" + actMaterialNo + "' AND delete_flag = '0'");
                matDT.Rows[i]["MatUUID"] = actMaterialUUID;
                actMaterialName = sqlMesBaseData.sqlExecuteScalarString("SELECT material_name FROM material_info WHERE material_uuid = '" + actMaterialUUID + "' AND delete_flag = '0'");
                actMatUnitID = sqlMesBaseData.sqlExecuteScalarString("SELECT unit_uuid FROM material_info WHERE material_uuid = '" + actMaterialUUID + "' and delete_flag = '0'");
                //Check if order have subtitute material ?
                if (!String.IsNullOrEmpty(matDT.Rows[i]["SubMat"].ToString()))
                {
                    subMatNo = "'" + matDT.Rows[i]["SubMat"].ToString() + "'";
                    subMatUUID = "'" + sqlMesBaseData.sqlExecuteScalarString("SELECT material_uuid FROM material_info WHERE material_no = '" + matDT.Rows[i]["SubMat"].ToString() + "' AND delete_flag = '0'") + "'";
                    matDT.Rows[i]["SubMatUUID"] = subMatUUID;
                    subMatName = "'" + sqlMesBaseData.sqlExecuteScalarString("SELECT material_name FROM material_info WHERE material_no = '" + matDT.Rows[i]["SubMat"].ToString() + "' AND delete_flag = '0'") + "'";
                }
                else
                {
                    //Generate null values
                    subMatNo = "NULL";
                    subMatUUID = "NULL";
                    matDT.Rows[i]["SubMatUUID"] = subMatUUID;
                    subMatName = "NULL";
                }
                
                if (!String.IsNullOrEmpty(matDT.Rows[i]["LOT"].ToString()))
                {
                    actMaterialLOT = "'" + matDT.Rows[i]["LOT"].ToString() + "'";
                }
                else
                {
                    actMaterialLOT = "NULL";
                }
                if (!String.IsNullOrEmpty(matDT.Rows[i]["ExpDate"].ToString()))
                {
                    string[] tempExpDate = matDT.Rows[i]["ExpDate"].ToString().Split('/');
                    matExpDate = "'" + tempExpDate[2] + "-" + tempExpDate[1] + "-" + tempExpDate[0] + "'";
                }
                else
                {
                    matExpDate = "NULL";
                }
                actBeginMatQty = matDT.Rows[i]["SumScale"].ToString();
                empCode = VariablesSave.EmpCode;

                if ( String.IsNullOrEmpty(empCode))
                {
                    isMissingData = true;
                }

                if (!isMissingData)
                {
                    sqlInsertJOrderMat.Append("Insert into job_order_material ");
                    sqlInsertJOrderMat.Append(@"(uuid, job_order_uuid, actual_material_uuid, actual_material_no, actual_material_name, ");
                    sqlInsertJOrderMat.Append(@"substitute_material_uuid, substitute_material_code, substitute_material_name, actual_finish_lot_no, ");
                    sqlInsertJOrderMat.Append(@"material_prod_date, material_exp_date, actual_material_begin_qty, actual_unit_uuid, actual_material_end_qty, actual_material_qty, ");
                    sqlInsertJOrderMat.Append(@"delete_flag, create_by, update_by, create_date, update_date, tenant_id )");
                    sqlInsertJOrderMat.Append(" values ( ");
                    sqlInsertJOrderMat.Append("'" + jobOrderMatUUID + "', '" + jobOrderUUID + "', '" + actMaterialUUID + "', '" + actMaterialNo + "', '" + actMaterialName + "', ");
                    sqlInsertJOrderMat.Append(subMatUUID + ", " + subMatNo + ", " + subMatName + ", " + actMaterialLOT + ", ");
                    sqlInsertJOrderMat.Append("NULL, " + matExpDate + ", '" + actBeginMatQty + "', '" + actMatUnitID + "', '" + actBeginMatQty + "', '" + actBeginMatQty + "', ");
                    sqlInsertJOrderMat.Append("'0', '" + empCode + "', NULL, '" + Date + "', NULL, '-1' )");
                    StringBuilder insertTemp = new StringBuilder();

                    string checkJobOrderUUID = sqlSOFT.sqlExecuteScalarString("select work_order_uuid from Scale_OngoingOrder where job_order_uuid = '" + VariablesSave.JobOrderUUID + "'");
                    if (String.IsNullOrEmpty(checkJobOrderUUID))
                    {
                        insertTemp.Append("Insert into Scale_OngoingOrder ");
                        insertTemp.Append(@"(job_order_uuid, work_order_uuid, job_mat_order_uuid) ");
                        insertTemp.Append(" values ( ");
                        insertTemp.Append("'" + jobOrderUUID + "', '" + VariablesSave.WorkOrderUUID + "', '" + jobOrderMatUUID + "' )");
                        sqlSOFT.sqlExecuteNonQuery(insertTemp.ToString(), false);
                    }
                        
                    return sqlInsertJOrderMat.ToString();
                }
                else
                {
                    throw new ArgumentException("Thiếu dữ liệu đầu vào !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert to job_order_material: Exception thrown!");
                return null;
            }
        }

        public static string insertReturnedMatOrder()
        {
            try
            {
                sqlMesPlanningExcutionCon sqlMesPlanningExcution = new sqlMesPlanningExcutionCon();
                StringBuilder sqlInsertReturnedMat = new StringBuilder();
                string jobOrderUUID, workOrderUUID, jobNo, belongOrg, equipmentUUID;

                returnedOrderUUID = UUIDGenerator.getAscId();
                jobOrderUUID = VariablesSave.JobOrderUUID;
                workOrderUUID = VariablesSave.WorkOrderUUID;
                jobNo = sqlMesPlanningExcution.sqlExecuteScalarString("SELECT distinct job_no from job_order WHERE UUID = '" + jobOrderUUID + "' AND work_order_uuid = '" + workOrderUUID + "' AND delete_flag = '0'");
                belongOrg = sqlMesPlanningExcution.sqlExecuteScalarString("SELECT distinct belong_organization from job_order WHERE UUID = '" + jobOrderUUID + "' AND work_order_uuid = '" + workOrderUUID + "' AND delete_flag = '0'");
                equipmentUUID = sqlMesPlanningExcution.sqlExecuteScalarString("SELECT distinct equipment_uuid from job_order WHERE UUID = '" + jobOrderUUID + "' AND work_order_uuid = '" + workOrderUUID + "' AND delete_flag = '0'");

                sqlInsertReturnedMat.Append("Insert into returned_material_order ");
                sqlInsertReturnedMat.Append(@"(uuid, returned_material_order_no, job_uuid, work_order_uuid, job_no, ");
                sqlInsertReturnedMat.Append(@"belong_organization, employee_uuid, equipment_uuid, tooling_uuid, ");
                sqlInsertReturnedMat.Append(@"order_status, super_collar_flag, returned_replenishment_type, delete_flag, ");
                sqlInsertReturnedMat.Append(@"create_by, create_date, update_by, update_date, tenant_id) ");
                sqlInsertReturnedMat.Append(" values ( ");
                sqlInsertReturnedMat.Append("'" + returnedOrderUUID + "', '" + nextNoFill + "', '" + jobOrderUUID + "', '" + workOrderUUID + "', '" + jobNo + "', ");
                sqlInsertReturnedMat.Append("'" + belongOrg + "', '" + VariablesSave.EmpUUID + "', '" + equipmentUUID + "', '', ");
                sqlInsertReturnedMat.Append("'0', NULL, '" + VariablesSave.replenishmentType + "', '0', "); // Ask iRoot --> replenishment type --> Let user choose which type
                sqlInsertReturnedMat.Append("'" + VariablesSave.EmpCode + "', '" + Date + "', NULL, NULL, '-1')");
                return sqlInsertReturnedMat.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert to returned_material_order: Exception thrown!");
                return null;
            }
        }

        public static string insertReturnedMatList(DataTable matDT, int i)
        {
            try
            {
                sqlMesPlanningExcutionCon sqlMesPlanningExcution = new sqlMesPlanningExcutionCon();
                StringBuilder sqlInsertReturnedMatList = new StringBuilder();
                string returnOrdListUUID, returnOrdUUID, returnOrdNo, jobOrdMatUUID, actMatUUID, subMatUUID, actReturnQty, empCode;

                returnOrdListUUID = UUIDGenerator.getAscId();
                returnOrdUUID = returnedOrderUUID;
                returnOrdNo = nextNoFill;
                jobOrdMatUUID = matDT.Rows[i]["JOMatUUID"].ToString();
                actMatUUID = matDT.Rows[i]["MatUUID"].ToString();
                subMatUUID = matDT.Rows[i]["SubMatUUID"].ToString();
                actReturnQty = matDT.Rows[i]["SumScale"].ToString();
                empCode = VariablesSave.EmpCode;

                sqlInsertReturnedMatList.Append("Insert into returned_material_order_list ");
                sqlInsertReturnedMatList.Append(@"(uuid, returned_order_uuid, returned_order_no, job_order_material_uuid, ");
                sqlInsertReturnedMatList.Append(@"actual_material_uuid, substitute_material_uuid, actual_material_returned_qty, delete_flag, ");
                sqlInsertReturnedMatList.Append(@"create_by, create_date, update_by, update_date, tenant_id )");
                sqlInsertReturnedMatList.Append(" values ( ");
                sqlInsertReturnedMatList.Append("'" + returnOrdListUUID + "', '" + returnOrdUUID + "', '" + returnOrdNo + "', '" + jobOrdMatUUID + "', ");
                sqlInsertReturnedMatList.Append("'" + actMatUUID + "', " + subMatUUID + ", '" + actReturnQty + "', '0', ");
                sqlInsertReturnedMatList.Append("'" + empCode + "', '" + Date + "', NULL, NULL, '-1')");

                return sqlInsertReturnedMatList.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert to returned_material_order: Exception thrown!");
                return null;
            }
        }

        public static void transactionSupportUploadData(DataTable matDT, DataTable matDosage)
        {
            bool isOverWeight = false;
            for (int i = 0; i < matDT.Rows.Count; i++)
            {
                for (int j = 0; j < matDosage.Rows.Count; j++)
                {
                    if (!String.IsNullOrWhiteSpace(matDosage.Rows[j]["actualMatUUID"].ToString()))
                    {
                        if (matDosage.Rows[j]["matUUID"].ToString().Trim() == matDT.Rows[i]["MatUUID"].ToString().Trim() || matDosage.Rows[j]["actualMatUUID"].ToString().Trim() == matDT.Rows[i]["SubMatUUID"].ToString().Trim())
                        {
                            if (Convert.ToDouble(matDosage.Rows[j]["totalDosage"].ToString()) < (Convert.ToDouble(matDosage.Rows[j]["scaleDosage"].ToString()) + Convert.ToDouble(matDT.Rows[i]["SumScale"].ToString())))
                            {
                                isOverWeight = true;
                            }
                        }
                    }
                    else
                    {
                        if (matDosage.Rows[j]["matUUID"].ToString().Trim() == matDT.Rows[i]["MatUUID"].ToString().Trim())
                        {
                            if (Convert.ToDouble(matDosage.Rows[j]["totalDosage"].ToString()) < (Convert.ToDouble(matDosage.Rows[j]["scaleDosage"].ToString()) + Convert.ToDouble(matDT.Rows[i]["SumScale"].ToString())))
                            {
                                isOverWeight = true;
                            }
                        }
                    }
                }
            }
            if (isOverWeight == true) // Add thêm điều kiện đã xác nhận
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn nhập MES không ?", "Cảnh báo", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    if (checkUpdate())
                    {
                        //= UploadMain.updateJobOrderMat(matDT, i);
                        string cmd;
                        MySqlConnection conn = DatabaseUtils.GetMes_Planning_ExcutionDBC();
                        MySqlTransaction trans = null;
                        MySqlCommand cmdMS = new MySqlCommand();
                        try
                        {
                            conn.Open();
                            trans = conn.BeginTransaction();
                            cmdMS.Transaction = trans;
                            cmdMS.Connection = conn;
                            // Update mes_base_data.autocode_his
                            for (int i = 0; i < matDT.Rows.Count; i++)
                            {
                                cmd = UploadMain.updateJobOrderMat(matDT, i);
                               
                                if (!String.IsNullOrEmpty(cmd))
                                {
                                    cmdMS.CommandText = cmd;
                                    cmdMS.ExecuteNonQuery();
                                }
                                else
                                {
                                    throw new ArgumentException("Command text cannot null");
                                }
                            }
                            trans.Commit();
                            //Init connection to MES database with admin connection to edit data
                            MessageBox.Show("Succesfully saved data!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + "\nFail to update data to MES!", "Error");
                            trans.Rollback();
                        }
                    }
                    else
                    {
                        string cmd1 = UploadMain.updateAutoCodeHis();
                        string cmd3 = UploadMain.insertReturnedMatOrder();
                        string cmd2, cmd4;
                        MySqlConnection conn1 = DatabaseUtils.GetMes_Base_DataDBC();
                        MySqlConnection conn2 = DatabaseUtils.GetMes_Planning_ExcutionDBC();
                        MySqlTransaction trans1 = null;
                        MySqlTransaction trans2 = null;
                        MySqlCommand cmdMS1 = new MySqlCommand();
                        MySqlCommand cmdMS2 = new MySqlCommand();
                        try
                        {
                            conn1.Open();
                            conn2.Open();
                            trans1 = conn1.BeginTransaction();
                            trans2 = conn2.BeginTransaction();
                            cmdMS1.Transaction = trans1;
                            cmdMS2.Transaction = trans2;
                            cmdMS1.Connection = conn1;
                            cmdMS2.Connection = conn2;
                            // Update mes_base_data.autocode_his
                            if (!String.IsNullOrEmpty(cmd1))
                            {
                                cmdMS1.CommandText = cmd1;
                                cmdMS1.ExecuteNonQuery();
                            }
                            else
                            {
                                throw new ArgumentException("Command text cannot null");
                            }

                            // Update / insert mes_planning_excution tables
                            if (!String.IsNullOrEmpty(cmd3))
                            {
                                cmdMS2.CommandText = cmd3;
                                cmdMS2.ExecuteNonQuery();
                            }
                            else
                            {
                                throw new ArgumentException("Command text cannot null");
                            }
                            for (int i = 0; i < matDT.Rows.Count; i++)
                            {

                                cmd2 = UploadMain.insertJobOrderMat(matDT, i);
                                cmd4 = UploadMain.insertReturnedMatList(matDT, i);
                                if (!String.IsNullOrEmpty(cmd2) && !String.IsNullOrEmpty(cmd4))
                                {
                                    cmdMS2.CommandText = cmd2;
                                    cmdMS2.ExecuteNonQuery();

                                    cmdMS2.CommandText = cmd4;
                                    cmdMS2.ExecuteNonQuery();
                                    //sqlMesPlanningExcutionCon sqlMesPlanning = new sqlMesPlanningExcutionCon();
                                    //string jobNo = sqlMesPlanning.sqlExecuteScalarString("SELECT distinct job_no from job_order WHERE UUID = '" + VariablesSave.JobOrderUUID + "' AND work_order_uuid = '" + VariablesSave.WorkOrderUUID + "' AND delete_flag = '0'");
                                    //string[] tempExpDate = matDT.Rows[i]["ExpDate"].ToString().Split('/');
                                    //string matExpDate = tempExpDate[2] + "-" + tempExpDate[1] + "-" + tempExpDate[0];
                                    //DataReport.addReport(DataReport.RP_TYPE.Success, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), jobMatUUID, jobNo, matDT.Rows[i]["MatCode"].ToString(), matDT.Rows[i]["SubMat"].ToString(), matDT.Rows[i]["SumScale"].ToString(), matExpDate, matDT.Rows[i]["LOT"].ToString(), nextNoFill, "Successfully transfer material info to MES system !");
                                }
                                else
                                {
                                    throw new ArgumentException("Command text cannot null");
                                }
                            }

                            trans1.Commit();
                            trans2.Commit();
                            //Init connection to MES database with admin connection to edit data
                            MessageBox.Show("Succesfully saved data!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + "\nFail to add and update data to MES!", "Error");
                            trans1.Rollback();
                            trans2.Rollback();
                        }
                    }
                    
                }
            }
            else
            {
                DialogResult dialogResult2 = MessageBox.Show("Chưa đạt đến khối lượng liệu dự tính cho đơn bạn có muốn nhập MES không ?", "Cảnh báo", MessageBoxButtons.OKCancel);
                if (dialogResult2 == DialogResult.OK)
                {
                    if (checkUpdate())
                    {
                        //= UploadMain.updateJobOrderMat(matDT, i);
                        string cmd;
                        MySqlConnection conn = DatabaseUtils.GetMes_Planning_ExcutionDBC();
                        MySqlTransaction trans = null;
                        MySqlCommand cmdMS = new MySqlCommand();
                        try
                        {
                            conn.Open();
                            trans = conn.BeginTransaction();
                            cmdMS.Transaction = trans;
                            cmdMS.Connection = conn;
                            // Update mes_base_data.autocode_his
                            for (int i = 0; i < matDT.Rows.Count; i++)
                            {
                                cmd = UploadMain.updateJobOrderMat(matDT, i);

                                if (!String.IsNullOrEmpty(cmd))
                                {
                                    cmdMS.CommandText = cmd;
                                    cmdMS.ExecuteNonQuery();
                                }
                                else
                                {
                                    throw new ArgumentException("Command text cannot null");
                                }
                            }
                            trans.Commit();
                            //Init connection to MES database with admin connection to edit data
                            MessageBox.Show("Succesfully saved data!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + "\nFail to add and update data to MES!", "Error");
                            trans.Rollback();
                        }
                    }
                    else
                    {
                        string cmd1 = UploadMain.updateAutoCodeHis();
                        string cmd3 = UploadMain.insertReturnedMatOrder();
                        string cmd2, cmd4;
                        MySqlConnection conn1 = DatabaseUtils.GetMes_Base_DataDBC();
                        MySqlConnection conn2 = DatabaseUtils.GetMes_Planning_ExcutionDBC();
                        MySqlTransaction trans1 = null;
                        MySqlTransaction trans2 = null;
                        MySqlCommand cmdMS1 = new MySqlCommand();
                        MySqlCommand cmdMS2 = new MySqlCommand();
                        try
                        {
                            conn1.Open();
                            conn2.Open();
                            trans1 = conn1.BeginTransaction();
                            trans2 = conn2.BeginTransaction();
                            cmdMS1.Transaction = trans1;
                            cmdMS2.Transaction = trans2;
                            cmdMS1.Connection = conn1;
                            cmdMS2.Connection = conn2;
                            // Update mes_base_data.autocode_his
                            if (!String.IsNullOrEmpty(cmd1))
                            {
                                cmdMS1.CommandText = cmd1;
                                cmdMS1.ExecuteNonQuery();
                            }
                            else
                            {
                                throw new ArgumentException("Command text cannot null");
                            }

                            // Update / insert mes_planning_excution tables
                            if (!String.IsNullOrEmpty(cmd3))
                            {
                                cmdMS2.CommandText = cmd3;
                                cmdMS2.ExecuteNonQuery();
                            }
                            else
                            {
                                throw new ArgumentException("Command text cannot null");
                            }
                            for (int i = 0; i < matDT.Rows.Count; i++)
                            {

                                cmd2 = UploadMain.insertJobOrderMat(matDT, i);
                                cmd4 = UploadMain.insertReturnedMatList(matDT, i);
                                if (!String.IsNullOrEmpty(cmd2) && !String.IsNullOrEmpty(cmd4))
                                {
                                    cmdMS2.CommandText = cmd2;
                                    cmdMS2.ExecuteNonQuery();

                                    cmdMS2.CommandText = cmd4;
                                    cmdMS2.ExecuteNonQuery();
                                    //sqlMesPlanningExcutionCon sqlMesPlanning = new sqlMesPlanningExcutionCon();
                                    //string jobNo = sqlMesPlanning.sqlExecuteScalarString("SELECT distinct job_no from job_order WHERE UUID = '" + VariablesSave.JobOrderUUID + "' AND work_order_uuid = '" + VariablesSave.WorkOrderUUID + "' AND delete_flag = '0'");
                                    //string[] tempExpDate = matDT.Rows[i]["ExpDate"].ToString().Split('/');
                                    //string matExpDate = tempExpDate[2] + "-" + tempExpDate[1] + "-" + tempExpDate[0];
                                    //DataReport.addReport(DataReport.RP_TYPE.Success, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), jobMatUUID, jobNo, matDT.Rows[i]["MatCode"].ToString(), matDT.Rows[i]["SubMat"].ToString(), matDT.Rows[i]["SumScale"].ToString(), matExpDate, matDT.Rows[i]["LOT"].ToString(), nextNoFill, "Successfully transfer material info to MES system !");
                                }
                                else
                                {
                                    throw new ArgumentException("Command text cannot null");
                                }
                            }

                            trans1.Commit();
                            trans2.Commit();
                            //Init connection to MES database with admin connection to edit data
                            MessageBox.Show("Succesfully saved data!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + "\nFail to add and update data to MES!", "Error");
                            trans1.Rollback();
                            trans2.Rollback();
                        }
                    }
                    
                }
            }
        }
    }
}
