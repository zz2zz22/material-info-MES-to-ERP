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
        public static DataTable getWarehouse_books_data()
        {
            DataTable dt = new DataTable();
            sqlMESPlanningExcutionCon sqlMESCon = new sqlMESPlanningExcutionCon();
            StringBuilder sqlGetData = new StringBuilder();
            sqlGetData.Append("select uuid, material_uuid, book_quantity, create_date, update_date ");
            sqlGetData.Append("from warehouse_books ");
            sqlGetData.Append("where create_date like '%2022-08-18%'");
            sqlMESCon.sqlDataAdapterFillDatatable(sqlGetData.ToString(), ref dt);
            return dt;
        }
    }
}
