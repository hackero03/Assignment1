using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApplication.DomainLogic.DataAccesLayer;
using BankApplication.DomainLogic.ValueObject;
using System.Data;
using System.Data.SqlClient;

namespace BankApplication.DomainLogic.BussinessLogicLayer
{
    public class ClientBUS
    {
        private ClientDAO _clientDAO;

        public ClientBUS()
        {
            _clientDAO = new ClientDAO();
        }

        public ClientVO getClientById(int _id)
        {
            ClientVO clientVO = new ClientVO();
            DataTable dataTable = new DataTable();

            dataTable = _clientDAO.searchByID(_id);

            foreach (DataRow dr in dataTable.Rows)
            {
                clientVO.name = dr["Name"].ToString();
                clientVO.address = dr["Address"].ToString();
                clientVO.cnp = dr["Cnp"].ToString();
                clientVO.email = dr["Email"].ToString();
                clientVO.phone = dr["Phone"].ToString();
                clientVO.pNumCode = dr["PersNumCode"].ToString();
            }
            return clientVO;
        }
    
    }
}
