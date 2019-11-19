using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace PROYEK_ACS_SALES_ORDER_V1
{
    public class Database
    {
        OracleConnection conn;
        public Database(string datasource, string user, string pass)
        {
            conn = new OracleConnection($"Data Source = {datasource}; User ID = {user}; Password = {pass};");
        }

        public Object executeScalar(string query)
        {
            conn.Close();
            conn.Open();
            try
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                Object obj = cmd.ExecuteScalar();
                conn.Close();
                return obj;
            }
            catch (Exception ex)
            {
                conn.Close();
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<Object[]> executeQuery(string query)
        {
            conn.Close();
            conn.Open();
            try
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataReader reader = cmd.ExecuteReader();
                List<Object[]> obj = new List<Object[]>();
                while (reader.Read())
                {
                    Object[] row = new Object[reader.FieldCount];
                    int fieldCount = reader.GetValues(row);
                    obj.Add(row);
                }
                conn.Close();
                return obj;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                conn.Close();
                return null;
            }
        }

        public bool executeNonQuery(string query)
        {
            conn.Close();
            conn.Open();
            try
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                conn.Close();
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }

        public OracleDataAdapter executeAdapter(String query)
        {
            conn.Close();
            conn.Open();
            try
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                conn.Close();
                return da;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                conn.Close();
                return null;
            }
        }

        public DataTable executeDataTable(string query)
        {
            conn.Close();
            conn.Open();
            try
            {
                DataTable dt = new DataTable();
                OracleDataAdapter adapter = executeAdapter(query);
                adapter.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                conn.Close();
                return null;
            }
        }

        public void executeDataSet(string query, ref DataSet ds, string tableName)
        {
            conn.Close();
            conn.Open();
            try
            {

                OracleDataAdapter adapter = executeAdapter(query);
                adapter.Fill(ds, tableName);
                conn.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                conn.Close();
            }
        }
    }
}