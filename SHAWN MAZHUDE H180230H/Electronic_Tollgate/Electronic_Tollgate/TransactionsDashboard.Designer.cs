<<<<<<< HEAD
﻿/*
 * Created by SharpDevelop.
 * User: 26378
 * Date: 4/4/2022
 * Time: 1:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Electronic_Tollgate
{
	partial class TransactionsDashboard
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbPORT;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Button btnDisconnect;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbTollgate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtCardnumber;
		private System.Windows.Forms.TextBox txtBalance;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtAmntTopUp;
		private System.Windows.Forms.Button btnTopUp;
		private System.Windows.Forms.Button btnTrans;
		private System.Windows.Forms.Button btnExit;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionsDashboard));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbPORT = new System.Windows.Forms.ComboBox();
			this.btnConnect = new System.Windows.Forms.Button();
			this.btnDisconnect = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbTollgate = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtCardnumber = new System.Windows.Forms.TextBox();
			this.txtBalance = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtAmntTopUp = new System.Windows.Forms.TextBox();
			this.btnTopUp = new System.Windows.Forms.Button();
			this.btnTrans = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(74, 49);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(298, 174);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(345, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Daily Tollgate Transactions Dashboard";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 238);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(437, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "*NB make sure hardware is connected and tollgate name is selected below!!";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 270);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(137, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "COMPORT SEL:";
			// 
			// cmbPORT
			// 
			this.cmbPORT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbPORT.FormattingEnabled = true;
			this.cmbPORT.Location = new System.Drawing.Point(144, 271);
			this.cmbPORT.Name = "cmbPORT";
			this.cmbPORT.Size = new System.Drawing.Size(103, 27);
			this.cmbPORT.TabIndex = 4;
			// 
			// btnConnect
			// 
			this.btnConnect.BackColor = System.Drawing.Color.White;
			this.btnConnect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConnect.Location = new System.Drawing.Point(268, 270);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(166, 28);
			this.btnConnect.TabIndex = 5;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = false;
			this.btnConnect.Click += new System.EventHandler(this.BtnConnectClick);
			// 
			// btnDisconnect
			// 
			this.btnDisconnect.BackColor = System.Drawing.Color.White;
			this.btnDisconnect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDisconnect.Location = new System.Drawing.Point(268, 271);
			this.btnDisconnect.Name = "btnDisconnect";
			this.btnDisconnect.Size = new System.Drawing.Size(166, 28);
			this.btnDisconnect.TabIndex = 6;
			this.btnDisconnect.Text = "Disconnect";
			this.btnDisconnect.UseVisualStyleBackColor = false;
			this.btnDisconnect.Click += new System.EventHandler(this.BtnDisconnectClick);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(13, 309);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(137, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "TOLLGATE SEL:";
			// 
			// cmbTollgate
			// 
			this.cmbTollgate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbTollgate.FormattingEnabled = true;
			this.cmbTollgate.Items.AddRange(new object[] {
			"TollgateA",
			"TollgateB",
			"TollgateC",
			"TollgateD"});
			this.cmbTollgate.Location = new System.Drawing.Point(144, 305);
			this.cmbTollgate.Name = "cmbTollgate";
			this.cmbTollgate.Size = new System.Drawing.Size(290, 27);
			this.cmbTollgate.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 346);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(137, 23);
			this.label5.TabIndex = 3;
			this.label5.Text = "CAR NUMBER:";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(245, 349);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(137, 23);
			this.label6.TabIndex = 3;
			this.label6.Text = "BALANCE:$";
			// 
			// txtCardnumber
			// 
			this.txtCardnumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCardnumber.Location = new System.Drawing.Point(144, 346);
			this.txtCardnumber.Name = "txtCardnumber";
			this.txtCardnumber.Size = new System.Drawing.Size(103, 26);
			this.txtCardnumber.TabIndex = 8;
			// 
			// txtBalance
			// 
			this.txtBalance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBalance.Location = new System.Drawing.Point(344, 346);
			this.txtBalance.Name = "txtBalance";
			this.txtBalance.Size = new System.Drawing.Size(90, 26);
			this.txtBalance.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(13, 388);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(198, 23);
			this.label7.TabIndex = 9;
			this.label7.Text = "Subscription Section:";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(13, 421);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(117, 23);
			this.label8.TabIndex = 10;
			this.label8.Text = "Enter Amount:";
			// 
			// txtAmntTopUp
			// 
			this.txtAmntTopUp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAmntTopUp.Location = new System.Drawing.Point(144, 418);
			this.txtAmntTopUp.Name = "txtAmntTopUp";
			this.txtAmntTopUp.Size = new System.Drawing.Size(111, 26);
			this.txtAmntTopUp.TabIndex = 8;
			// 
			// btnTopUp
			// 
			this.btnTopUp.BackColor = System.Drawing.Color.White;
			this.btnTopUp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTopUp.Location = new System.Drawing.Point(268, 418);
			this.btnTopUp.Name = "btnTopUp";
			this.btnTopUp.Size = new System.Drawing.Size(166, 26);
			this.btnTopUp.TabIndex = 11;
			this.btnTopUp.Text = "TopUp";
			this.btnTopUp.UseVisualStyleBackColor = false;
			this.btnTopUp.Click += new System.EventHandler(this.BtnTopUpClick);
			// 
			// btnTrans
			// 
			this.btnTrans.BackColor = System.Drawing.Color.White;
			this.btnTrans.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTrans.Location = new System.Drawing.Point(268, 454);
			this.btnTrans.Name = "btnTrans";
			this.btnTrans.Size = new System.Drawing.Size(166, 31);
			this.btnTrans.TabIndex = 12;
			this.btnTrans.Text = "Transaction Records";
			this.btnTrans.UseVisualStyleBackColor = false;
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.White;
			this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(144, 454);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(111, 31);
			this.btnExit.TabIndex = 13;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
			// 
			// TransactionsDashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Yellow;
			this.ClientSize = new System.Drawing.Size(447, 489);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnTrans);
			this.Controls.Add(this.btnTopUp);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtBalance);
			this.Controls.Add(this.txtAmntTopUp);
			this.Controls.Add(this.txtCardnumber);
			this.Controls.Add(this.cmbTollgate);
			this.Controls.Add(this.btnDisconnect);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.cmbPORT);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "TransactionsDashboard";
			this.Text = "TransactionsDashboard";
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
 * Time: 1:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Electronic_Tollgate
{
	partial class TransactionsDashboard
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbPORT;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Button btnDisconnect;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbTollgate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtCardnumber;
		private System.Windows.Forms.TextBox txtBalance;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtAmntTopUp;
		private System.Windows.Forms.Button btnTopUp;
		private System.Windows.Forms.Button btnTrans;
		private System.Windows.Forms.Button btnExit;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionsDashboard));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbPORT = new System.Windows.Forms.ComboBox();
			this.btnConnect = new System.Windows.Forms.Button();
			this.btnDisconnect = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbTollgate = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtCardnumber = new System.Windows.Forms.TextBox();
			this.txtBalance = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtAmntTopUp = new System.Windows.Forms.TextBox();
			this.btnTopUp = new System.Windows.Forms.Button();
			this.btnTrans = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(74, 49);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(298, 174);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(345, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Daily Tollgate Transactions Dashboard";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 238);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(437, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "*NB make sure hardware is connected and tollgate name is selected below!!";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 270);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(137, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "COMPORT SEL:";
			// 
			// cmbPORT
			// 
			this.cmbPORT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbPORT.FormattingEnabled = true;
			this.cmbPORT.Location = new System.Drawing.Point(144, 271);
			this.cmbPORT.Name = "cmbPORT";
			this.cmbPORT.Size = new System.Drawing.Size(103, 27);
			this.cmbPORT.TabIndex = 4;
			// 
			// btnConnect
			// 
			this.btnConnect.BackColor = System.Drawing.Color.White;
			this.btnConnect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConnect.Location = new System.Drawing.Point(268, 270);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(166, 28);
			this.btnConnect.TabIndex = 5;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = false;
			this.btnConnect.Click += new System.EventHandler(this.BtnConnectClick);
			// 
			// btnDisconnect
			// 
			this.btnDisconnect.BackColor = System.Drawing.Color.White;
			this.btnDisconnect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDisconnect.Location = new System.Drawing.Point(268, 271);
			this.btnDisconnect.Name = "btnDisconnect";
			this.btnDisconnect.Size = new System.Drawing.Size(166, 28);
			this.btnDisconnect.TabIndex = 6;
			this.btnDisconnect.Text = "Disconnect";
			this.btnDisconnect.UseVisualStyleBackColor = false;
			this.btnDisconnect.Click += new System.EventHandler(this.BtnDisconnectClick);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(13, 309);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(137, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "TOLLGATE SEL:";
			// 
			// cmbTollgate
			// 
			this.cmbTollgate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbTollgate.FormattingEnabled = true;
			this.cmbTollgate.Items.AddRange(new object[] {
			"TollgateA",
			"TollgateB",
			"TollgateC",
			"TollgateD"});
			this.cmbTollgate.Location = new System.Drawing.Point(144, 305);
			this.cmbTollgate.Name = "cmbTollgate";
			this.cmbTollgate.Size = new System.Drawing.Size(290, 27);
			this.cmbTollgate.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 346);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(137, 23);
			this.label5.TabIndex = 3;
			this.label5.Text = "CAR NUMBER:";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(245, 349);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(137, 23);
			this.label6.TabIndex = 3;
			this.label6.Text = "BALANCE:$";
			// 
			// txtCardnumber
			// 
			this.txtCardnumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCardnumber.Location = new System.Drawing.Point(144, 346);
			this.txtCardnumber.Name = "txtCardnumber";
			this.txtCardnumber.Size = new System.Drawing.Size(103, 26);
			this.txtCardnumber.TabIndex = 8;
			// 
			// txtBalance
			// 
			this.txtBalance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBalance.Location = new System.Drawing.Point(344, 346);
			this.txtBalance.Name = "txtBalance";
			this.txtBalance.Size = new System.Drawing.Size(90, 26);
			this.txtBalance.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(13, 388);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(198, 23);
			this.label7.TabIndex = 9;
			this.label7.Text = "Subscription Section:";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(13, 421);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(117, 23);
			this.label8.TabIndex = 10;
			this.label8.Text = "Enter Amount:";
			// 
			// txtAmntTopUp
			// 
			this.txtAmntTopUp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAmntTopUp.Location = new System.Drawing.Point(144, 418);
			this.txtAmntTopUp.Name = "txtAmntTopUp";
			this.txtAmntTopUp.Size = new System.Drawing.Size(111, 26);
			this.txtAmntTopUp.TabIndex = 8;
			// 
			// btnTopUp
			// 
			this.btnTopUp.BackColor = System.Drawing.Color.White;
			this.btnTopUp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTopUp.Location = new System.Drawing.Point(268, 418);
			this.btnTopUp.Name = "btnTopUp";
			this.btnTopUp.Size = new System.Drawing.Size(166, 26);
			this.btnTopUp.TabIndex = 11;
			this.btnTopUp.Text = "TopUp";
			this.btnTopUp.UseVisualStyleBackColor = false;
			this.btnTopUp.Click += new System.EventHandler(this.BtnTopUpClick);
			// 
			// btnTrans
			// 
			this.btnTrans.BackColor = System.Drawing.Color.White;
			this.btnTrans.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTrans.Location = new System.Drawing.Point(268, 454);
			this.btnTrans.Name = "btnTrans";
			this.btnTrans.Size = new System.Drawing.Size(166, 31);
			this.btnTrans.TabIndex = 12;
			this.btnTrans.Text = "Transaction Records";
			this.btnTrans.UseVisualStyleBackColor = false;
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.White;
			this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(144, 454);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(111, 31);
			this.btnExit.TabIndex = 13;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
			// 
			// TransactionsDashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Yellow;
			this.ClientSize = new System.Drawing.Size(447, 489);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnTrans);
			this.Controls.Add(this.btnTopUp);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtBalance);
			this.Controls.Add(this.txtAmntTopUp);
			this.Controls.Add(this.txtCardnumber);
			this.Controls.Add(this.cmbTollgate);
			this.Controls.Add(this.btnDisconnect);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.cmbPORT);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "TransactionsDashboard";
			this.Text = "TransactionsDashboard";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
>>>>>>> parent of 5a30ca7... commit message
