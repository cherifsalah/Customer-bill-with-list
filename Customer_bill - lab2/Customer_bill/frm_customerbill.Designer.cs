namespace Customer_bill
{
    partial class frm_customerbill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_customerbill));
            this.lblkwh_residential = new System.Windows.Forms.Label();
            this.txtresidential_kwh = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.grp_residential = new System.Windows.Forms.GroupBox();
            this.lbl_amount_Residential = new System.Windows.Forms.Label();
            this.txt_amount_residential = new System.Windows.Forms.TextBox();
            this.grp_industrial = new System.Windows.Forms.GroupBox();
            this.lbl_amount_industrial = new System.Windows.Forms.Label();
            this.txt_amount_industrial = new System.Windows.Forms.TextBox();
            this.lbl_offpeak_hours_amount = new System.Windows.Forms.Label();
            this.lbl_peakhours_amount = new System.Windows.Forms.Label();
            this.txt_Offpeakhours_amount = new System.Windows.Forms.TextBox();
            this.txt_offpeakhourskwh = new System.Windows.Forms.TextBox();
            this.lbl_offpeakhourskwh = new System.Windows.Forms.Label();
            this.txt_peakhours_amount = new System.Windows.Forms.TextBox();
            this.txt_peakhourskwh = new System.Windows.Forms.TextBox();
            this.lblPeakhours_kwh = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.tab_customer = new System.Windows.Forms.TabControl();
            this.tab_residential = new System.Windows.Forms.TabPage();
            this.tab_commercial = new System.Windows.Forms.TabPage();
            this.grpcomercial = new System.Windows.Forms.GroupBox();
            this.lbl_commercial_amount = new System.Windows.Forms.Label();
            this.txt_amount_commercial = new System.Windows.Forms.TextBox();
            this.txt_commercial_kwh = new System.Windows.Forms.TextBox();
            this.lblcommercial_kwh = new System.Windows.Forms.Label();
            this.tab_industrial = new System.Windows.Forms.TabPage();
            this.picbxlogo = new System.Windows.Forms.PictureBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.grpboxaddaccount = new System.Windows.Forms.GroupBox();
            this.CmbCustType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCustname = new System.Windows.Forms.TextBox();
            this.lblCustomername = new System.Windows.Forms.Label();
            this.txtCustnumber = new System.Windows.Forms.TextBox();
            this.lblCustNum = new System.Windows.Forms.Label();
            this.grplistCust = new System.Windows.Forms.GroupBox();
            this.lstboxCustomer = new System.Windows.Forms.ListBox();
            this.grpbxStatistic = new System.Windows.Forms.GroupBox();
            this.lbltotsum = new System.Windows.Forms.Label();
            this.lblsumInd = new System.Windows.Forms.Label();
            this.lblsumcom = new System.Windows.Forms.Label();
            this.lblsumchargeres = new System.Windows.Forms.Label();
            this.lblnbrcust = new System.Windows.Forms.Label();
            this.txtsumofallcharges = new System.Windows.Forms.TextBox();
            this.txtsumofchargeIndust = new System.Windows.Forms.TextBox();
            this.txtsumofchargeCom = new System.Windows.Forms.TextBox();
            this.txtsumofchargeRes = new System.Windows.Forms.TextBox();
            this.txtTotNumCust = new System.Windows.Forms.TextBox();
            this.grp_residential.SuspendLayout();
            this.grp_industrial.SuspendLayout();
            this.tab_customer.SuspendLayout();
            this.tab_residential.SuspendLayout();
            this.tab_commercial.SuspendLayout();
            this.grpcomercial.SuspendLayout();
            this.tab_industrial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbxlogo)).BeginInit();
            this.grpboxaddaccount.SuspendLayout();
            this.grplistCust.SuspendLayout();
            this.grpbxStatistic.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblkwh_residential
            // 
            this.lblkwh_residential.AutoSize = true;
            this.lblkwh_residential.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkwh_residential.Location = new System.Drawing.Point(14, 44);
            this.lblkwh_residential.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblkwh_residential.Name = "lblkwh_residential";
            this.lblkwh_residential.Size = new System.Drawing.Size(168, 25);
            this.lblkwh_residential.TabIndex = 0;
            this.lblkwh_residential.Text = "KWH consumed";
            // 
            // txtresidential_kwh
            // 
            this.txtresidential_kwh.Location = new System.Drawing.Point(207, 41);
            this.txtresidential_kwh.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtresidential_kwh.Name = "txtresidential_kwh";
            this.txtresidential_kwh.Size = new System.Drawing.Size(136, 32);
            this.txtresidential_kwh.TabIndex = 0;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(293, 601);
            this.btncalculate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(140, 38);
            this.btncalculate.TabIndex = 3;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // grp_residential
            // 
            this.grp_residential.Controls.Add(this.lbl_amount_Residential);
            this.grp_residential.Controls.Add(this.txt_amount_residential);
            this.grp_residential.Controls.Add(this.txtresidential_kwh);
            this.grp_residential.Controls.Add(this.lblkwh_residential);
            this.grp_residential.Location = new System.Drawing.Point(5, 25);
            this.grp_residential.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grp_residential.Name = "grp_residential";
            this.grp_residential.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grp_residential.Size = new System.Drawing.Size(655, 142);
            this.grp_residential.TabIndex = 0;
            this.grp_residential.TabStop = false;
            // 
            // lbl_amount_Residential
            // 
            this.lbl_amount_Residential.AutoSize = true;
            this.lbl_amount_Residential.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount_Residential.Location = new System.Drawing.Point(383, 43);
            this.lbl_amount_Residential.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_amount_Residential.Name = "lbl_amount_Residential";
            this.lbl_amount_Residential.Size = new System.Drawing.Size(86, 25);
            this.lbl_amount_Residential.TabIndex = 1;
            this.lbl_amount_Residential.Text = "Amount";
            // 
            // txt_amount_residential
            // 
            this.txt_amount_residential.Location = new System.Drawing.Point(498, 40);
            this.txt_amount_residential.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_amount_residential.Name = "txt_amount_residential";
            this.txt_amount_residential.ReadOnly = true;
            this.txt_amount_residential.Size = new System.Drawing.Size(136, 32);
            this.txt_amount_residential.TabIndex = 1;
            // 
            // grp_industrial
            // 
            this.grp_industrial.Controls.Add(this.lbl_amount_industrial);
            this.grp_industrial.Controls.Add(this.txt_amount_industrial);
            this.grp_industrial.Controls.Add(this.lbl_offpeak_hours_amount);
            this.grp_industrial.Controls.Add(this.lbl_peakhours_amount);
            this.grp_industrial.Controls.Add(this.txt_Offpeakhours_amount);
            this.grp_industrial.Controls.Add(this.txt_offpeakhourskwh);
            this.grp_industrial.Controls.Add(this.lbl_offpeakhourskwh);
            this.grp_industrial.Controls.Add(this.txt_peakhours_amount);
            this.grp_industrial.Controls.Add(this.txt_peakhourskwh);
            this.grp_industrial.Controls.Add(this.lblPeakhours_kwh);
            this.grp_industrial.Location = new System.Drawing.Point(5, 4);
            this.grp_industrial.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grp_industrial.Name = "grp_industrial";
            this.grp_industrial.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grp_industrial.Size = new System.Drawing.Size(879, 196);
            this.grp_industrial.TabIndex = 5;
            this.grp_industrial.TabStop = false;
            // 
            // lbl_amount_industrial
            // 
            this.lbl_amount_industrial.AutoSize = true;
            this.lbl_amount_industrial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount_industrial.Location = new System.Drawing.Point(441, 142);
            this.lbl_amount_industrial.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_amount_industrial.Name = "lbl_amount_industrial";
            this.lbl_amount_industrial.Size = new System.Drawing.Size(133, 25);
            this.lbl_amount_industrial.TabIndex = 12;
            this.lbl_amount_industrial.Text = "total Amount";
            // 
            // txt_amount_industrial
            // 
            this.txt_amount_industrial.Location = new System.Drawing.Point(719, 139);
            this.txt_amount_industrial.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_amount_industrial.Name = "txt_amount_industrial";
            this.txt_amount_industrial.ReadOnly = true;
            this.txt_amount_industrial.Size = new System.Drawing.Size(136, 32);
            this.txt_amount_industrial.TabIndex = 5;
            // 
            // lbl_offpeak_hours_amount
            // 
            this.lbl_offpeak_hours_amount.AutoSize = true;
            this.lbl_offpeak_hours_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_offpeak_hours_amount.Location = new System.Drawing.Point(441, 86);
            this.lbl_offpeak_hours_amount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_offpeak_hours_amount.Name = "lbl_offpeak_hours_amount";
            this.lbl_offpeak_hours_amount.Size = new System.Drawing.Size(236, 25);
            this.lbl_offpeak_hours_amount.TabIndex = 10;
            this.lbl_offpeak_hours_amount.Text = "Off Peak Hours amount";
            // 
            // lbl_peakhours_amount
            // 
            this.lbl_peakhours_amount.AutoSize = true;
            this.lbl_peakhours_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_peakhours_amount.Location = new System.Drawing.Point(441, 40);
            this.lbl_peakhours_amount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_peakhours_amount.Name = "lbl_peakhours_amount";
            this.lbl_peakhours_amount.Size = new System.Drawing.Size(201, 25);
            this.lbl_peakhours_amount.TabIndex = 9;
            this.lbl_peakhours_amount.Text = "Peak Hours amount";
            // 
            // txt_Offpeakhours_amount
            // 
            this.txt_Offpeakhours_amount.Location = new System.Drawing.Point(719, 83);
            this.txt_Offpeakhours_amount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_Offpeakhours_amount.Name = "txt_Offpeakhours_amount";
            this.txt_Offpeakhours_amount.ReadOnly = true;
            this.txt_Offpeakhours_amount.Size = new System.Drawing.Size(136, 32);
            this.txt_Offpeakhours_amount.TabIndex = 4;
            // 
            // txt_offpeakhourskwh
            // 
            this.txt_offpeakhourskwh.Location = new System.Drawing.Point(270, 83);
            this.txt_offpeakhourskwh.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_offpeakhourskwh.Name = "txt_offpeakhourskwh";
            this.txt_offpeakhourskwh.Size = new System.Drawing.Size(136, 32);
            this.txt_offpeakhourskwh.TabIndex = 2;
            // 
            // lbl_offpeakhourskwh
            // 
            this.lbl_offpeakhourskwh.AutoSize = true;
            this.lbl_offpeakhourskwh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_offpeakhourskwh.Location = new System.Drawing.Point(14, 86);
            this.lbl_offpeakhourskwh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_offpeakhourskwh.Name = "lbl_offpeakhourskwh";
            this.lbl_offpeakhourskwh.Size = new System.Drawing.Size(222, 25);
            this.lbl_offpeakhourskwh.TabIndex = 5;
            this.lbl_offpeakhourskwh.Text = "Off Peak Hours KWH ";
            // 
            // txt_peakhours_amount
            // 
            this.txt_peakhours_amount.Location = new System.Drawing.Point(719, 37);
            this.txt_peakhours_amount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_peakhours_amount.Name = "txt_peakhours_amount";
            this.txt_peakhours_amount.ReadOnly = true;
            this.txt_peakhours_amount.Size = new System.Drawing.Size(136, 32);
            this.txt_peakhours_amount.TabIndex = 3;
            // 
            // txt_peakhourskwh
            // 
            this.txt_peakhourskwh.Location = new System.Drawing.Point(270, 37);
            this.txt_peakhourskwh.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_peakhourskwh.Name = "txt_peakhourskwh";
            this.txt_peakhourskwh.Size = new System.Drawing.Size(136, 32);
            this.txt_peakhourskwh.TabIndex = 1;
            // 
            // lblPeakhours_kwh
            // 
            this.lblPeakhours_kwh.AutoSize = true;
            this.lblPeakhours_kwh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeakhours_kwh.Location = new System.Drawing.Point(14, 40);
            this.lblPeakhours_kwh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPeakhours_kwh.Name = "lblPeakhours_kwh";
            this.lblPeakhours_kwh.Size = new System.Drawing.Size(187, 25);
            this.lblPeakhours_kwh.TabIndex = 0;
            this.lblPeakhours_kwh.Text = "Peak Hours KWH ";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(471, 601);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(140, 39);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(652, 601);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(140, 40);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // tab_customer
            // 
            this.tab_customer.Controls.Add(this.tab_residential);
            this.tab_customer.Controls.Add(this.tab_commercial);
            this.tab_customer.Controls.Add(this.tab_industrial);
            this.tab_customer.Location = new System.Drawing.Point(14, 342);
            this.tab_customer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tab_customer.Name = "tab_customer";
            this.tab_customer.SelectedIndex = 0;
            this.tab_customer.Size = new System.Drawing.Size(913, 251);
            this.tab_customer.TabIndex = 2;
            this.tab_customer.SelectedIndexChanged += new System.EventHandler(this.tab_customer_SelectedIndexChanged);
            // 
            // tab_residential
            // 
            this.tab_residential.Controls.Add(this.grp_residential);
            this.tab_residential.Location = new System.Drawing.Point(4, 35);
            this.tab_residential.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tab_residential.Name = "tab_residential";
            this.tab_residential.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tab_residential.Size = new System.Drawing.Size(905, 212);
            this.tab_residential.TabIndex = 0;
            this.tab_residential.Text = "Residential";
            this.tab_residential.UseVisualStyleBackColor = true;
            // 
            // tab_commercial
            // 
            this.tab_commercial.Controls.Add(this.grpcomercial);
            this.tab_commercial.Location = new System.Drawing.Point(4, 35);
            this.tab_commercial.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tab_commercial.Name = "tab_commercial";
            this.tab_commercial.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tab_commercial.Size = new System.Drawing.Size(905, 212);
            this.tab_commercial.TabIndex = 1;
            this.tab_commercial.Text = "Commercial";
            this.tab_commercial.UseVisualStyleBackColor = true;
            // 
            // grpcomercial
            // 
            this.grpcomercial.Controls.Add(this.lbl_commercial_amount);
            this.grpcomercial.Controls.Add(this.txt_amount_commercial);
            this.grpcomercial.Controls.Add(this.txt_commercial_kwh);
            this.grpcomercial.Controls.Add(this.lblcommercial_kwh);
            this.grpcomercial.Location = new System.Drawing.Point(5, 23);
            this.grpcomercial.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grpcomercial.Name = "grpcomercial";
            this.grpcomercial.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grpcomercial.Size = new System.Drawing.Size(644, 162);
            this.grpcomercial.TabIndex = 0;
            this.grpcomercial.TabStop = false;
            // 
            // lbl_commercial_amount
            // 
            this.lbl_commercial_amount.AutoSize = true;
            this.lbl_commercial_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_commercial_amount.Location = new System.Drawing.Point(381, 41);
            this.lbl_commercial_amount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_commercial_amount.Name = "lbl_commercial_amount";
            this.lbl_commercial_amount.Size = new System.Drawing.Size(86, 25);
            this.lbl_commercial_amount.TabIndex = 0;
            this.lbl_commercial_amount.Text = "Amount";
            // 
            // txt_amount_commercial
            // 
            this.txt_amount_commercial.Location = new System.Drawing.Point(494, 41);
            this.txt_amount_commercial.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_amount_commercial.Name = "txt_amount_commercial";
            this.txt_amount_commercial.ReadOnly = true;
            this.txt_amount_commercial.Size = new System.Drawing.Size(136, 32);
            this.txt_amount_commercial.TabIndex = 2;
            // 
            // txt_commercial_kwh
            // 
            this.txt_commercial_kwh.Location = new System.Drawing.Point(207, 41);
            this.txt_commercial_kwh.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_commercial_kwh.Name = "txt_commercial_kwh";
            this.txt_commercial_kwh.Size = new System.Drawing.Size(136, 32);
            this.txt_commercial_kwh.TabIndex = 1;
            // 
            // lblcommercial_kwh
            // 
            this.lblcommercial_kwh.AutoSize = true;
            this.lblcommercial_kwh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcommercial_kwh.Location = new System.Drawing.Point(14, 44);
            this.lblcommercial_kwh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblcommercial_kwh.Name = "lblcommercial_kwh";
            this.lblcommercial_kwh.Size = new System.Drawing.Size(168, 25);
            this.lblcommercial_kwh.TabIndex = 0;
            this.lblcommercial_kwh.Text = "KWH consumed";
            // 
            // tab_industrial
            // 
            this.tab_industrial.Controls.Add(this.grp_industrial);
            this.tab_industrial.Location = new System.Drawing.Point(4, 35);
            this.tab_industrial.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tab_industrial.Name = "tab_industrial";
            this.tab_industrial.Size = new System.Drawing.Size(905, 212);
            this.tab_industrial.TabIndex = 2;
            this.tab_industrial.Text = "Industrial";
            this.tab_industrial.UseVisualStyleBackColor = true;
            // 
            // picbxlogo
            // 
            this.picbxlogo.Image = ((System.Drawing.Image)(resources.GetObject("picbxlogo.Image")));
            this.picbxlogo.Location = new System.Drawing.Point(100, 18);
            this.picbxlogo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.picbxlogo.Name = "picbxlogo";
            this.picbxlogo.Size = new System.Drawing.Size(300, 100);
            this.picbxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxlogo.TabIndex = 14;
            this.picbxlogo.TabStop = false;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(515, 52);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(298, 32);
            this.lbltitle.TabIndex = 15;
            this.lbltitle.Text = "Enmax Customer Bill";
            // 
            // grpboxaddaccount
            // 
            this.grpboxaddaccount.Controls.Add(this.CmbCustType);
            this.grpboxaddaccount.Controls.Add(this.btnAdd);
            this.grpboxaddaccount.Controls.Add(this.txtCustname);
            this.grpboxaddaccount.Controls.Add(this.lblCustomername);
            this.grpboxaddaccount.Controls.Add(this.txtCustnumber);
            this.grpboxaddaccount.Controls.Add(this.lblCustNum);
            this.grpboxaddaccount.Location = new System.Drawing.Point(14, 125);
            this.grpboxaddaccount.Name = "grpboxaddaccount";
            this.grpboxaddaccount.Size = new System.Drawing.Size(478, 189);
            this.grpboxaddaccount.TabIndex = 0;
            this.grpboxaddaccount.TabStop = false;
            // 
            // CmbCustType
            // 
            this.CmbCustType.FormattingEnabled = true;
            this.CmbCustType.Items.AddRange(new object[] {
            "Residential",
            "Commercial",
            "Industrial"});
            this.CmbCustType.Location = new System.Drawing.Point(338, 28);
            this.CmbCustType.Name = "CmbCustType";
            this.CmbCustType.Size = new System.Drawing.Size(114, 34);
            this.CmbCustType.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(312, 130);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 38);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCustname
            // 
            this.txtCustname.Location = new System.Drawing.Point(194, 75);
            this.txtCustname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCustname.Name = "txtCustname";
            this.txtCustname.Size = new System.Drawing.Size(136, 32);
            this.txtCustname.TabIndex = 2;
            // 
            // lblCustomername
            // 
            this.lblCustomername.AutoSize = true;
            this.lblCustomername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomername.Location = new System.Drawing.Point(8, 75);
            this.lblCustomername.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCustomername.Name = "lblCustomername";
            this.lblCustomername.Size = new System.Drawing.Size(167, 25);
            this.lblCustomername.TabIndex = 15;
            this.lblCustomername.Text = "Customer Name";
            // 
            // txtCustnumber
            // 
            this.txtCustnumber.Location = new System.Drawing.Point(194, 29);
            this.txtCustnumber.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCustnumber.Name = "txtCustnumber";
            this.txtCustnumber.Size = new System.Drawing.Size(136, 32);
            this.txtCustnumber.TabIndex = 1;
            // 
            // lblCustNum
            // 
            this.lblCustNum.AutoSize = true;
            this.lblCustNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustNum.Location = new System.Drawing.Point(8, 28);
            this.lblCustNum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCustNum.Name = "lblCustNum";
            this.lblCustNum.Size = new System.Drawing.Size(186, 25);
            this.lblCustNum.TabIndex = 13;
            this.lblCustNum.Text = "Customer Number";
            // 
            // grplistCust
            // 
            this.grplistCust.Controls.Add(this.lstboxCustomer);
            this.grplistCust.Location = new System.Drawing.Point(512, 125);
            this.grplistCust.Name = "grplistCust";
            this.grplistCust.Size = new System.Drawing.Size(767, 233);
            this.grplistCust.TabIndex = 1;
            this.grplistCust.TabStop = false;
            this.grplistCust.Text = "List of Customers";
            // 
            // lstboxCustomer
            // 
            this.lstboxCustomer.FormattingEnabled = true;
            this.lstboxCustomer.ItemHeight = 26;
            this.lstboxCustomer.Location = new System.Drawing.Point(9, 31);
            this.lstboxCustomer.Name = "lstboxCustomer";
            this.lstboxCustomer.Size = new System.Drawing.Size(731, 186);
            this.lstboxCustomer.TabIndex = 0;
            this.lstboxCustomer.SelectedIndexChanged += new System.EventHandler(this.lstboxCustomer_SelectedIndexChanged);
            // 
            // grpbxStatistic
            // 
            this.grpbxStatistic.Controls.Add(this.lbltotsum);
            this.grpbxStatistic.Controls.Add(this.lblsumInd);
            this.grpbxStatistic.Controls.Add(this.lblsumcom);
            this.grpbxStatistic.Controls.Add(this.lblsumchargeres);
            this.grpbxStatistic.Controls.Add(this.lblnbrcust);
            this.grpbxStatistic.Controls.Add(this.txtsumofallcharges);
            this.grpbxStatistic.Controls.Add(this.txtsumofchargeIndust);
            this.grpbxStatistic.Controls.Add(this.txtsumofchargeCom);
            this.grpbxStatistic.Controls.Add(this.txtsumofchargeRes);
            this.grpbxStatistic.Controls.Add(this.txtTotNumCust);
            this.grpbxStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxStatistic.Location = new System.Drawing.Point(931, 364);
            this.grpbxStatistic.Name = "grpbxStatistic";
            this.grpbxStatistic.Size = new System.Drawing.Size(348, 224);
            this.grpbxStatistic.TabIndex = 18;
            this.grpbxStatistic.TabStop = false;
            // 
            // lbltotsum
            // 
            this.lbltotsum.AutoSize = true;
            this.lbltotsum.Location = new System.Drawing.Point(3, 192);
            this.lbltotsum.Name = "lbltotsum";
            this.lbltotsum.Size = new System.Drawing.Size(90, 20);
            this.lbltotsum.TabIndex = 22;
            this.lbltotsum.Text = "Total Sum";
            // 
            // lblsumInd
            // 
            this.lblsumInd.AutoSize = true;
            this.lblsumInd.Location = new System.Drawing.Point(3, 149);
            this.lblsumInd.Name = "lblsumInd";
            this.lblsumInd.Size = new System.Drawing.Size(130, 20);
            this.lblsumInd.TabIndex = 21;
            this.lblsumInd.Text = "Sum  Industrial";
            // 
            // lblsumcom
            // 
            this.lblsumcom.AutoSize = true;
            this.lblsumcom.Location = new System.Drawing.Point(3, 108);
            this.lblsumcom.Name = "lblsumcom";
            this.lblsumcom.Size = new System.Drawing.Size(129, 20);
            this.lblsumcom.TabIndex = 20;
            this.lblsumcom.Text = "Sum Comercial";
            // 
            // lblsumchargeres
            // 
            this.lblsumchargeres.AutoSize = true;
            this.lblsumchargeres.Location = new System.Drawing.Point(3, 66);
            this.lblsumchargeres.Name = "lblsumchargeres";
            this.lblsumchargeres.Size = new System.Drawing.Size(140, 20);
            this.lblsumchargeres.TabIndex = 19;
            this.lblsumchargeres.Text = "Sum Residential";
            // 
            // lblnbrcust
            // 
            this.lblnbrcust.AutoSize = true;
            this.lblnbrcust.Location = new System.Drawing.Point(3, 29);
            this.lblnbrcust.Name = "lblnbrcust";
            this.lblnbrcust.Size = new System.Drawing.Size(100, 20);
            this.lblnbrcust.TabIndex = 18;
            this.lblnbrcust.Text = "Nbr of Cust";
            // 
            // txtsumofallcharges
            // 
            this.txtsumofallcharges.Location = new System.Drawing.Point(165, 183);
            this.txtsumofallcharges.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtsumofallcharges.Name = "txtsumofallcharges";
            this.txtsumofallcharges.ReadOnly = true;
            this.txtsumofallcharges.Size = new System.Drawing.Size(136, 26);
            this.txtsumofallcharges.TabIndex = 17;
            // 
            // txtsumofchargeIndust
            // 
            this.txtsumofchargeIndust.Location = new System.Drawing.Point(165, 143);
            this.txtsumofchargeIndust.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtsumofchargeIndust.Name = "txtsumofchargeIndust";
            this.txtsumofchargeIndust.ReadOnly = true;
            this.txtsumofchargeIndust.Size = new System.Drawing.Size(136, 26);
            this.txtsumofchargeIndust.TabIndex = 16;
            // 
            // txtsumofchargeCom
            // 
            this.txtsumofchargeCom.Location = new System.Drawing.Point(165, 100);
            this.txtsumofchargeCom.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtsumofchargeCom.Name = "txtsumofchargeCom";
            this.txtsumofchargeCom.ReadOnly = true;
            this.txtsumofchargeCom.Size = new System.Drawing.Size(136, 26);
            this.txtsumofchargeCom.TabIndex = 15;
            // 
            // txtsumofchargeRes
            // 
            this.txtsumofchargeRes.Location = new System.Drawing.Point(165, 59);
            this.txtsumofchargeRes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtsumofchargeRes.Name = "txtsumofchargeRes";
            this.txtsumofchargeRes.ReadOnly = true;
            this.txtsumofchargeRes.Size = new System.Drawing.Size(136, 26);
            this.txtsumofchargeRes.TabIndex = 14;
            // 
            // txtTotNumCust
            // 
            this.txtTotNumCust.Location = new System.Drawing.Point(165, 20);
            this.txtTotNumCust.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTotNumCust.Name = "txtTotNumCust";
            this.txtTotNumCust.ReadOnly = true;
            this.txtTotNumCust.Size = new System.Drawing.Size(136, 26);
            this.txtTotNumCust.TabIndex = 13;
            // 
            // frm_customerbill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1326, 651);
            this.Controls.Add(this.grpbxStatistic);
            this.Controls.Add(this.grplistCust);
            this.Controls.Add(this.grpboxaddaccount);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.picbxlogo);
            this.Controls.Add(this.tab_customer);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btncalculate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frm_customerbill";
            this.Text = "Enmax Customer Bill";
            this.Load += new System.EventHandler(this.frm_customerbill_Load);
            this.Shown += new System.EventHandler(this.frm_customerbill_Shown);
            this.grp_residential.ResumeLayout(false);
            this.grp_residential.PerformLayout();
            this.grp_industrial.ResumeLayout(false);
            this.grp_industrial.PerformLayout();
            this.tab_customer.ResumeLayout(false);
            this.tab_residential.ResumeLayout(false);
            this.tab_commercial.ResumeLayout(false);
            this.grpcomercial.ResumeLayout(false);
            this.grpcomercial.PerformLayout();
            this.tab_industrial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbxlogo)).EndInit();
            this.grpboxaddaccount.ResumeLayout(false);
            this.grpboxaddaccount.PerformLayout();
            this.grplistCust.ResumeLayout(false);
            this.grpbxStatistic.ResumeLayout(false);
            this.grpbxStatistic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblkwh_residential;
        private System.Windows.Forms.TextBox txtresidential_kwh;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.GroupBox grp_residential;
        private System.Windows.Forms.Label lbl_amount_Residential;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_amount_residential;
        private System.Windows.Forms.GroupBox grp_industrial;
        private System.Windows.Forms.Label lbl_offpeak_hours_amount;
        private System.Windows.Forms.Label lbl_peakhours_amount;
        private System.Windows.Forms.TextBox txt_Offpeakhours_amount;
        private System.Windows.Forms.TextBox txt_offpeakhourskwh;
        private System.Windows.Forms.Label lbl_offpeakhourskwh;
        private System.Windows.Forms.TextBox txt_peakhours_amount;
        private System.Windows.Forms.TextBox txt_peakhourskwh;
        private System.Windows.Forms.Label lblPeakhours_kwh;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TabControl tab_customer;
        private System.Windows.Forms.TabPage tab_residential;
        private System.Windows.Forms.TabPage tab_commercial;
        private System.Windows.Forms.TabPage tab_industrial;
        private System.Windows.Forms.Label lblcommercial_kwh;
        private System.Windows.Forms.TextBox txt_commercial_kwh;
        private System.Windows.Forms.TextBox txt_amount_commercial;
        private System.Windows.Forms.Label lbl_commercial_amount;
        private System.Windows.Forms.GroupBox grpcomercial;
        private System.Windows.Forms.Label lbl_amount_industrial;
        private System.Windows.Forms.TextBox txt_amount_industrial;
        private System.Windows.Forms.PictureBox picbxlogo;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.GroupBox grpboxaddaccount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCustname;
        private System.Windows.Forms.Label lblCustomername;
        private System.Windows.Forms.TextBox txtCustnumber;
        private System.Windows.Forms.Label lblCustNum;
        private System.Windows.Forms.GroupBox grplistCust;
        private System.Windows.Forms.ListBox lstboxCustomer;
        private System.Windows.Forms.GroupBox grpbxStatistic;
        private System.Windows.Forms.Label lbltotsum;
        private System.Windows.Forms.Label lblsumInd;
        private System.Windows.Forms.Label lblsumcom;
        private System.Windows.Forms.Label lblsumchargeres;
        private System.Windows.Forms.Label lblnbrcust;
        private System.Windows.Forms.TextBox txtsumofallcharges;
        private System.Windows.Forms.TextBox txtsumofchargeIndust;
        private System.Windows.Forms.TextBox txtsumofchargeCom;
        private System.Windows.Forms.TextBox txtsumofchargeRes;
        private System.Windows.Forms.TextBox txtTotNumCust;
        private System.Windows.Forms.ComboBox CmbCustType;
    }
}

