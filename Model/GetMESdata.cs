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

                WHB.uuid = dt.Rows[i][0].ToString();
                WHB.material_uuid = dt.Rows[i]["material_uuid"].ToString();
                if (double.TryParse(dt.Rows[i]["book_quantity"].ToString(), out rs))
                {
                    WHB.book_quantity = double.Parse(dt.Rows[i]["book_quantity"].ToString());
                }
                else
                {
                    WHB.book_quantity = rs;
                }
                WHB.create_day = dt.Rows[i]["create_date"].ToString();
                WHB.update_date = dt.Rows[i]["update_date"].ToString();
                ListSaveWHB.Add(WHB);
            }
            return ListSaveWHB;
        }
        public static DataTable getWarehouse_flow_data()
        {
            string date = DateTime.Today.ToString("yyyy-MM-dd");
            DataTable dt = new DataTable();
            sqlMESPlanningExcutionCon sqlMESCon = new sqlMESPlanningExcutionCon();
            StringBuilder sqlGetData = new StringBuilder();
            sqlGetData.Append("select uuid, material_uuid, book_quantity, in_out_quantity, this_quantity, create_date, update_date ");
            sqlGetData.Append("from warehouse_flow ");
            sqlGetData.Append("where create_date like '%" + date + "%'");
            sqlMESCon.sqlDataAdapterFillDatatable(sqlGetData.ToString(), ref dt);
            return dt;
        }
    }
}
