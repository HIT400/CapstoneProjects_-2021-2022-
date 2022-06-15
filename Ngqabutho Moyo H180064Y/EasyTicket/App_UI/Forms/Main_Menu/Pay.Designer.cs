<<<<<<< HEAD
﻿namespace EasyTicket.Forms.Main_Menu
{
    partial class Pay
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPay = new System.Windows.Forms.DataGridView();
            this.labelUsername = new System.Windows.Forms.Label();
            this.llMainMenu = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbHour = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPrice = new System.Windows.Forms.ComboBox();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.txtCurrentBalance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMinute = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pay For Your Trip";
            // 
            // dgvPay
            // 
            this.dgvPay.AllowUserToAddRows = false;
            this.dgvPay.AllowUserToDeleteRows = false;
            this.dgvPay.AllowUserToResizeColumns = false;
            this.dgvPay.AllowUserToResizeRows = false;
            this.dgvPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPay.Location = new System.Drawing.Point(15, 100);
            this.dgvPay.Name = "dgvPay";
            this.dgvPay.Size = new System.Drawing.Size(348, 199);
            this.dgvPay.TabIndex = 10;
            this.dgvPay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPay_CellClick);
            this.dgvPay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPay_CellContentClick);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(532, 9);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 16;
            this.labelUsername.Text = "Username";
            // 
            // llMainMenu
            // 
            this.llMainMenu.AutoSize = true;
            this.llMainMenu.Location = new System.Drawing.Point(12, 9);
            this.llMainMenu.Name = "llMainMenu";
            this.llMainMenu.Size = new System.Drawing.Size(60, 13);
            this.llMainMenu.TabIndex = 18;
            this.llMainMenu.TabStop = true;
            this.llMainMenu.Text = "Main Menu";
            this.llMainMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llMainMenu_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbMinute);
            this.groupBox1.Controls.Add(this.cbHour);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbPrice);
            this.groupBox1.Controls.Add(this.cbTo);
            this.groupBox1.Controls.Add(this.cbFrom);
            this.groupBox1.Controls.Add(this.txtCurrentBalance);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnPay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(370, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 199);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = ":";
            // 
            // cbHour
            // 
            this.cbHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHour.FormattingEnabled = true;
            this.cbHour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbHour.Location = new System.Drawing.Point(105, 111);
            this.cbHour.Name = "cbHour";
            this.cbHour.Size = new System.Drawing.Size(38, 21);
            this.cbHour.Sorted = true;
            this.cbHour.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Time";
            // 
            // cbPrice
            // 
            this.cbPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrice.FormattingEnabled = true;
            this.cbPrice.Items.AddRange(new object[] {
            "80",
            "100",
            "110"});
            this.cbPrice.Location = new System.Drawing.Point(105, 138);
            this.cbPrice.Name = "cbPrice";
            this.cbPrice.Size = new System.Drawing.Size(98, 21);
            this.cbPrice.TabIndex = 24;
            // 
            // cbTo
            // 
            this.cbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Items.AddRange(new object[] {
            "Ardbennie",
            "Belvedere",
            "Budiriro",
            "Chisipite",
            "Glen View",
            "Kamfinsa",
            "Kuwadzana",
            "Lochinvar",
            "Mabvuku",
            "Manresa",
            "Mbare",
            "Milton Park",
            "Mt Pleasant",
            "Newlands",
            "Parktown",
            "Ruwa",
            "Southerton",
            "Tafara",
            "The Grange",
            "Warren Park",
            "Waterfalls",
            "Westgate"});
            this.cbTo.Location = new System.Drawing.Point(105, 84);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(98, 21);
            this.cbTo.Sorted = true;
            this.cbTo.TabIndex = 23;
            // 
            // cbFrom
            // 
            this.cbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Items.AddRange(new object[] {
            "4th Street",
            "Charge Office",
            "Copacabana",
            "Market Square",
            "Rezende"});
            this.cbFrom.Location = new System.Drawing.Point(105, 57);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(98, 21);
            this.cbFrom.Sorted = true;
            this.cbFrom.TabIndex = 22;
            this.cbFrom.SelectedIndexChanged += new System.EventHandler(this.cbFrom_SelectedIndexChanged);
            // 
            // txtCurrentBalance
            // 
            this.txtCurrentBalance.Enabled = false;
            this.txtCurrentBalance.Location = new System.Drawing.Point(105, 28);
            this.txtCurrentBalance.Name = "txtCurrentBalance";
            this.txtCurrentBalance.ReadOnly = true;
            this.txtCurrentBalance.Size = new System.Drawing.Size(98, 20);
            this.txtCurrentBalance.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Current Balance";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(105, 165);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(98, 23);
            this.btnPay.TabIndex = 19;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fare(ZWL$)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "From";
            // 
            // cbMinute
            // 
            this.cbMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMinute.FormattingEnabled = true;
            this.cbMinute.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.cbMinute.Location = new System.Drawing.Point(165, 111);
            this.cbMinute.Name = "cbMinute";
            this.cbMinute.Size = new System.Drawing.Size(38, 21);
            this.cbMinute.Sorted = true;
            this.cbMinute.TabIndex = 27;
            // 
            // Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 345);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.llMainMenu);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.dgvPay);
            this.Controls.Add(this.label1);
            this.Name = "Pay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pay_FormClosed);
            this.Load += new System.EventHandler(this.Pay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPay;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.LinkLabel llMainMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCurrentBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPrice;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.ComboBox cbMinute;
        private System.Windows.Forms.ComboBox cbHour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
=======
﻿namespace EasyTicket.Forms.Main_Menu
{
    partial class Pay
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPay = new System.Windows.Forms.DataGridView();
            this.labelUsername = new System.Windows.Forms.Label();
            this.llMainMenu = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbHour = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPrice = new System.Windows.Forms.ComboBox();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.txtCurrentBalance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMinute = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pay For Your Trip";
            // 
            // dgvPay
            // 
            this.dgvPay.AllowUserToAddRows = false;
            this.dgvPay.AllowUserToDeleteRows = false;
            this.dgvPay.AllowUserToResizeColumns = false;
            this.dgvPay.AllowUserToResizeRows = false;
            this.dgvPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPay.Location = new System.Drawing.Point(15, 100);
            this.dgvPay.Name = "dgvPay";
            this.dgvPay.Size = new System.Drawing.Size(348, 199);
            this.dgvPay.TabIndex = 10;
            this.dgvPay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPay_CellClick);
            this.dgvPay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPay_CellContentClick);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(532, 9);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 16;
            this.labelUsername.Text = "Username";
            // 
            // llMainMenu
            // 
            this.llMainMenu.AutoSize = true;
            this.llMainMenu.Location = new System.Drawing.Point(12, 9);
            this.llMainMenu.Name = "llMainMenu";
            this.llMainMenu.Size = new System.Drawing.Size(60, 13);
            this.llMainMenu.TabIndex = 18;
            this.llMainMenu.TabStop = true;
            this.llMainMenu.Text = "Main Menu";
            this.llMainMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llMainMenu_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbMinute);
            this.groupBox1.Controls.Add(this.cbHour);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbPrice);
            this.groupBox1.Controls.Add(this.cbTo);
            this.groupBox1.Controls.Add(this.cbFrom);
            this.groupBox1.Controls.Add(this.txtCurrentBalance);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnPay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(370, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 199);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = ":";
            // 
            // cbHour
            // 
            this.cbHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHour.FormattingEnabled = true;
            this.cbHour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbHour.Location = new System.Drawing.Point(105, 111);
            this.cbHour.Name = "cbHour";
            this.cbHour.Size = new System.Drawing.Size(38, 21);
            this.cbHour.Sorted = true;
            this.cbHour.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Time";
            // 
            // cbPrice
            // 
            this.cbPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrice.FormattingEnabled = true;
            this.cbPrice.Items.AddRange(new object[] {
            "80",
            "100",
            "110"});
            this.cbPrice.Location = new System.Drawing.Point(105, 138);
            this.cbPrice.Name = "cbPrice";
            this.cbPrice.Size = new System.Drawing.Size(98, 21);
            this.cbPrice.TabIndex = 24;
            // 
            // cbTo
            // 
            this.cbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Items.AddRange(new object[] {
            "Ardbennie",
            "Belvedere",
            "Budiriro",
            "Chisipite",
            "Glen View",
            "Kamfinsa",
            "Kuwadzana",
            "Lochinvar",
            "Mabvuku",
            "Manresa",
            "Mbare",
            "Milton Park",
            "Mt Pleasant",
            "Newlands",
            "Parktown",
            "Ruwa",
            "Southerton",
            "Tafara",
            "The Grange",
            "Warren Park",
            "Waterfalls",
            "Westgate"});
            this.cbTo.Location = new System.Drawing.Point(105, 84);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(98, 21);
            this.cbTo.Sorted = true;
            this.cbTo.TabIndex = 23;
            // 
            // cbFrom
            // 
            this.cbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Items.AddRange(new object[] {
            "4th Street",
            "Charge Office",
            "Copacabana",
            "Market Square",
            "Rezende"});
            this.cbFrom.Location = new System.Drawing.Point(105, 57);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(98, 21);
            this.cbFrom.Sorted = true;
            this.cbFrom.TabIndex = 22;
            this.cbFrom.SelectedIndexChanged += new System.EventHandler(this.cbFrom_SelectedIndexChanged);
            // 
            // txtCurrentBalance
            // 
            this.txtCurrentBalance.Enabled = false;
            this.txtCurrentBalance.Location = new System.Drawing.Point(105, 28);
            this.txtCurrentBalance.Name = "txtCurrentBalance";
            this.txtCurrentBalance.ReadOnly = true;
            this.txtCurrentBalance.Size = new System.Drawing.Size(98, 20);
            this.txtCurrentBalance.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Current Balance";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(105, 165);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(98, 23);
            this.btnPay.TabIndex = 19;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fare(ZWL$)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "From";
            // 
            // cbMinute
            // 
            this.cbMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMinute.FormattingEnabled = true;
            this.cbMinute.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.cbMinute.Location = new System.Drawing.Point(165, 111);
            this.cbMinute.Name = "cbMinute";
            this.cbMinute.Size = new System.Drawing.Size(38, 21);
            this.cbMinute.Sorted = true;
            this.cbMinute.TabIndex = 27;
            // 
            // Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 345);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.llMainMenu);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.dgvPay);
            this.Controls.Add(this.label1);
            this.Name = "Pay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pay_FormClosed);
            this.Load += new System.EventHandler(this.Pay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPay;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.LinkLabel llMainMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCurrentBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPrice;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.ComboBox cbMinute;
        private System.Windows.Forms.ComboBox cbHour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
>>>>>>> parent of 5a30ca7... commit message
}