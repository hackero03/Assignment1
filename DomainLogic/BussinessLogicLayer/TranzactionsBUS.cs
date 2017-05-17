using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankApplication.DomainLogic.DataAccesLayer;
using BankApplication.DomainLogic.ValueObject;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Media;
namespace BankApplication.DomainLogic.BussinessLogicLayer
{
    public class TranzactionsBUS
    {
        private TranzactionsDAO _tranzDAO;
        List<TranzactionsVO> _listTranzVO;
        public TranzactionsBUS()
        {
            _tranzDAO = new TranzactionsDAO();
            _listTranzVO = new List<TranzactionsVO>();
        }

        public List<TranzactionsVO> getTranzByIdAccOnDate(int _id,DateTime _dt)
        {   
            DataTable dataTable = new DataTable();
            try
            {
                dataTable = _tranzDAO.searchByIdAccAndDate(_id,_dt);
                foreach (DataRow dr in dataTable.Rows)
                {
                    TranzactionsVO _newTranzVo = new TranzactionsVO();
                    _newTranzVo.idAcc = Int32.Parse(dr["idAcc"].ToString());
                    _newTranzVo.type = dr["Type"].ToString();
                    _newTranzVo.amount = Int32.Parse(dr["Amount"].ToString());
                    _newTranzVo.date = DateTime.Parse(dr["DateCreated"].ToString());
                    this._listTranzVO.Add(_newTranzVo);
                }
            }
            catch (NullReferenceException e)
            {
                Console.Write("Error:", e.ToString());
                Console.ReadLine();
            }

            return this._listTranzVO;
        }
        public void ExportListToPDf()
        {
        }
    }
}
