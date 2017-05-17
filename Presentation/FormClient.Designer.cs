namespace BankApplication.Presentation
{
    partial class FormClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.panelTransfer = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDiscardTM = new System.Windows.Forms.Button();
            this.buttonSubmTM = new System.Windows.Forms.Button();
            this.textBoxTMoney = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboTransferDest = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboTransferSrc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelReports = new System.Windows.Forms.Panel();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.dateTimePickerReport = new System.Windows.Forms.DateTimePicker();
            this.buttonRepCancel = new System.Windows.Forms.Button();
            this.buttonRepOk = new System.Windows.Forms.Button();
            this.comboReport = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelPayUitlities = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxPayAmount = new System.Windows.Forms.TextBox();
            this.buttonPayCancel = new System.Windows.Forms.Button();
            this.buttonPay = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.listBoxPay = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboPaySelectAcc = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonMainTM = new System.Windows.Forms.Button();
            this.buttonMainPay = new System.Windows.Forms.Button();
            this.buttonMainReports = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.my_bankDataSet = new BankApplication.my_bankDataSet();
            this.bankAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankAccountsTableAdapter = new BankApplication.my_bankDataSetTableAdapters.BankAccountsTableAdapter();
            this.mybankDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankAccountsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonClientLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelGrid.SuspendLayout();
            this.panelTransfer.SuspendLayout();
            this.panelReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.panelPayUitlities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.my_bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mybankDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 88);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(806, 278);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your accounts:";
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelGrid.Controls.Add(this.dataGridView1);
            this.panelGrid.Controls.Add(this.label1);
            this.panelGrid.Location = new System.Drawing.Point(52, 69);
            this.panelGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(810, 371);
            this.panelGrid.TabIndex = 2;
            // 
            // panelTransfer
            // 
            this.panelTransfer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelTransfer.Controls.Add(this.label12);
            this.panelTransfer.Controls.Add(this.label5);
            this.panelTransfer.Controls.Add(this.buttonDiscardTM);
            this.panelTransfer.Controls.Add(this.buttonSubmTM);
            this.panelTransfer.Controls.Add(this.textBoxTMoney);
            this.panelTransfer.Controls.Add(this.label4);
            this.panelTransfer.Controls.Add(this.comboTransferDest);
            this.panelTransfer.Controls.Add(this.label3);
            this.panelTransfer.Controls.Add(this.comboTransferSrc);
            this.panelTransfer.Controls.Add(this.label2);
            this.panelTransfer.Location = new System.Drawing.Point(52, 69);
            this.panelTransfer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTransfer.Name = "panelTransfer";
            this.panelTransfer.Size = new System.Drawing.Size(844, 386);
            this.panelTransfer.TabIndex = 1;
            this.panelTransfer.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Coral;
            this.label12.Location = new System.Drawing.Point(236, 171);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "-->";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(33, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Transfer Money:";
            // 
            // buttonDiscardTM
            // 
            this.buttonDiscardTM.Location = new System.Drawing.Point(404, 263);
            this.buttonDiscardTM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDiscardTM.Name = "buttonDiscardTM";
            this.buttonDiscardTM.Size = new System.Drawing.Size(112, 35);
            this.buttonDiscardTM.TabIndex = 7;
            this.buttonDiscardTM.Text = "Discard";
            this.buttonDiscardTM.UseVisualStyleBackColor = true;
            this.buttonDiscardTM.Click += new System.EventHandler(this.buttonDiscardTM_Click);
            // 
            // buttonSubmTM
            // 
            this.buttonSubmTM.Location = new System.Drawing.Point(282, 265);
            this.buttonSubmTM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSubmTM.Name = "buttonSubmTM";
            this.buttonSubmTM.Size = new System.Drawing.Size(112, 35);
            this.buttonSubmTM.TabIndex = 6;
            this.buttonSubmTM.Text = "Submit";
            this.buttonSubmTM.UseVisualStyleBackColor = true;
            this.buttonSubmTM.Click += new System.EventHandler(this.buttonSubmTM_Click);
            // 
            // textBoxTMoney
            // 
            this.textBoxTMoney.Location = new System.Drawing.Point(38, 269);
            this.textBoxTMoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTMoney.Name = "textBoxTMoney";
            this.textBoxTMoney.Size = new System.Drawing.Size(148, 26);
            this.textBoxTMoney.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(48, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount:";
            // 
            // comboTransferDest
            // 
            this.comboTransferDest.FormattingEnabled = true;
            this.comboTransferDest.Location = new System.Drawing.Point(282, 166);
            this.comboTransferDest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboTransferDest.Name = "comboTransferDest";
            this.comboTransferDest.Size = new System.Drawing.Size(180, 28);
            this.comboTransferDest.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(278, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choose destination account:";
            // 
            // comboTransferSrc
            // 
            this.comboTransferSrc.FormattingEnabled = true;
            this.comboTransferSrc.Location = new System.Drawing.Point(38, 166);
            this.comboTransferSrc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboTransferSrc.Name = "comboTransferSrc";
            this.comboTransferSrc.Size = new System.Drawing.Size(180, 28);
            this.comboTransferSrc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(33, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose source account:";
            // 
            // panelReports
            // 
            this.panelReports.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelReports.Controls.Add(this.dataGridViewReport);
            this.panelReports.Controls.Add(this.dateTimePickerReport);
            this.panelReports.Controls.Add(this.buttonRepCancel);
            this.panelReports.Controls.Add(this.buttonRepOk);
            this.panelReports.Controls.Add(this.comboReport);
            this.panelReports.Controls.Add(this.label8);
            this.panelReports.Controls.Add(this.label7);
            this.panelReports.Controls.Add(this.label6);
            this.panelReports.Location = new System.Drawing.Point(48, 74);
            this.panelReports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelReports.Name = "panelReports";
            this.panelReports.Size = new System.Drawing.Size(844, 371);
            this.panelReports.TabIndex = 6;
            this.panelReports.Visible = false;
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Location = new System.Drawing.Point(15, 203);
            this.dataGridViewReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.Size = new System.Drawing.Size(770, 149);
            this.dataGridViewReport.TabIndex = 8;
            // 
            // dateTimePickerReport
            // 
            this.dateTimePickerReport.CustomFormat = "MM dd yyyy hh mm ss";
            this.dateTimePickerReport.Location = new System.Drawing.Point(272, 94);
            this.dateTimePickerReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerReport.Name = "dateTimePickerReport";
            this.dateTimePickerReport.Size = new System.Drawing.Size(298, 26);
            this.dateTimePickerReport.TabIndex = 7;
            // 
            // buttonRepCancel
            // 
            this.buttonRepCancel.Location = new System.Drawing.Point(136, 95);
            this.buttonRepCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRepCancel.Name = "buttonRepCancel";
            this.buttonRepCancel.Size = new System.Drawing.Size(112, 35);
            this.buttonRepCancel.TabIndex = 6;
            this.buttonRepCancel.Text = "Cancel";
            this.buttonRepCancel.UseVisualStyleBackColor = true;
            this.buttonRepCancel.Click += new System.EventHandler(this.buttonRepCancel_Click);
            // 
            // buttonRepOk
            // 
            this.buttonRepOk.ForeColor = System.Drawing.Color.Black;
            this.buttonRepOk.Location = new System.Drawing.Point(15, 95);
            this.buttonRepOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRepOk.Name = "buttonRepOk";
            this.buttonRepOk.Size = new System.Drawing.Size(112, 35);
            this.buttonRepOk.TabIndex = 5;
            this.buttonRepOk.Text = "OK";
            this.buttonRepOk.UseVisualStyleBackColor = true;
            this.buttonRepOk.Click += new System.EventHandler(this.buttonRepOk_Click);
            // 
            // comboReport
            // 
            this.comboReport.FormattingEnabled = true;
            this.comboReport.Location = new System.Drawing.Point(592, 91);
            this.comboReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboReport.Name = "comboReport";
            this.comboReport.Size = new System.Drawing.Size(220, 28);
            this.comboReport.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Coral;
            this.label8.Location = new System.Drawing.Point(588, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Select Your Account:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Coral;
            this.label7.Location = new System.Drawing.Point(267, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Pick Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Coral;
            this.label6.Location = new System.Drawing.Point(10, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Generate Reports:";
            // 
            // panelPayUitlities
            // 
            this.panelPayUitlities.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelPayUitlities.Controls.Add(this.label13);
            this.panelPayUitlities.Controls.Add(this.textBoxPayAmount);
            this.panelPayUitlities.Controls.Add(this.buttonPayCancel);
            this.panelPayUitlities.Controls.Add(this.buttonPay);
            this.panelPayUitlities.Controls.Add(this.label11);
            this.panelPayUitlities.Controls.Add(this.listBoxPay);
            this.panelPayUitlities.Controls.Add(this.label10);
            this.panelPayUitlities.Controls.Add(this.comboPaySelectAcc);
            this.panelPayUitlities.Controls.Add(this.label9);
            this.panelPayUitlities.Location = new System.Drawing.Point(48, 74);
            this.panelPayUitlities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelPayUitlities.Name = "panelPayUitlities";
            this.panelPayUitlities.Size = new System.Drawing.Size(826, 371);
            this.panelPayUitlities.TabIndex = 7;
            this.panelPayUitlities.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Coral;
            this.label13.Location = new System.Drawing.Point(36, 265);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "Amount:";
            // 
            // textBoxPayAmount
            // 
            this.textBoxPayAmount.Location = new System.Drawing.Point(40, 305);
            this.textBoxPayAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPayAmount.Name = "textBoxPayAmount";
            this.textBoxPayAmount.Size = new System.Drawing.Size(148, 26);
            this.textBoxPayAmount.TabIndex = 7;
            // 
            // buttonPayCancel
            // 
            this.buttonPayCancel.BackColor = System.Drawing.Color.DimGray;
            this.buttonPayCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPayCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.buttonPayCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonPayCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPayCancel.ForeColor = System.Drawing.Color.Coral;
            this.buttonPayCancel.Location = new System.Drawing.Point(302, 85);
            this.buttonPayCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPayCancel.Name = "buttonPayCancel";
            this.buttonPayCancel.Size = new System.Drawing.Size(112, 35);
            this.buttonPayCancel.TabIndex = 6;
            this.buttonPayCancel.Text = "Cancel";
            this.buttonPayCancel.UseVisualStyleBackColor = false;
            this.buttonPayCancel.Click += new System.EventHandler(this.buttonPayCancel_Click);
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.Color.DimGray;
            this.buttonPay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.buttonPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPay.ForeColor = System.Drawing.Color.Coral;
            this.buttonPay.Location = new System.Drawing.Point(38, 85);
            this.buttonPay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(112, 35);
            this.buttonPay.TabIndex = 5;
            this.buttonPay.Text = "Pay";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Coral;
            this.label11.Location = new System.Drawing.Point(297, 129);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Utilities:";
            // 
            // listBoxPay
            // 
            this.listBoxPay.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxPay.ForeColor = System.Drawing.Color.OrangeRed;
            this.listBoxPay.FormattingEnabled = true;
            this.listBoxPay.ItemHeight = 20;
            this.listBoxPay.Items.AddRange(new object[] {
            "Electrica",
            "E-on Gaz",
            "Orange",
            "CreditBank"});
            this.listBoxPay.Location = new System.Drawing.Point(298, 194);
            this.listBoxPay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxPay.Name = "listBoxPay";
            this.listBoxPay.Size = new System.Drawing.Size(178, 144);
            this.listBoxPay.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Coral;
            this.label10.Location = new System.Drawing.Point(36, 129);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Select Account:";
            // 
            // comboPaySelectAcc
            // 
            this.comboPaySelectAcc.FormattingEnabled = true;
            this.comboPaySelectAcc.Location = new System.Drawing.Point(40, 194);
            this.comboPaySelectAcc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboPaySelectAcc.Name = "comboPaySelectAcc";
            this.comboPaySelectAcc.Size = new System.Drawing.Size(180, 28);
            this.comboPaySelectAcc.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Coral;
            this.label9.Location = new System.Drawing.Point(28, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Pay Utilities:";
            // 
            // buttonMainTM
            // 
            this.buttonMainTM.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMainTM.ForeColor = System.Drawing.Color.Coral;
            this.buttonMainTM.Location = new System.Drawing.Point(208, 18);
            this.buttonMainTM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonMainTM.Name = "buttonMainTM";
            this.buttonMainTM.Size = new System.Drawing.Size(136, 35);
            this.buttonMainTM.TabIndex = 3;
            this.buttonMainTM.Text = "TransferMoney";
            this.buttonMainTM.UseVisualStyleBackColor = false;
            this.buttonMainTM.Click += new System.EventHandler(this.buttonMainTM_Click);
            // 
            // buttonMainPay
            // 
            this.buttonMainPay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMainPay.ForeColor = System.Drawing.Color.Coral;
            this.buttonMainPay.Location = new System.Drawing.Point(354, 18);
            this.buttonMainPay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonMainPay.Name = "buttonMainPay";
            this.buttonMainPay.Size = new System.Drawing.Size(136, 35);
            this.buttonMainPay.TabIndex = 4;
            this.buttonMainPay.Text = "Pay Utilities";
            this.buttonMainPay.UseVisualStyleBackColor = false;
            this.buttonMainPay.Click += new System.EventHandler(this.buttonMainPay_Click);
            // 
            // buttonMainReports
            // 
            this.buttonMainReports.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMainReports.ForeColor = System.Drawing.Color.Coral;
            this.buttonMainReports.Location = new System.Drawing.Point(500, 18);
            this.buttonMainReports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonMainReports.Name = "buttonMainReports";
            this.buttonMainReports.Size = new System.Drawing.Size(136, 35);
            this.buttonMainReports.TabIndex = 5;
            this.buttonMainReports.Text = "Report";
            this.buttonMainReports.UseVisualStyleBackColor = false;
            this.buttonMainReports.Click += new System.EventHandler(this.buttonMainReports_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonHome.ForeColor = System.Drawing.Color.Coral;
            this.buttonHome.Location = new System.Drawing.Point(63, 18);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(136, 35);
            this.buttonHome.TabIndex = 8;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // my_bankDataSet
            // 
            this.my_bankDataSet.DataSetName = "my_bankDataSet";
            this.my_bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankAccountsBindingSource
            // 
            this.bankAccountsBindingSource.DataMember = "BankAccounts";
            this.bankAccountsBindingSource.DataSource = this.my_bankDataSet;
            // 
            // bankAccountsTableAdapter
            // 
            this.bankAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // mybankDataSetBindingSource
            // 
            this.mybankDataSetBindingSource.DataSource = this.my_bankDataSet;
            this.mybankDataSetBindingSource.Position = 0;
            // 
            // bankAccountsBindingSource1
            // 
            this.bankAccountsBindingSource1.DataMember = "BankAccounts";
            this.bankAccountsBindingSource1.DataSource = this.mybankDataSetBindingSource;
            // 
            // buttonClientLogOut
            // 
            this.buttonClientLogOut.BackColor = System.Drawing.Color.DarkRed;
            this.buttonClientLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClientLogOut.ForeColor = System.Drawing.Color.Coral;
            this.buttonClientLogOut.Location = new System.Drawing.Point(819, 24);
            this.buttonClientLogOut.Name = "buttonClientLogOut";
            this.buttonClientLogOut.Size = new System.Drawing.Size(126, 37);
            this.buttonClientLogOut.TabIndex = 9;
            this.buttonClientLogOut.Text = "Log Out";
            this.buttonClientLogOut.UseVisualStyleBackColor = false;
            this.buttonClientLogOut.Click += new System.EventHandler(this.buttonClientLogOut_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankApplication.Properties.Resources.descărcare;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(988, 542);
            this.Controls.Add(this.buttonClientLogOut);
            this.Controls.Add(this.panelPayUitlities);
            this.Controls.Add(this.panelReports);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.panelTransfer);
            this.Controls.Add(this.buttonMainReports);
            this.Controls.Add(this.buttonMainPay);
            this.Controls.Add(this.buttonMainTM);
            this.Controls.Add(this.panelGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.Load += new System.EventHandler(this.FormClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelGrid.ResumeLayout(false);
            this.panelGrid.PerformLayout();
            this.panelTransfer.ResumeLayout(false);
            this.panelTransfer.PerformLayout();
            this.panelReports.ResumeLayout(false);
            this.panelReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.panelPayUitlities.ResumeLayout(false);
            this.panelPayUitlities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.my_bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mybankDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Panel panelTransfer;
        private System.Windows.Forms.Button buttonDiscardTM;
        private System.Windows.Forms.Button buttonSubmTM;
        private System.Windows.Forms.TextBox textBoxTMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboTransferDest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboTransferSrc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonMainTM;
        private System.Windows.Forms.Button buttonMainPay;
        private System.Windows.Forms.Button buttonMainReports;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelReports;
        private System.Windows.Forms.Button buttonRepCancel;
        private System.Windows.Forms.Button buttonRepOk;
        private System.Windows.Forms.ComboBox comboReport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelPayUitlities;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listBoxPay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboPaySelectAcc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonPayCancel;

      
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Label label12;
        private my_bankDataSet my_bankDataSet;
        private System.Windows.Forms.BindingSource bankAccountsBindingSource;
        private my_bankDataSetTableAdapters.BankAccountsTableAdapter bankAccountsTableAdapter;
        private System.Windows.Forms.BindingSource bankAccountsBindingSource1;
        private System.Windows.Forms.BindingSource mybankDataSetBindingSource;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxPayAmount;
        private System.Windows.Forms.DateTimePicker dateTimePickerReport;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.Button buttonClientLogOut;
    }
}