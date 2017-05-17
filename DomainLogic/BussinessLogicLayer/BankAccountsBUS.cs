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
    public class BankAccountsBUS
    {
        private BankAccountDAO _accountDAO;

        public BankAccountsBUS()
        {
            _accountDAO = new BankAccountDAO();
        }

        public List<BankAccountsVO> getAccountsByClient(int _id)
        {
            List<BankAccountsVO> accountsVO = new List<BankAccountsVO>();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable = _accountDAO.searchByIDClient(_id);
                foreach (DataRow dr in dataTable.Rows)
                {   
                    BankAccountsVO _newBankAccVo = new BankAccountsVO();
                    _newBankAccVo.idAcc = Int32.Parse(dr["idAcc"].ToString());
                    _newBankAccVo.idClient =Int32.Parse(dr["idClient"].ToString());
                    _newBankAccVo.type = dr["Type"].ToString();
                    _newBankAccVo.amount = Int32.Parse(dr["Amount of money"].ToString());
                    _newBankAccVo.date = DateTime.Parse(dr["Date_Created"].ToString());
                    accountsVO.Add(_newBankAccVo);
                }
            }
            catch (NullReferenceException e)
            {
                Console.Write("Error:", e.ToString());
                Console.ReadLine();
            }

            return accountsVO;
        }

        public BankAccountsVO getAccountInfo(int _id)
        {
            BankAccountsVO _newBankAccVo = new BankAccountsVO();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable = _accountDAO.searchByIdAcc(_id);
                foreach (DataRow dr in dataTable.Rows)
                {
                    _newBankAccVo.idAcc = Int32.Parse(dr["idAcc"].ToString());
                    _newBankAccVo.idClient = Int32.Parse(dr["idClient"].ToString());
                    _newBankAccVo.type = dr["Type"].ToString();
                    _newBankAccVo.amount = Int32.Parse(dr["Amount of money"].ToString());
                    _newBankAccVo.date = DateTime.Parse(dr["Date_Created"].ToString());
                   
                }
            }
            catch (NullReferenceException e)
            {
                Console.Write("Error:", e.ToString());
                Console.ReadLine();
            }

            return _newBankAccVo;
        }
    }
}
