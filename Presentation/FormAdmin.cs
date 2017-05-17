using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using BankApplication.DomainLogic.DataAccesLayer;
using BankApplication.DomainLogic.BussinessLogicLayer;
using BankApplication.DomainLogic.ValueObject;


//pdf
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;


namespace BankApplication.Presentation
{
    public partial class FormAdmin : Form
    {
        private ClientVO _clientVO;
        private ClientDAO _clientDAO;
        private BankAccountDAO _bankAccDAO;
        private TranzactionsDAO _tranzDAO;
        private BankAccountsVO _accountVO;
        private List<TranzactionsVO> _listTranzVO;
        private List<BankAccountsVO> _listBankAccVO;
        private BankAccountsBUS _bankBUS;
        private TranzactionsBUS _tranzBUS;

        public FormAdmin()
        {
            InitializeComponent();
            _clientDAO = new ClientDAO();
            _bankAccDAO = new BankAccountDAO();
            _tranzDAO = new TranzactionsDAO();
            _clientVO = new ClientVO();
            _accountVO = new BankAccountsVO();
            _listTranzVO = new List<TranzactionsVO>();
            _listBankAccVO = new List<BankAccountsVO>();
            _bankBUS = new BankAccountsBUS();
            _tranzBUS = new TranzactionsBUS();
        }
        //Tab Client's Information
        private void buttonClientInfoSubmit_Click(object sender, EventArgs e)
        {
            this.refreshGrid();
            this.ClearPanels();
            if (comboBoxClientInfoOp.Text == "Read" || comboBoxClientInfoOp.Text == "Delete")
            {
                this.panelReadDeleteClientIfo.Visible = true;
                MessageBox.Show("Insert the id to search for!", "Just do it", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.panelReadDeleteClientIfo.Visible = false;
            }
            if (comboBoxClientInfoOp.Text == "Create" || comboBoxClientInfoOp.Text == "Update")
            {
                this.panelInputUpdateClientInfo.Visible = true;
                MessageBox.Show("Insert the informations into the given fields!", "Just do it", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.panelInputUpdateClientInfo.Visible = false;
            }
        }
    

        private void buttonClientInfoCancel_Click(object sender, EventArgs e)
        {
            this.refreshGrid();
            this.ClearPanels();
        }
        //Panel Ins -Update
        private void buttonSubmitInsUpdClInfo_Click(object sender, EventArgs e)
        { 
            _clientVO.name = this.textBoxName.Text;
            _clientVO.cnp = this.textBoxCnp.Text;
            _clientVO.pNumCode = this.textBoxPersCode.Text;
            _clientVO.address = this.textBoxAddress.Text;
            _clientVO.phone = this.textBoxPhone.Text;
            _clientVO.email = this.textBoxEmail.Text;

            if (this.comboBoxClientInfoOp.Text == "Create")
            {
                _clientDAO.insertClient(_clientVO);
                MessageBox.Show("Well done! :D", "Insert Succeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(this.comboBoxClientInfoOp.Text == "Update")
            {
                _clientVO.idClient = Int32.Parse(this.textBoxIdClient.Text);
                _clientDAO.updateByIdClient(_clientVO);
                MessageBox.Show("Well done! :D", "Update Succeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.ClearPanels();
            this.refreshGrid();
        }

        private void buttonClearCInfo_Click(object sender, EventArgs e)
        {
            this.refreshGrid();
        }
        //Panel Read/Delete
        private void buttonSubReadDeleteClient_Click(object sender, EventArgs e)
        {
            if (this.comboBoxClientInfoOp.Text == "Read")
            {
                this.dataGridClientsInfo.DataSource = _clientDAO.searchByID(Int32.Parse(this.textBoxReadDel.Text));
            }
            if (this.comboBoxClientInfoOp.Text == "Delete")
            {
                _clientDAO.deleteByID(Int32.Parse(this.textBoxReadDel.Text));
                this.refreshGrid();
            }
            this.ClearPanels();
            
        }

        private void buttonClearReadDelClient_Click(object sender, EventArgs e)
        {
            this.refreshGrid();
        }
        //Tab Clients' Accounts
        private void buttonSubmitCAcc_Click(object sender, EventArgs e)
        {
            this.refreshGrid();
            this.ClearPanels();
            if (this.comboBoxCAccOp.Text == "Read" || this.comboBoxCAccOp.Text == "Delete")
            {
                this.panelCAccReadDel.Visible = true;
                MessageBox.Show( "Insert the id to search for!","Just do it", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.panelCAccReadDel.Visible = false;
            }
            if (this.comboBoxCAccOp.Text == "Create" || this.comboBoxCAccOp.Text == "Update")
            {
                this.panelCreateUpdateCAcc.Visible = true;
                MessageBox.Show("Insert the informations into the given fields!", "Just do it", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.panelCreateUpdateCAcc.Visible = false;
            }
       }
        

        private void buttonCancelCAcc_Click(object sender, EventArgs e)
        {
            this.refreshGrid();
            this.ClearPanels();
        }
       
        //Panel Insert-Update
        private void buttonSubmCAccInsUpd_Click(object sender, EventArgs e)
        {
           
            _accountVO.idClient = Int32.Parse(this.comboBoxCAccIdClient.Text);
            _accountVO.type = this.comboBoxCAccType.Text;
            _accountVO.amount = Int32.Parse(this.textBoxCAccAmount.Text);
            _accountVO.date = DateTime.Parse(this.dateTimePickerCAcc.Text);

            if (this.comboBoxCAccOp.Text == "Create")
            {
                if (_bankAccDAO.insertAccount(_accountVO))
                {
                    MessageBox.Show("Well done! :D", "Insert Succeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Check Again the fields! :D", "Insert failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            if (this.comboBoxCAccOp.Text == "Update")
            {
                _accountVO.idAcc = Int32.Parse(this.textBoxClientAccIdAcc.Text);
                if(_bankAccDAO.updateAcc(_accountVO))
                {
                    MessageBox.Show("Well done! :D", "Update Succeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                     MessageBox.Show("Check Again the fields! :D", "Update failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
           }
            this.ClearPanels();
            this.refreshGrid();
        }

        private void buttonClearCAccInsUpd_Click(object sender, EventArgs e)
        {
            this.refreshGrid();
        }
        //Panel Read-Delete
        private void buttonSubCAccReadDel_Click(object sender, EventArgs e)
        {
            int _id;
            _id = Int32.Parse(this.textBoxCAccReadDel.Text);
            if (this.comboBoxCAccOp.Text == "Read")
            {

                this.dataGridClientsAcc.DataSource = _bankAccDAO.searchByIdAcc(_id);
            }
            if (this.comboBoxCAccOp.Text == "Delete")
            {
                _bankAccDAO.deleteByID(_id);
                this.refreshGrid();
            }
            this.ClearPanels();
            
        }

        private void buttonClearCAccReadDel_Click(object sender, EventArgs e)
        {
            this.refreshGrid();
        }
       
        //Tab Client's Tranzactions
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
          
            this.ClearPanels();
           
            DateTime _dt = new DateTime();
            DataTable _dataTable = new DataTable();
            int idClient = Int32.Parse(this.comboBoxClientGen.Text);
            _dt = DateTime.Parse(this.dateTimePickerGen.Text);
            _listBankAccVO = _bankBUS.getAccountsByClient(idClient);
            try
            {
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                _dt = DateTime.Parse(dateTimePickerGen.Text);
                
                Paragraph paragraph = new Paragraph("Your account tranzactions: '" + this.comboBoxClientGen.Text + "'!!\n\n");
                doc.Open();
                iTextSharp.text.Font font5 = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 5);
                foreach (BankAccountsVO a in _listBankAccVO)
                {
                    _listTranzVO = _tranzBUS.getTranzByIdAccOnDate(a.idAcc, _dt);
                    _dataTable = _tranzDAO.searchByIdAccAndDate(a.idAcc, _dt);
                    string s = DateTime.Parse(this.dateTimePickerGen.Text).ToString();
                    MessageBox.Show("Your tranzactions after this date: \n" + s);
                    this.dataGridReports.DataSource = _dataTable;
                    PdfPTable pdfTable = new PdfPTable(_dataTable.Columns.Count);

                    if (!doc.IsOpen())
                    {
                        PdfWriter pdfWrite = PdfWriter.GetInstance(doc, new FileStream("ClientTranzactions.pdf", FileMode.Append));
                    }
                    //--------------------PDF - Report
              
                    float[] widths = new float[] { 4f, 4f, 4f, 4f, 4f };
                    pdfTable.SetWidths(widths);
                    pdfTable.WidthPercentage = 60;


                    PdfPCell cell = new PdfPCell(new Phrase("idAcc"));
                    cell.Colspan = _dataTable.Columns.Count;
                    foreach (DataColumn c in _dataTable.Columns)
                    {

                        pdfTable.AddCell(new Phrase(c.ColumnName, font5));
                    }

                    foreach (DataRow r in _dataTable.Rows)
                    {
                        if (_dataTable.Rows.Count > 0)
                        {
                            pdfTable.AddCell(new Phrase(r[0].ToString(), font5));
                            pdfTable.AddCell(new Phrase(r[1].ToString(), font5));
                            pdfTable.AddCell(new Phrase(r[2].ToString(), font5));
                            pdfTable.AddCell(new Phrase(r[3].ToString(), font5));
                            pdfTable.AddCell(new Phrase(r[4].ToString(), font5));
                        }
                    }


                    paragraph.Font.SetFamily("Georgia");
                    paragraph.Font.SetColor(122, 122, 44);
                   
                    doc.Add(paragraph);
                    doc.Add(pdfTable);
                   
                }
                if(doc.IsOpen())
                    doc.Close();
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        private void buttonGenCancel_Click(object sender, EventArgs e)
        {
            this.ClearPanels();
            this.refreshGrid();
        }
       
        //---------------------Getters-Setters

        public System.Windows.Forms.DataGridView getGrid()
        {
            return this.dataGridClientsInfo;
        }
        public void refreshGrid()
        {
            this.dataGridClientsInfo.DataSource = _clientDAO.searchClients();
            this.dataGridClientsAcc.DataSource = _bankAccDAO.DisplayAccounts();
            this.textBoxAddress.Clear();
            this.textBoxCnp.Clear();
            this.textBoxEmail.Clear();
            this.textBoxIdClient.Clear();
            this.textBoxName.Clear();
            this.textBoxPersCode.Clear();
            this.textBoxPhone.Clear();
            this.textBoxReadDel.Clear();
            this.comboBoxCAccIdClient.DataSource = _clientDAO.DisplayIdClients();
            this.comboBoxCAccIdClient.DisplayMember = "idClient";
            this.comboBoxClientGen.DataSource = _clientDAO.DisplayIdClients();
            this.comboBoxClientGen.DisplayMember = "idClient";
        }
        private void ClearPanels()
        {
            this.panelInputUpdateClientInfo.Visible = false;
            this.panelReadDeleteClientIfo.Visible = false;
            this.panelCreateUpdateCAcc.Visible = false;
            this.panelCAccReadDel.Visible = false;
        }

        private void buttonAdminLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginWindow lg = new LoginWindow();
            lg.Show();
        }

        private void buttonClientToo_Click(object sender, EventArgs e)
        {
            LoginWindow lg = new LoginWindow();
            lg.Show();
        }
   
    }
}