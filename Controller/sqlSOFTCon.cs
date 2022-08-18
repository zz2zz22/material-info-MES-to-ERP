using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySqlConnector;

namespace MaterialMES2ERP
{
    public class sqlSOFTCon
    {
        public SqlConnection conn = DatabaseUtils.GetSoftDBConnection();

        public string sqlExecuteScalarString(string sql)
        {
            string outstring;
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                outstring = cmd.ExecuteScalar().ToString();
                conn.Close();
                return outstring;
            }
            catch (Exception)
            {
                conn.Close();
                return string.Empty;
            }
        }
        public void sqlDataAdapterFillDatatable(string sql, ref DataTable dt)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter adapter = new SqlDataAdapter();
                {
                    cmd.CommandText = sql;
                    cmd.Connection = conn;
                    adapter.SelectCommand = cmd;
                    adapter.Fill(dt);
                }
            }
            catch (Exception)
            {
            }
            conn.Close();
        }
        public void getComboBoxData(string sql, ref ComboBox cmb)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                adapter.Dispose();
                cmd.Dispose();
                cmb.Items.Clear();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    cmb.Items.Add(row[0].ToString());
                }
            }
            catch (Exception)
            {
            }
            conn.Close();
        }
        public bool sqlExecuteNonQuery(string sql)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                int response = cmd.ExecuteNonQuery();
                if (response >= 1)
                {                    
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception)
            {
                conn.Close();
                return false;
            }
        }
    }
}
