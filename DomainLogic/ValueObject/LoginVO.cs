using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication.DomainLogic.ValueObject
{
    public class LoginVO
    {
        private int _idUser;
        private int _idClient;
        private string _username;
        private string _password;
        private string _type;
        
        //--------------GETTERS-SETTERS
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

      public int idUser
      {
          get
          {
              return _idUser;
          }
          set
          {
              _idUser = value;
          }
      }

      public string username
      {
          get
          {
              return _username;
          }
          set
          {
              _username = value;
          }
      }

      public string password
      {
          get
          {
              return _password;
          }
          set
          {
              _password = value;
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
    }
}
