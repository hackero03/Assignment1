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
    public class ClientDAO
    {
        private Connection conn;
        private ClientVO _clientVO;
        public ClientDAO()
        {
            conn = new Connection();
            _clientVO = new ClientVO();
        }
        //Search by ID
        public DataTable searchByID(int _id)
        {
            string _query = "select * from dbo.clients where idClient=@idClient";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@idClient", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(_id);
            return conn.executeSelectQuery(_query, sqlParameters);
        }
        //Select all
        public DataTable searchClients()
        {
            string _query = "select * from dbo.clients";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return conn.executeSelectQuery(_query, sqlParameters);
        }
        //Insert
        public bool insertClient(ClientVO _clientVO)
        {
            string _query = "insert into dbo.clients(Name,Cnp,PersNumCode,Address,Phone,Email) values(@name,@cnp,@persnumcode,@address,@phone,@email)";
            SqlParameter[] sqlParameters = new SqlParameter[6];
            sqlParameters[0] = new SqlParameter("@name", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(_clientVO.name);
            sqlParameters[1] = new SqlParameter("@cnp",SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(_clientVO.cnp);
            sqlParameters[2] = new SqlParameter("@persnumcode", SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(_clientVO.pNumCode);
            sqlParameters[3] = new SqlParameter("@address", SqlDbType.VarChar);
            sqlParameters[3].Value = Convert.ToString(_clientVO.address);
            sqlParameters[4] = new SqlParameter("@phone", SqlDbType.VarChar);
            sqlParameters[4].Value = Convert.ToString(_clientVO.phone);
            sqlParameters[5] = new SqlParameter("@email", SqlDbType.VarChar);
            sqlParameters[5].Value = Convert.ToString(_clientVO.email);
            return conn.executeInsertQuery(_query, sqlParameters);
        }
        //Update By Id
        public bool updateByIdClient(ClientVO _clientVO)
        {
            string _query = "update dbo.clients set name = @name, cnp=@cnp, persnumcode = @persnumcode, address = @address,phone = @phone,email = @email  where idClient=@idClient";
            SqlParameter[] sqlParameters = new SqlParameter[7];
            sqlParameters[0] = new SqlParameter("@idClient", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(_clientVO.idClient);
            sqlParameters[1] = new SqlParameter("@name", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(_clientVO.name);
            sqlParameters[2] = new SqlParameter("@cnp", SqlDbType.VarChar);
            sqlParameters[2].Value = Convert.ToString(_clientVO.cnp);
            sqlParameters[3] = new SqlParameter("@persnumcode", SqlDbType.VarChar);
            sqlParameters[3].Value = Convert.ToString(_clientVO.pNumCode);
            sqlParameters[4] = new SqlParameter("@address", SqlDbType.VarChar);
            sqlParameters[4].Value = Convert.ToString(_clientVO.address);
            sqlParameters[5] = new SqlParameter("@phone", SqlDbType.VarChar);
            sqlParameters[5].Value = Convert.ToString(_clientVO.phone);
            sqlParameters[6] = new SqlParameter("@email", SqlDbType.VarChar);
            sqlParameters[6].Value = Convert.ToString(_clientVO.email);
            return conn.executeUpdateQuery(_query, sqlParameters);
        }
        //Delete By Id
        public bool deleteByID(int _id)
        {
            string _query = "delete from dbo.Logins where idClient = @idClient;" +
                " delete from dbo.BankAccounts where idClient = @idClient;" +
                "delete from dbo.Clients where idClient=@idClient;";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@idClient", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToInt32(_id);
            return conn.executeDeleteQuery(_query, sqlParameters);
        }
        //Select the id's
        public DataTable DisplayIdClients()
        {
            string _query = "select idClient from dbo.clients";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return conn.executeSelectQuery(_query, sqlParameters);
        }
    }
}
