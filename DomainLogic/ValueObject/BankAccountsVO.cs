using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.DomainLogic.ValueObject
{
    public class BankAccountsVO
    {
        private int _idAcc;
        private int _idClient;
        private string _type;
        private int _amountMoney;
        private DateTime _dateCreated;

        //-------------GETTERS-SETTERS
        public int idClient
        {
            get
            {
                return _idClient;
            }
            set
            {
                _idClient = value;
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
                return _amountMoney;
            }
            set
            {
                _amountMoney = value;
            }
        }
        public DateTime date
        {
            get
            {
                return _dateCreated;
            }
            set
            {
                _dateCreated = value;
            }
        }
        
    }
}
