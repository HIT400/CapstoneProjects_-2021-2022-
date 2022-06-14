<<<<<<< HEAD
﻿/*
 * Created by SharpDevelop.
 * User: 26378
 * Date: 4/4/2022
 * Time: 1:46 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Electronic_Tollgate
{
	partial class RegistrationDashboard
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtOwner;
		private System.Windows.Forms.TextBox txtPhonenum;
		private System.Windows.Forms.TextBox txtNumplate;
		private System.Windows.Forms.TextBox txtCardNum;
		private System.Windows.Forms.TextBox txtAmount;
		private System.Windows.Forms.ComboBox cmbClass;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtScardNum;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtSamountPaid;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtSnewBal;
		private System.Windows.Forms.Button btnTopUp;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox cmbPort;
		private System.Windows.Forms.Button btnDisconnect;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnRecords;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationDashboard));
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtOwner = new System.Windows.Forms.TextBox();
			this.txtPhonenum = new System.Windows.Forms.TextBox();
			this.txtNumplate = new System.Windows.Forms.TextBox();
			this.txtCardNum = new System.Windows.Forms.TextBox();
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.cmbClass = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtScardNum = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtSamountPaid = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtSnewBal = new System.Windows.Forms.TextBox();
			this.btnTopUp = new System.Windows.Forms.Button();
			this.btnRegister = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.cmbPort = new System.Windows.Forms.ComboBox();
			this.btnDisconnect = new System.Windows.Forms.Button();
			this.btnConnect = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnRecords = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(97, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(305, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Vehicle Registration Dashbord";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(97, 35);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(294, 175);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(0, 245);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Vehicle Owner:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(0, 277);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Phone Number:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(0, 313);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "Number Plate:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(0, 347);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(120, 23);
			this.label5.TabIndex = 2;
			this.label5.Text = "Card Number:";
			this.label5.Click += new System.EventHandler(this.Label5Click);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(0, 379);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(120, 23);
			this.label6.TabIndex = 2;
			this.label6.Text = "Amount Paid:";
			this.label6.Click += new System.EventHandler(this.Label5Click);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(0, 411);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(120, 23);
			this.label7.TabIndex = 2;
			this.label7.Text = "Vehicle Class:";
			this.label7.Click += new System.EventHandler(this.Label5Click);
			// 
			// txtOwner
			// 
			this.txtOwner.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOwner.Location = new System.Drawing.Point(135, 247);
			this.txtOwner.Name = "txtOwner";
			this.txtOwner.Size = new System.Drawing.Size(314, 26);
			this.txtOwner.TabIndex = 3;
			// 
			// txtPhonenum
			// 
			this.txtPhonenum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPhonenum.Location = new System.Drawing.Point(135, 281);
			this.txtPhonenum.Name = "txtPhonenum";
			this.txtPhonenum.Size = new System.Drawing.Size(314, 26);
			this.txtPhonenum.TabIndex = 3;
			// 
			// txtNumplate
			// 
			this.txtNumplate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumplate.Location = new System.Drawing.Point(135, 313);
			this.txtNumplate.Name = "txtNumplate";
			this.txtNumplate.Size = new System.Drawing.Size(314, 26);
			this.txtNumplate.TabIndex = 3;
			// 
			// txtCardNum
			// 
			this.txtCardNum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCardNum.Location = new System.Drawing.Point(135, 345);
			this.txtCardNum.Name = "txtCardNum";
			this.txtCardNum.Size = new System.Drawing.Size(314, 26);
			this.txtCardNum.TabIndex = 3;
			// 
			// txtAmount
			// 
			this.txtAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAmount.Location = new System.Drawing.Point(135, 379);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(314, 26);
			this.txtAmount.TabIndex = 3;
			// 
			// cmbClass
			// 
			this.cmbClass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbClass.FormattingEnabled = true;
			this.cmbClass.Items.AddRange(new object[] {
			"A",
			"B"});
			this.cmbClass.Location = new System.Drawing.Point(135, 412);
			this.cmbClass.Name = "cmbClass";
			this.cmbClass.Size = new System.Drawing.Size(314, 27);
			this.cmbClass.TabIndex = 4;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(0, 213);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(242, 23);
			this.label8.TabIndex = 5;
			this.label8.Text = "Registration Section:";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(0, 483);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(242, 23);
			this.label9.TabIndex = 5;
			this.label9.Text = "Subscription Section:";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(0, 520);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(120, 23);
			this.label10.TabIndex = 2;
			this.label10.Text = "Card Number:";
			this.label10.Click += new System.EventHandler(this.Label5Click);
			// 
			// txtScardNum
			// 
			this.txtScardNum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtScardNum.Location = new System.Drawing.Point(135, 520);
			this.txtScardNum.Name = "txtScardNum";
			this.txtScardNum.Size = new System.Drawing.Size(314, 26);
			this.txtScardNum.TabIndex = 3;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(0, 552);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(120, 23);
			this.label11.TabIndex = 2;
			this.label11.Text = "Amount Paid:";
			this.label11.Click += new System.EventHandler(this.Label5Click);
			// 
			// txtSamountPaid
			// 
			this.txtSamountPaid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSamountPaid.Location = new System.Drawing.Point(135, 552);
			this.txtSamountPaid.Name = "txtSamountPaid";
			this.txtSamountPaid.Size = new System.Drawing.Size(314, 26);
			this.txtSamountPaid.TabIndex = 3;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(0, 587);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(120, 23);
			this.label12.TabIndex = 2;
			this.label12.Text = "New Balance:";
			this.label12.Click += new System.EventHandler(this.Label5Click);
			// 
			// txtSnewBal
			// 
			this.txtSnewBal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSnewBal.Location = new System.Drawing.Point(135, 584);
			this.txtSnewBal.Name = "txtSnewBal";
			this.txtSnewBal.Size = new System.Drawing.Size(314, 26);
			this.txtSnewBal.TabIndex = 3;
			// 
			// btnTopUp
			// 
			this.btnTopUp.BackColor = System.Drawing.Color.White;
			this.btnTopUp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTopUp.Location = new System.Drawing.Point(135, 616);
			this.btnTopUp.Name = "btnTopUp";
			this.btnTopUp.Size = new System.Drawing.Size(314, 32);
			this.btnTopUp.TabIndex = 6;
			this.btnTopUp.Text = "TopUp";
			this.btnTopUp.UseVisualStyleBackColor = false;
			this.btnTopUp.Click += new System.EventHandler(this.BtnTopUpClick);
			// 
			// btnRegister
			// 
			this.btnRegister.BackColor = System.Drawing.Color.White;
			this.btnRegister.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegister.Location = new System.Drawing.Point(342, 445);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(107, 34);
			this.btnRegister.TabIndex = 7;
			this.btnRegister.Text = "Register";
			this.btnRegister.UseVisualStyleBackColor = false;
			this.btnRegister.Click += new System.EventHandler(this.BtnRegisterClick);
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(0, 668);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(155, 23);
			this.label13.TabIndex = 2;
			this.label13.Text = "COMPORT SEL:";
			this.label13.Click += new System.EventHandler(this.Label5Click);
			// 
			// cmbPort
			// 
			this.cmbPort.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbPort.FormattingEnabled = true;
			this.cmbPort.Location = new System.Drawing.Point(135, 664);
			this.cmbPort.Name = "cmbPort";
			this.cmbPort.Size = new System.Drawing.Size(121, 27);
			this.cmbPort.TabIndex = 8;
			// 
			// btnDisconnect
			// 
			this.btnDisconnect.BackColor = System.Drawing.Color.White;
			this.btnDisconnect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDisconnect.Location = new System.Drawing.Point(273, 664);
			this.btnDisconnect.Name = "btnDisconnect";
			this.btnDisconnect.Size = new System.Drawing.Size(176, 27);
			this.btnDisconnect.TabIndex = 9;
			this.btnDisconnect.Text = "Disconnect";
			this.btnDisconnect.UseVisualStyleBackColor = false;
			this.btnDisconnect.Click += new System.EventHandler(this.BtnDisconnectClick);
			// 
			// btnConnect
			// 
			this.btnConnect.BackColor = System.Drawing.Color.White;
			this.btnConnect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConnect.Location = new System.Drawing.Point(273, 663);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(176, 26);
			this.btnConnect.TabIndex = 10;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = false;
			this.btnConnect.Click += new System.EventHandler(this.BtnConnectClick);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.White;
			this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(135, 445);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(83, 34);
			this.btnExit.TabIndex = 11;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
			// 
			// btnRecords
			// 
			this.btnRecords.BackColor = System.Drawing.Color.White;
			this.btnRecords.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRecords.Location = new System.Drawing.Point(233, 447);
			this.btnRecords.Name = "btnRecords";
			this.btnRecords.Size = new System.Drawing.Size(91, 33);
			this.btnRecords.TabIndex = 12;
			this.btnRecords.Text = "Records";
			this.btnRecords.UseVisualStyleBackColor = false;
			this.btnRecords.Click += new System.EventHandler(this.BtnRecordsClick);
			// 
			// RegistrationDashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Yellow;
			this.ClientSize = new System.Drawing.Size(464, 698);
			this.Controls.Add(this.btnRecords);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.btnDisconnect);
			this.Controls.Add(this.cmbPort);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.btnTopUp);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.cmbClass);
			this.Controls.Add(this.txtAmount);
			this.Controls.Add(this.txtSnewBal);
			this.Controls.Add(this.txtSamountPaid);
			this.Controls.Add(this.txtScardNum);
			this.Controls.Add(this.txtCardNum);
			this.Controls.Add(this.txtNumplate);
			this.Controls.Add(this.txtPhonenum);
			this.Controls.Add(this.txtOwner);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Name = "RegistrationDashboard";
			this.Text = "RegistrationDashboard";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
=======
﻿/*
 * Created by SharpDevelop.
 * User: 26378
 * Date: 4/4/2022
 * Time: 1:46 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Electronic_Tollgate
{
	partial class RegistrationDashboard
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtOwner;
		private System.Windows.Forms.TextBox txtPhonenum;
		private System.Windows.Forms.TextBox txtNumplate;
		private System.Windows.Forms.TextBox txtCardNum;
		private System.Windows.Forms.TextBox txtAmount;
		private System.Windows.Forms.ComboBox cmbClass;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtScardNum;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtSamountPaid;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtSnewBal;
		private System.Windows.Forms.Button btnTopUp;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox cmbPort;
		private System.Windows.Forms.Button btnDisconnect;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnRecords;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationDashboard));
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtOwner = new System.Windows.Forms.TextBox();
			this.txtPhonenum = new System.Windows.Forms.TextBox();
			this.txtNumplate = new System.Windows.Forms.TextBox();
			this.txtCardNum = new System.Windows.Forms.TextBox();
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.cmbClass = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtScardNum = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtSamountPaid = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtSnewBal = new System.Windows.Forms.TextBox();
			this.btnTopUp = new System.Windows.Forms.Button();
			this.btnRegister = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.cmbPort = new System.Windows.Forms.ComboBox();
			this.btnDisconnect = new System.Windows.Forms.Button();
			this.btnConnect = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnRecords = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(97, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(305, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Vehicle Registration Dashbord";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(97, 35);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(294, 175);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(0, 245);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Vehicle Owner:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(0, 277);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Phone Number:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(0, 313);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "Number Plate:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(0, 347);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(120, 23);
			this.label5.TabIndex = 2;
			this.label5.Text = "Card Number:";
			this.label5.Click += new System.EventHandler(this.Label5Click);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(0, 379);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(120, 23);
			this.label6.TabIndex = 2;
			this.label6.Text = "Amount Paid:";
			this.label6.Click += new System.EventHandler(this.Label5Click);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(0, 411);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(120, 23);
			this.label7.TabIndex = 2;
			this.label7.Text = "Vehicle Class:";
			this.label7.Click += new System.EventHandler(this.Label5Click);
			// 
			// txtOwner
			// 
			this.txtOwner.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOwner.Location = new System.Drawing.Point(135, 247);
			this.txtOwner.Name = "txtOwner";
			this.txtOwner.Size = new System.Drawing.Size(314, 26);
			this.txtOwner.TabIndex = 3;
			// 
			// txtPhonenum
			// 
			this.txtPhonenum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPhonenum.Location = new System.Drawing.Point(135, 281);
			this.txtPhonenum.Name = "txtPhonenum";
			this.txtPhonenum.Size = new System.Drawing.Size(314, 26);
			this.txtPhonenum.TabIndex = 3;
			// 
			// txtNumplate
			// 
			this.txtNumplate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumplate.Location = new System.Drawing.Point(135, 313);
			this.txtNumplate.Name = "txtNumplate";
			this.txtNumplate.Size = new System.Drawing.Size(314, 26);
			this.txtNumplate.TabIndex = 3;
			// 
			// txtCardNum
			// 
			this.txtCardNum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCardNum.Location = new System.Drawing.Point(135, 345);
			this.txtCardNum.Name = "txtCardNum";
			this.txtCardNum.Size = new System.Drawing.Size(314, 26);
			this.txtCardNum.TabIndex = 3;
			// 
			// txtAmount
			// 
			this.txtAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAmount.Location = new System.Drawing.Point(135, 379);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(314, 26);
			this.txtAmount.TabIndex = 3;
			// 
			// cmbClass
			// 
			this.cmbClass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbClass.FormattingEnabled = true;
			this.cmbClass.Items.AddRange(new object[] {
			"A",
			"B"});
			this.cmbClass.Location = new System.Drawing.Point(135, 412);
			this.cmbClass.Name = "cmbClass";
			this.cmbClass.Size = new System.Drawing.Size(314, 27);
			this.cmbClass.TabIndex = 4;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(0, 213);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(242, 23);
			this.label8.TabIndex = 5;
			this.label8.Text = "Registration Section:";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(0, 483);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(242, 23);
			this.label9.TabIndex = 5;
			this.label9.Text = "Subscription Section:";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(0, 520);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(120, 23);
			this.label10.TabIndex = 2;
			this.label10.Text = "Card Number:";
			this.label10.Click += new System.EventHandler(this.Label5Click);
			// 
			// txtScardNum
			// 
			this.txtScardNum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtScardNum.Location = new System.Drawing.Point(135, 520);
			this.txtScardNum.Name = "txtScardNum";
			this.txtScardNum.Size = new System.Drawing.Size(314, 26);
			this.txtScardNum.TabIndex = 3;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(0, 552);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(120, 23);
			this.label11.TabIndex = 2;
			this.label11.Text = "Amount Paid:";
			this.label11.Click += new System.EventHandler(this.Label5Click);
			// 
			// txtSamountPaid
			// 
			this.txtSamountPaid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSamountPaid.Location = new System.Drawing.Point(135, 552);
			this.txtSamountPaid.Name = "txtSamountPaid";
			this.txtSamountPaid.Size = new System.Drawing.Size(314, 26);
			this.txtSamountPaid.TabIndex = 3;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(0, 587);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(120, 23);
			this.label12.TabIndex = 2;
			this.label12.Text = "New Balance:";
			this.label12.Click += new System.EventHandler(this.Label5Click);
			// 
			// txtSnewBal
			// 
			this.txtSnewBal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSnewBal.Location = new System.Drawing.Point(135, 584);
			this.txtSnewBal.Name = "txtSnewBal";
			this.txtSnewBal.Size = new System.Drawing.Size(314, 26);
			this.txtSnewBal.TabIndex = 3;
			// 
			// btnTopUp
			// 
			this.btnTopUp.BackColor = System.Drawing.Color.White;
			this.btnTopUp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTopUp.Location = new System.Drawing.Point(135, 616);
			this.btnTopUp.Name = "btnTopUp";
			this.btnTopUp.Size = new System.Drawing.Size(314, 32);
			this.btnTopUp.TabIndex = 6;
			this.btnTopUp.Text = "TopUp";
			this.btnTopUp.UseVisualStyleBackColor = false;
			this.btnTopUp.Click += new System.EventHandler(this.BtnTopUpClick);
			// 
			// btnRegister
			// 
			this.btnRegister.BackColor = System.Drawing.Color.White;
			this.btnRegister.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegister.Location = new System.Drawing.Point(342, 445);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(107, 34);
			this.btnRegister.TabIndex = 7;
			this.btnRegister.Text = "Register";
			this.btnRegister.UseVisualStyleBackColor = false;
			this.btnRegister.Click += new System.EventHandler(this.BtnRegisterClick);
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(0, 668);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(155, 23);
			this.label13.TabIndex = 2;
			this.label13.Text = "COMPORT SEL:";
			this.label13.Click += new System.EventHandler(this.Label5Click);
			// 
			// cmbPort
			// 
			this.cmbPort.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbPort.FormattingEnabled = true;
			this.cmbPort.Location = new System.Drawing.Point(135, 664);
			this.cmbPort.Name = "cmbPort";
			this.cmbPort.Size = new System.Drawing.Size(121, 27);
			this.cmbPort.TabIndex = 8;
			// 
			// btnDisconnect
			// 
			this.btnDisconnect.BackColor = System.Drawing.Color.White;
			this.btnDisconnect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDisconnect.Location = new System.Drawing.Point(273, 664);
			this.btnDisconnect.Name = "btnDisconnect";
			this.btnDisconnect.Size = new System.Drawing.Size(176, 27);
			this.btnDisconnect.TabIndex = 9;
			this.btnDisconnect.Text = "Disconnect";
			this.btnDisconnect.UseVisualStyleBackColor = false;
			this.btnDisconnect.Click += new System.EventHandler(this.BtnDisconnectClick);
			// 
			// btnConnect
			// 
			this.btnConnect.BackColor = System.Drawing.Color.White;
			this.btnConnect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConnect.Location = new System.Drawing.Point(273, 663);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(176, 26);
			this.btnConnect.TabIndex = 10;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = false;
			this.btnConnect.Click += new System.EventHandler(this.BtnConnectClick);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.White;
			this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(135, 445);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(83, 34);
			this.btnExit.TabIndex = 11;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
			// 
			// btnRecords
			// 
			this.btnRecords.BackColor = System.Drawing.Color.White;
			this.btnRecords.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRecords.Location = new System.Drawing.Point(233, 447);
			this.btnRecords.Name = "btnRecords";
			this.btnRecords.Size = new System.Drawing.Size(91, 33);
			this.btnRecords.TabIndex = 12;
			this.btnRecords.Text = "Records";
			this.btnRecords.UseVisualStyleBackColor = false;
			this.btnRecords.Click += new System.EventHandler(this.BtnRecordsClick);
			// 
			// RegistrationDashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Yellow;
			this.ClientSize = new System.Drawing.Size(464, 698);
			this.Controls.Add(this.btnRecords);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.btnDisconnect);
			this.Controls.Add(this.cmbPort);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.btnTopUp);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.cmbClass);
			this.Controls.Add(this.txtAmount);
			this.Controls.Add(this.txtSnewBal);
			this.Controls.Add(this.txtSamountPaid);
			this.Controls.Add(this.txtScardNum);
			this.Controls.Add(this.txtCardNum);
			this.Controls.Add(this.txtNumplate);
			this.Controls.Add(this.txtPhonenum);
			this.Controls.Add(this.txtOwner);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Name = "RegistrationDashboard";
			this.Text = "RegistrationDashboard";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
>>>>>>> parent of 5a30ca7... commit message
