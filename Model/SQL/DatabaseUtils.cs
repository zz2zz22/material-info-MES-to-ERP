using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySqlConnector;
using System.Data.SqlClient;

namespace MaterialMES2ERP
{
    class DatabaseUtils
    {
        #region MES database cons
        public static MySqlConnection GetMes_Base_DataDBC()
        {
            string host = "localhost"; // 172.16.0.22 - test(localhost - pass hay dung)
            string user = "root";
            string password = "leanhvupro1"; // cloud-123456
            string database = "mes_base_data";

            return DatabaseSQLServerUtils.GetMesDBConnection(host, user, password, database);
        }

        public static MySqlConnection GetMes_Planning_ExcutionDBC()
        {
            string host = "localhost"; // 172.16.0.22
            string user = "root";
            string password = "leanhvupro1";// cloud-123456
            string database = "mes_planning_excution";

            return DatabaseSQLServerUtils.GetMesDBConnection(host, user, password, database);
        }
        #endregion

        #region Software database cons
        public static SqlConnection GetSoftDBConnection() 
        {
            string datasource = "172.16.0.12";
            string database = "VUSOFT_SUPPORT";
            string username = "ERPUSER";
            string password = "12345";

            //string connectionString = @"Data Source=DESKTOP-R9UCIUR/SQLEXPRESS;Initial Catalog=TLVN2; Integrated Security = True"; //Test on local server clone from mes_interface on MES database.
            return DatabaseSQLServerUtils.GetSoftDBConnection(datasource, database, username, password);
        }
        #endregion
    }
}
