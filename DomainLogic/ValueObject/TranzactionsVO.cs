using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.DomainLogic.ValueObject
{
    public class TranzactionsVO
    {
        private int _idTranz;
        private int _idAcc;
        private string _type;
        private int _amount;
        private DateTime _date;

        //-----------GETTERS-SETTERS
        public int idTranz
        {
            get
            {
                return _idTranz;
            }
            set
            {
                _idTranz = value;
            }
        }
        public int idAcc
        {
            get
            {
                return _idAcc;
            }
            set
            {
                _idAcc = value;
            }
        }

        public string type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public int amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }
   
        public DateTime date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
    }
}
