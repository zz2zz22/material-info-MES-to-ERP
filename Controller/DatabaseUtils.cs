using MySqlConnector;
using System.Data.SqlClient;

namespace MaterialMES2ERP
{
    class DatabaseUtils
    {
        public static SqlConnection GetSoftDBConnection()
        {
            string datasource = "172.16.0.12";
            string database = "ERPSOFT";
            string username = "ERPUSER";
            string password = "12345";
            return DatabaseSQLServerUtils.GetSoftDBConnection(datasource, database, username, password);
        }
        public static MySqlConnection getMes_Planning_Excution() //MES trên con .22 mySQL - sử dụng MySQL DataProvider để clone về server local
        {
            string host = "172.16.0.22"; //mes connection
            string user = "guest";
            string password = "guest@123";
            string database = "mes_planning_excution";

            return DatabaseSQLServerUtils.GetMesDBConnection(host, user, password, database);
        }
    }
}
