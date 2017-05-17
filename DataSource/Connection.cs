using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace BankApplication.DataSource
{
    public class Connection
    {
        private SqlConnection conn;
        private SqlDataAdapter myAdapter;
     
        public Connection()
        {
            try
            {
                myAdapter = new SqlDataAdapter();
                conn = new SqlConnection();
                conn.ConnectionString =
                "Data Source=DESKTOP-AVF75E6;" +
                "Initial Catalog=bank;" +
                "User id=sa;" +
                "Password=root;";
                conn.Open();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private SqlConnection openConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State ==
                        ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        public DataTable executeSelectQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCmd = new SqlCommand();
            DataTable dataTable = new DataTable();
            dataTable = null;
            DataSet ds = new DataSet();
            try 
            {
                myCmd.Connection = openConnection();
                myCmd.CommandText = _query;
                myCmd.Parameters.AddRange(sqlParameter);
                myCmd.ExecuteNonQuery();
                myAdapter.SelectCommand = myCmd;
                myAdapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch(SqlException e)
            {
                Console.Write("Error - Connection.executeSelectQuery - Query:" 
                    + _query + " \nException: " + e.StackTrace.ToString());
                return null;
            }
            finally
            {

            }
            return dataTable;
        }

        public bool executeInsertQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCmd = new SqlCommand();
            try
            {
                myCmd.Connection = openConnection();
                myCmd.CommandText = _query;
                myCmd.Parameters.AddRange(sqlParameter);
                myAdapter.InsertCommand = myCmd;
                myCmd.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                Console.Write("Error - Connection.executeInsertQuery - Query"
                    + _query + " \nException: " + e.StackTrace.ToString());
                return false;
            }
            finally
            {
            }
            return true;
        }

        public bool executeUpdateQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCmd = new SqlCommand();
            try
            {
                myCmd.Connection = openConnection();
                myCmd.CommandText = _query;
                myCmd.Parameters.AddRange(sqlParameter);
                myAdapter.UpdateCommand = myCmd;
                myCmd.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                Console.Write("Error - Connection.executeUpdateQuery - Query:"
                    + _query + "\nException: " + e.StackTrace.ToString());
                return false;
            }
            finally
            {
            }
            return true;
        }
        public bool executeDeleteQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCmd = new SqlCommand();
            try
            {
                myCmd.Connection = openConnection();
                myCmd.CommandText = _query;
                myCmd.Parameters.AddRange(sqlParameter);
                myAdapter.DeleteCommand = myCmd;
                myCmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeUpdateQuery - Query:"
                    + _query + "\nException: " + e.StackTrace.ToString());
                return false;
            }
            finally
            {
            }
            return true;
        }

        }

    }

