using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankApplication.DataSource;
using BankApplication.DomainLogic.BussinessLogicLayer;
using BankApplication.DomainLogic.ValueObject;
using BankApplication.DomainLogic.DataAccesLayer;
using BankApplication.Presentation;

namespace BankApplication
{
    public partial class LoginWindow : Form
    {
        private LoginBus _loginBUS;
        private BankAccountDAO _accDAO;
        private LoginVO _loginVO;
        public LoginWindow()
        {  
            InitializeComponent();
            _loginBUS = new LoginBus();
            _accDAO = new BankAccountDAO();
            _loginVO = new LoginVO();
        }

        private void login_Click(object sender, EventArgs e)
        {
            this._loginVO = this._loginBUS.getUser(textUser.Text, textPassw.Text);

            if (this._loginVO.type == null)
                MessageBox.Show("Incorrect username or password!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if(this._loginVO.type == "Customer")
               
            {
                //MessageBox.Show(_loginVO.idClient.ToString(), "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    FormClient fc = new FormClient();
                    fc.setId(this._loginVO.idClient);
                    DataGridView dataGrid = fc.getGrid();
                    fc.refreshGrid(this._loginVO.idClient);
                    fc.Show();
            }
            else
            {
                this.Hide();
                FormAdmin fa = new FormAdmin();
                fa.refreshGrid();
                fa.Show();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int getCurrentId()
        {
            return this._loginVO.idClient;
        }
        public LoginBus getCurrentBus()
        {
            return this._loginBUS;
        }
    }
}
