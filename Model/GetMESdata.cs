using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialMES2ERP
{
    class GetMESdata
    {
        public static List<SaveWHB> GetWHBs()
        {
            double rs = 0;
            List<SaveWHB> ListSaveWHB = new List<SaveWHB>();
            string date = DateTime.Today.ToString("yyyy-MM-dd");
            DataTable dt = new DataTable();
            sqlMESPlanningExcutionCon sqlMESCon = new sqlMESPlanningExcutionCon();
            StringBuilder sqlGetData = new StringBuilder();
            sqlGetData.Append("select uuid, material_uuid, book_quantity, create_date, update_date ");
            sqlGetData.Append("from warehouse_books ");
            sqlGetData.Append("where create_date like '%" + date + "%'");
            sqlMESCon.sqlDataAdapterFillDatatable(sqlGetData.ToString(), ref dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SaveWHB WHB = new SaveWHB();

                WHB.uuid = dt.Rows[i]["uuid"].ToString();
                WHB.material_uuid = dt.Rows[i]["material_uuid"].ToString();
                if (double.TryParse(dt.Rows[i]["book_quantity"].ToString(), out rs))
                {
                    WHB.book_quantity = double.Parse(dt.Rows[i]["book_quantity"].ToString());
                }
                else
                {
                    WHB.book_quantity = rs;
                }
                WHB.create_day = Convert.ToDateTime(dt.Rows[i]["create_date"]).ToString("dd/MM/yyyy HH:mm:ss");
                WHB.update_date = Convert.ToDateTime(dt.Rows[i]["update_date"]).ToString("dd/MM/yyyy HH:mm:ss");
                ListSaveWHB.Add(WHB);
            }
            return ListSaveWHB;
        }
        public static List<SaveWHF> GetWHFs()
        {
            double rs = 0;
            List<SaveWHF> ListSaveWHF = new List<SaveWHF>();
            string date = DateTime.Today.ToString("yyyy-MM-dd");
            DataTable dt = new DataTable();
            sqlMESPlanningExcutionCon sqlMESCon = new sqlMESPlanningExcutionCon();
            StringBuilder sqlGetData = new StringBuilder();
            sqlGetData.Append("select uuid, material_uuid, book_quantity, in_out_quantity, this_quantity, create_date, update_date ");
            sqlGetData.Append("from warehouse_flow ");
            sqlGetData.Append("where create_date like '%" + date + "%'");
            sqlMESCon.sqlDataAdapterFillDatatable(sqlGetData.ToString(), ref dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SaveWHF WHB = new SaveWHF();

                WHB.uuid = dt.Rows[i]["uuid"].ToString();
                WHB.material_uuid = dt.Rows[i]["material_uuid"].ToString();
                if (double.TryParse(dt.Rows[i]["book_quantity"].ToString(), out rs))
                {
                    WHB.book_quantity = double.Parse(dt.Rows[i]["book_quantity"].ToString());
                }
                else
                {
                    WHB.book_quantity = rs;
                }
                WHB.in_out_quantity = double.Parse(dt.Rows[i]["in_out_quantity"].ToString());
                WHB.this_quantity = double.Parse(dt.Rows[i]["this_quantity"].ToString());
                WHB.create_day = Convert.ToDateTime(dt.Rows[i]["create_date"]).ToString("dd/MM/yyyy HH:mm:ss");
                WHB.update_date = Convert.ToDateTime(dt.Rows[i]["update_date"]).ToString("dd/MM/yyyy HH:mm:ss");
                ListSaveWHF.Add(WHB);
            }
            return ListSaveWHF;
        }
        public static List<SaveBillList> GetBLs()
        {
            double rs = 0;
            List<SaveBillList> ListSaveBL = new List<SaveBillList>();
            string date = DateTime.Today.ToString("yyyy-MM-dd");
            DataTable dt = new DataTable();
            sqlMESPlanningExcutionCon sqlMESCon = new sqlMESPlanningExcutionCon();
            StringBuilder sqlGetData = new StringBuilder();
            sqlGetData.Append("select uuid, material_uuid, wms_in_quntity, unit_code, create_date, update_date ");
            sqlGetData.Append("from wms_in_bill_list ");
            sqlGetData.Append("where create_date like '%" + date + "%'");
            sqlMESCon.sqlDataAdapterFillDatatable(sqlGetData.ToString(), ref dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SaveBillList BL = new SaveBillList();

                BL.uuid = dt.Rows[i]["uuid"].ToString();
                BL.material_uuid = dt.Rows[i]["material_uuid"].ToString();
                if (double.TryParse(dt.Rows[i]["wms_in_quntity"].ToString(), out rs))
                {
                    BL.wms_in_quantity = double.Parse(dt.Rows[i]["wms_in_quntity"].ToString());
                }
                else
                {
                    BL.wms_in_quantity = rs;
                }
                BL.unit_code = dt.Rows[i]["unit_code"].ToString();
                BL.create_day = Convert.ToDateTime(dt.Rows[i]["create_date"]).ToString("dd/MM/yyyy HH:mm:ss");
                BL.update_date = Convert.ToDateTime(dt.Rows[i]["update_date"]).ToString("dd/MM/yyyy HH:mm:ss");
                ListSaveBL.Add(BL);
            }
            return ListSaveBL;
        }
    }
}
