using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApplication.DataSource;
using System.Data;
using System.Data.SqlClient;
using BankApplication.DomainLogic.ValueObject;
namespace BankApplication.DomainLogic.DataAccesLayer
{
    public class BankAccountDAO
    {
        private Connection conn;
        private BankAccountsVO _accountVO;
        public BankAccountDAO()
        {
            conn = new Connection();
            _accountVO = new BankAccountsVO();
        }
        //Search * by idClient- from accounts
        public DataTable searchByIDClient(int _id)
        {
            string _query = "select * from dbo.bankaccounts where idClient=@idClient";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@idClient", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(_id);
            return conn.executeSelectQuery(_query, sqlParameters);
        }
        //Sdarc * by idAcc
        public DataTable searchByIdAcc(int _id)
        {
            string _query = "select * from dbo.bankaccounts where idAcc=@idAcc";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@idAcc", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(_id);
            return conn.executeSelectQuery(_query, sqlParameters);
        }
        //Update id+money
        public bool updateByIdTransfer(int _id, int _amount)
        {
            string _query = "update dbo.BankAccounts set [Amount of money] = @amount where idAcc=@idAcc";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@idAcc", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(_id);
            sqlParameters[1] = new SqlParameter("@amount", SqlDbType.Int);
            sqlParameters[1].Value = Convert.ToInt32(_amount);
            return conn.executeUpdateQuery(_query, sqlParameters);
        }
        //Display all acounts
        public DataTable DisplayAccounts()
        {
            string _query = "select * from dbo.bankaccounts";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return conn.executeSelectQuery(_query, sqlParameters);
        }
        //Insert
        public bool insertAccount(BankAccountsVO _accountVO)
        {
            string _query = "insert into dbo.bankaccounts(idClient,Type,[Amount of money],Date_Created) values(@idClient,@Type,@amount,@dateCreated)";
            SqlParameter[] sqlParameters = new SqlParameter[4];
           
            sqlParameters[0] = new SqlParameter("@idClient", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(_accountVO.idClient);
            sqlParameters[1] = new SqlParameter("@Type", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(_accountVO.type);
            sqlParameters[2] = new SqlParameter("@amount", SqlDbType.Int);
            sqlParameters[2].Value = Convert.ToInt32(_accountVO.amount);
            sqlParameters[3] = new SqlParameter("@dateCreated", SqlDbType.DateTime);
            sqlParameters[3].Value = Convert.ToDateTime(_accountVO.date);
          
            return conn.executeInsertQuery(_query, sqlParameters);
        }
        //Update Account
        public bool updateAcc(BankAccountsVO _accountVO)
        {
            string _query = "update dbo.bankaccounts set idClient=@idClient, Type = @Type, [Amount of money] = @amount,Date_Created=@dateCreated where idAcc=@idAcc";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@idAcc", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(_accountVO.idAcc);
            sqlParameters[1] = new SqlParameter("@idClient", SqlDbType.Int);
            sqlParameters[1].Value = Convert.ToInt32(_accountVO.idClient);
            sqlParameters[2] = new SqlParameter("@Type", SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(_accountVO.type);
            sqlParameters[3] = new SqlParameter("@amount", SqlDbType.Int);
            sqlParameters[3].Value = Convert.ToInt32(_accountVO.amount);
            sqlParameters[4] = new SqlParameter("@dateCreated", SqlDbType.DateTime);
            sqlParameters[4].Value = Convert.ToDateTime(_accountVO.date);
            return conn.executeUpdateQuery(_query, sqlParameters);
        }
        //Delete Account
        public bool deleteByID(int _id)
        {
            string _query = "delete from dbo.BankAccounts where idAcc = @idAcc";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@idAcc", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(_id);
            return conn.executeDeleteQuery(_query, sqlParameters);
        }
    }
}
