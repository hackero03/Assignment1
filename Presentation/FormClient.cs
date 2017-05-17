using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankApplication.DomainLogic.DataAccesLayer;
using BankApplication.DomainLogic.BussinessLogicLayer;
using BankApplication.DomainLogic.ValueObject;
using System.Web;
using System.Web.WebSockets;
using System.Web.UI;

//pdf
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using System.Web.UI.WebControls;

namespace BankApplication.Presentation
{
    public partial class FormClient : Form
    {
        //Fields
        private int id;
        private BankAccountsBUS _bankAccBus;
        private List<BankAccountsVO> _listBankAccVO;
        private BankAccountDAO _bankAccDAO;
        private BankAccountsVO _bankAccVO;
        private TranzactionsDAO _tranzDAO;
        private List<TranzactionsVO> _listTranzVO;
        private TranzactionsVO _tranzVO;
        private TranzactionsBUS _tranzBUS;

        //Constructor
        public FormClient()
        {
            InitializeComponent();
            _bankAccBus = new BankAccountsBUS();
            _listBankAccVO = new List<BankAccountsVO>();
            _bankAccDAO = new BankAccountDAO();
            _bankAccVO = new BankAccountsVO();
            _tranzDAO = new TranzactionsDAO();
            _tranzVO = new TranzactionsVO();
            _listTranzVO = new List<TranzactionsVO>();
            _tranzBUS = new TranzactionsBUS();
        }
        private void turnPanelsOff()
        {
            this.panelGrid.Visible = false;
            this.panelPayUitlities.Visible = false;
            this.panelReports.Visible = false;
            this.panelTransfer.Visible = false;
        }
        private void FormClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'my_bankDataSet.BankAccounts' table. You can move, or remove it, as needed.
        }

        //---------------------------MainFrameButtons
        //---------------------------TransferMoney Panel
        private void buttonMainTM_Click(object sender, EventArgs e)
        {
            this.turnPanelsOff();
            this.panelTransfer.Visible = true;

            //comboTransferSrc.Items.Clear();
            comboTransferSrc.DataSource = _bankAccBus.getAccountsByClient(this.id);
            comboTransferSrc.DisplayMember = "idAcc";

            //comboTransferDest.Items.Clear();
            comboTransferDest.DataSource = _bankAccBus.getAccountsByClient(this.id);
            comboTransferDest.DisplayMember = "idAcc";

        }

        //----------------------------Pay Panel
        private void buttonMainPay_Click(object sender, EventArgs e)
        {
            this.turnPanelsOff();
            this.panelPayUitlities.Visible = true;

            comboPaySelectAcc.DataSource = _bankAccBus.getAccountsByClient(this.id);
            comboPaySelectAcc.DisplayMember = "idAcc";
        }

        //-----------------------------Report Panel
        private void buttonMainReports_Click(object sender, EventArgs e)
        {
            this.turnPanelsOff();
            this.panelReports.Visible = true;

            comboReport.DataSource = _bankAccBus.getAccountsByClient(this.id);
            comboReport.DisplayMember = "idAcc";
        }

        //----------------------------Home Panel
        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.turnPanelsOff();
            this.panelGrid.Visible = true;

            this.refreshGrid(this.id);
        }

        //------------------------ReportPanel
        private void buttonRepOk_Click(object sender, EventArgs e)
        {
            DateTime _dt = new DateTime();
            DataTable _dataTable = new DataTable();
            int idAcc = Int32.Parse(comboReport.Text);
            try
            {
                _dt = DateTime.Parse(dateTimePickerReport.Text);
                _listTranzVO = _tranzBUS.getTranzByIdAccOnDate(idAcc, _dt);
                _dataTable = _tranzDAO.searchByIdAccAndDate(idAcc, _dt);
                string s = DateTime.Parse(dateTimePickerReport.Text).ToString();
                MessageBox.Show("Your tranzactions after this date: \n" + s);
                this.dataGridViewReport.DataSource = _dataTable;

                //--------------------PDF - Report
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter pdfWrite = PdfWriter.GetInstance(doc, new FileStream("Tranzactions.pdf", FileMode.Create));
                Paragraph paragraph = new Paragraph("Your account tranzactions: !!\n\n");
                PdfPTable pdfTable = new PdfPTable(_dataTable.Columns.Count);
                doc.Open();
                iTextSharp.text.Font font5 = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 5);

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
                doc.Close();
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonRepCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            this.panelReports.Visible = false;
            dr = MessageBox.Show("Are you sure you want to quit?", ":D", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                this.panelReports.Visible = true;

        }

        //------------------------PaytPanel
        private void buttonPayCancel_Click(object sender, EventArgs e)
        {

            DialogResult dr = new DialogResult();
            this.panelPayUitlities.Visible = false;
            dr = MessageBox.Show("Are you sure you want to quit?", ":D", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                this.panelPayUitlities.Visible = true;

        }
        private void buttonPay_Click(object sender, EventArgs e)
        {
            int idSrc = Int32.Parse(this.comboPaySelectAcc.Text);
            int inputAmount = Int32.Parse(textBoxPayAmount.Text);
            _bankAccVO = this._bankAccBus.getAccountInfo(idSrc);
            int srcAmount = _bankAccVO.amount;
            if (srcAmount >= inputAmount) 
            { 
                srcAmount -= inputAmount;
                DialogResult dr = new DialogResult();
                DateTime _dt = System.DateTime.Now;

                dr = MessageBox.Show("Are you sure you want to proceed?", "Payment Incomming!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (this.listBoxPay.SelectedItem != null)
                {
                    if (dr == DialogResult.Yes)
                    {
                        if (_bankAccDAO.updateByIdTransfer(idSrc, srcAmount))
                        {
                            MessageBox.Show("Payment Succeeded!", "Well Done!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Payment Aborted!", "Value has not changed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (_tranzDAO.insertByIdAcc(idSrc,this.listBoxPay.Text, inputAmount, _dt))
                    {
                        MessageBox.Show("Tranzaction Added!", "Well Done!");
                    }
                    else
                    {
                        MessageBox.Show("Tranzaction aborted!", "Tranzaction failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Select an utility darling!", "Payment Aborted!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Not enough money!", "Payment Aborted!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        //------------------------TransferMoneyPanel
        private void buttonSubmTM_Click(object sender, EventArgs e)
        {
            DateTime _dt = System.DateTime.Now;
            int idSrc = Int32.Parse(this.comboTransferSrc.Text);
            int idDst = Int32.Parse(this.comboTransferDest.Text);
            int inputAmount = Int32.Parse(textBoxTMoney.Text);
            //Reading Account's money stored of the source and the destination account
            _bankAccVO = this._bankAccBus.getAccountInfo(idSrc);
            int srcAmount = _bankAccVO.amount;
            _bankAccVO = this._bankAccBus.getAccountInfo(idDst);
            int dstAmount = _bankAccVO.amount;
            //Update of account's money stored
            if (srcAmount >= inputAmount)
            {
                srcAmount -= inputAmount;
                dstAmount += inputAmount;

                if (idSrc != idDst)
                {
                    if (_bankAccDAO.updateByIdTransfer(idSrc, srcAmount) && _bankAccDAO.updateByIdTransfer(idDst, dstAmount))
                    {
                        MessageBox.Show(inputAmount.ToString(), "Update Succeded!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Update failed!", "Value has not changed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (_tranzDAO.insertByIdAcc(idSrc, "Withdraw", inputAmount, _dt) && _tranzDAO.insertByIdAcc(idDst, "Deposit", inputAmount, _dt))
                    {
                        MessageBox.Show("Tranzaction Added!", "Well Done!");
                    }
                    else
                    {
                        MessageBox.Show("Tranzaction aborted!", "Tranzaction failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong destination account!", "Value has not changed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }else
            {
                MessageBox.Show("Not enough money!", "Transfer failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonDiscardTM_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            this.panelTransfer.Visible = false;
            dr = MessageBox.Show("Are you sure you want to quit?", ":D", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                this.panelTransfer.Visible = true;
        }

        //---------------------Getters-Setters
        public void setId(int id)
        {
            this.id = id;
        }
        public System.Windows.Forms.DataGridView getGrid()
        {
            return this.dataGridView1;
        }
        public void refreshGrid(int id)
        {
            this.dataGridView1.DataSource = _bankAccDAO.searchByIDClient(id);
        }

        private void buttonClientLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginWindow lg = new LoginWindow();
            lg.Show();
        }


    }
}
