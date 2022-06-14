namespace EasyTicket.Forms.Main_Menu
{
    partial class TopupAccount
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
            this.dgvTopup = new System.Windows.Forms.DataGridView();
            this.labelUsername = new System.Windows.Forms.Label();
            this.llBack = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTransactionType = new System.Windows.Forms.ComboBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBank = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.txtNewBalance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCurrentBalance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopup)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Topup Your Account";
            // 
            // dgvTopup
            // 
            this.dgvTopup.AllowUserToAddRows = false;
            this.dgvTopup.AllowUserToDeleteRows = false;
            this.dgvTopup.AllowUserToResizeColumns = false;
            this.dgvTopup.AllowUserToResizeRows = false;
            this.dgvTopup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopup.Location = new System.Drawing.Point(12, 94);
            this.dgvTopup.Name = "dgvTopup";
            this.dgvTopup.Size = new System.Drawing.Size(298, 240);
            this.dgvTopup.TabIndex = 8;
            this.dgvTopup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTopup_CellClick);
            this.dgvTopup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTopup_CellContentClick);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(603, 9);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 16;
            this.labelUsername.Text = "Username";
            // 
            // llBack
            // 
            this.llBack.AutoSize = true;
            this.llBack.Location = new System.Drawing.Point(13, 13);
            this.llBack.Name = "llBack";
            this.llBack.Size = new System.Drawing.Size(60, 13);
            this.llBack.TabIndex = 17;
            this.llBack.TabStop = true;
            this.llBack.Text = "Main Menu";
            this.llBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llBack_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbTransactionType);
            this.groupBox1.Controls.Add(this.txtAccountNumber);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbBank);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnPreview);
            this.groupBox1.Controls.Add(this.txtNewBalance);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCurrentBalance);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(326, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 240);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Topup";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Transaction Type";
            // 
            // cbTransactionType
            // 
            this.cbTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransactionType.FormattingEnabled = true;
            this.cbTransactionType.Items.AddRange(new object[] {
            "RTGS",
            "ZIPIT"});
            this.cbTransactionType.Location = new System.Drawing.Point(20, 156);
            this.cbTransactionType.Name = "cbTransactionType";
            this.cbTransactionType.Size = new System.Drawing.Size(100, 21);
            this.cbTransactionType.Sorted = true;
            this.cbTransactionType.TabIndex = 29;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(186, 95);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(100, 20);
            this.txtAccountNumber.TabIndex = 28;
            this.txtAccountNumber.Text = "000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Account Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Bank";
            // 
            // cbBank
            // 
            this.cbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBank.FormattingEnabled = true;
            this.cbBank.Items.AddRange(new object[] {
            "CABS",
            "CBZ",
            "EcoBank",
            "EcoCash",
            "FBC",
            "Icecash",
            "NMB",
            "OneMoney",
            "POSB",
            "Steward Bank",
            "Telecash"});
            this.cbBank.Location = new System.Drawing.Point(20, 95);
            this.cbBank.Name = "cbBank";
            this.cbBank.Size = new System.Drawing.Size(100, 21);
            this.cbBank.Sorted = true;
            this.cbBank.TabIndex = 24;
            this.cbBank.SelectedIndexChanged += new System.EventHandler(this.cbBank_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(186, 204);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(20, 204);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(100, 30);
            this.btnPreview.TabIndex = 18;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click_1);
            // 
            // txtNewBalance
            // 
            this.txtNewBalance.Enabled = false;
            this.txtNewBalance.Location = new System.Drawing.Point(186, 157);
            this.txtNewBalance.Name = "txtNewBalance";
            this.txtNewBalance.ReadOnly = true;
            this.txtNewBalance.Size = new System.Drawing.Size(100, 20);
            this.txtNewBalance.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Your New Balance \r\nWill Be";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(186, 41);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 15;
            this.txtAmount.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Topup Amount";
            // 
            // txtCurrentBalance
            // 
            this.txtCurrentBalance.Enabled = false;
            this.txtCurrentBalance.Location = new System.Drawing.Point(20, 41);
            this.txtCurrentBalance.Name = "txtCurrentBalance";
            this.txtCurrentBalance.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentBalance.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Current Balance";
            // 
            // TopupAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 367);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.llBack);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.dgvTopup);
            this.Controls.Add(this.label1);
            this.Name = "TopupAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TopupAccount";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TopupAccount_FormClosed);
            this.Load += new System.EventHandler(this.TopupAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopup)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTopup;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.LinkLabel llBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.TextBox txtNewBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCurrentBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBank;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTransactionType;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label6;
    }
}