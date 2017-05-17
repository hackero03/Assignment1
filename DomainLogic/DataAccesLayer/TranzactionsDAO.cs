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
    public class TranzactionsDAO
    {
        private Connection conn;

        public TranzactionsDAO()
        {
            conn = new Connection();
        }

        //Search byId + Date period
        public DataTable searchByIdAccAndDate(int _id,DateTime _dt)
        {
            string _query = "select * from dbo.tranzactions where idAcc=@idAcc and datecreated > @dateCreated";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@idAcc", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(_id);
            sqlParameters[1] = new SqlParameter("@dateCreated", SqlDbType.DateTime);
            sqlParameters[1].Value = Convert.ToDateTime(_dt);
            return conn.executeSelectQuery(_query, sqlParameters);
        }
        //Insert By Id
        public bool insertByIdAcc(int _id,string _type, int _amount, DateTime _dt)
        {
            string _query = "insert into dbo.tranzactions(idAcc,Type,Amount,DateCreated) values(@idAcc,@Type,@Amount,@dateCreated)";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@idAcc", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(_id);
            sqlParameters[1] = new SqlParameter("@Type", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(_type);
            sqlParameters[2] = new SqlParameter("@amount", SqlDbType.Int);
            sqlParameters[2].Value = Convert.ToInt32(_amount);
            sqlParameters[3] = new SqlParameter("@dateCreated", SqlDbType.DateTime);
            sqlParameters[3].Value = Convert.ToDateTime(_dt);
            return conn.executeInsertQuery(_query, sqlParameters);
        }
    }
}
