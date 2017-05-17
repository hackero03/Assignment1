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
    public class LoginBus
    {
        private LoginDAO _loginDAO;

        public LoginBus()
        {
            _loginDAO = new LoginDAO();
        }

        //Get idClient by User + Pass and return VO
        public LoginVO getUser(string _username, string _password)
        {
            LoginVO userVO = new LoginVO();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable = _loginDAO.searchByUserPass(_username, _password);
                foreach (DataRow dr in dataTable.Rows)
                {
                    userVO.idUser = Int32.Parse(dr["idUser"].ToString());
                    userVO.idClient = Int32.Parse(dr["idClient"].ToString());
                    userVO.username = dr["Username"].ToString();
                    userVO.password = dr["Password"].ToString();
                    userVO.type = dr["Type"].ToString();
                }
            }
            catch(NullReferenceException e)
            {
                Console.Write("Error:",e.ToString());
                Console.ReadLine();
            }
            
            return userVO;
        }



    }
}
