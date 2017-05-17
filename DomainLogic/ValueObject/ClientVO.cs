using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.DomainLogic.ValueObject
{
    public class ClientVO
    {
        private int _idClient;
        private string _name;
        private string _cnp;
        private string _address;
        private string _phone;
        private string _pNumCode;
        private string _email;

        //-------GETTERS-SETTERS
        //id
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
        //name
       public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string cnp
        {
            get
            {
                return _cnp;
            }
            set
            {
                _cnp = value;
            }
        }

        public string phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
            }
        }

        public string email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
         public string pNumCode
        {
            get
            {
                return _pNumCode;
            }
            set
            {
                _pNumCode = value;
            }
        }

         public string address
         {
             get
             {
                 return _address;
             }
             set
             {
                 _address = value;
             }
         }
    }
}

