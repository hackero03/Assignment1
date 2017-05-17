using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApplication.DataSource;
using System.Data;
using System.Data.SqlClient;
namespace BankApplication.DomainLogic.DataAccesLayer
{
    public class LoginDAO
    {
        private Connection conn;

        public LoginDAO()
        {
            conn = new Connection();
        }

        public DataTable searchByUserPass(string _username,string _password)
        {
            string _query = string.Format("select * from dbo.logins where Username = @username and Password = @password");
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@username",SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(_username);
            sqlParameters[1] = new SqlParameter("@password", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(_password);
            return conn.executeSelectQuery(_query, sqlParameters);
        }
       
    }
}
