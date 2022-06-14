<<<<<<< HEAD
﻿/*
 * Created by SharpDevelop.
 * User: 26378
 * Date: 4/4/2022
 * Time: 10:23 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Electronic_Tollgate
{
	partial class TollingAgentRegistration
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtFullname;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtIDNo;
		private System.Windows.Forms.TextBox txtEmpNo;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtCpassword;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnSave;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TollingAgentRegistration));
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtFullname = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtIDNo = new System.Windows.Forms.TextBox();
			this.txtEmpNo = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtCpassword = new System.Windows.Forms.TextBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(71, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(377, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tolling Agents Registration Dashboard";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(71, 46);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(298, 175);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 277);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Full Name:";
			// 
			// txtFullname
			// 
			this.txtFullname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFullname.Location = new System.Drawing.Point(149, 274);
			this.txtFullname.Name = "txtFullname";
			this.txtFullname.Size = new System.Drawing.Size(313, 26);
			this.txtFullname.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 315);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(131, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "ID No:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 362);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(131, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "Employee No:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 405);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(131, 23);
			this.label5.TabIndex = 2;
			this.label5.Text = "Password:";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 443);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(131, 23);
			this.label6.TabIndex = 2;
			this.label6.Text = "Confirm-Pass:";
			// 
			// txtIDNo
			// 
			this.txtIDNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIDNo.Location = new System.Drawing.Point(149, 315);
			this.txtIDNo.Name = "txtIDNo";
			this.txtIDNo.Size = new System.Drawing.Size(313, 26);
			this.txtIDNo.TabIndex = 3;
			// 
			// txtEmpNo
			// 
			this.txtEmpNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmpNo.Location = new System.Drawing.Point(149, 361);
			this.txtEmpNo.Name = "txtEmpNo";
			this.txtEmpNo.Size = new System.Drawing.Size(313, 26);
			this.txtEmpNo.TabIndex = 3;
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(149, 405);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(313, 26);
			this.txtPassword.TabIndex = 3;
			// 
			// txtCpassword
			// 
			this.txtCpassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCpassword.Location = new System.Drawing.Point(149, 442);
			this.txtCpassword.Name = "txtCpassword";
			this.txtCpassword.Size = new System.Drawing.Size(313, 26);
			this.txtCpassword.TabIndex = 3;
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.White;
			this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(149, 485);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(160, 33);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.White;
			this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(328, 485);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(134, 33);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// TollingAgentRegistration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Yellow;
			this.ClientSize = new System.Drawing.Size(465, 518);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.txtCpassword);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtEmpNo);
			this.Controls.Add(this.txtIDNo);
			this.Controls.Add(this.txtFullname);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Name = "TollingAgentRegistration";
			this.Text = "TollingAgentRegistration";
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
 * Time: 10:23 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Electronic_Tollgate
{
	partial class TollingAgentRegistration
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtFullname;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtIDNo;
		private System.Windows.Forms.TextBox txtEmpNo;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtCpassword;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnSave;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TollingAgentRegistration));
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtFullname = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtIDNo = new System.Windows.Forms.TextBox();
			this.txtEmpNo = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtCpassword = new System.Windows.Forms.TextBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(71, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(377, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tolling Agents Registration Dashboard";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(71, 46);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(298, 175);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 277);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Full Name:";
			// 
			// txtFullname
			// 
			this.txtFullname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFullname.Location = new System.Drawing.Point(149, 274);
			this.txtFullname.Name = "txtFullname";
			this.txtFullname.Size = new System.Drawing.Size(313, 26);
			this.txtFullname.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 315);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(131, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "ID No:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 362);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(131, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "Employee No:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 405);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(131, 23);
			this.label5.TabIndex = 2;
			this.label5.Text = "Password:";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 443);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(131, 23);
			this.label6.TabIndex = 2;
			this.label6.Text = "Confirm-Pass:";
			// 
			// txtIDNo
			// 
			this.txtIDNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIDNo.Location = new System.Drawing.Point(149, 315);
			this.txtIDNo.Name = "txtIDNo";
			this.txtIDNo.Size = new System.Drawing.Size(313, 26);
			this.txtIDNo.TabIndex = 3;
			// 
			// txtEmpNo
			// 
			this.txtEmpNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmpNo.Location = new System.Drawing.Point(149, 361);
			this.txtEmpNo.Name = "txtEmpNo";
			this.txtEmpNo.Size = new System.Drawing.Size(313, 26);
			this.txtEmpNo.TabIndex = 3;
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(149, 405);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(313, 26);
			this.txtPassword.TabIndex = 3;
			// 
			// txtCpassword
			// 
			this.txtCpassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCpassword.Location = new System.Drawing.Point(149, 442);
			this.txtCpassword.Name = "txtCpassword";
			this.txtCpassword.Size = new System.Drawing.Size(313, 26);
			this.txtCpassword.TabIndex = 3;
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.White;
			this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(149, 485);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(160, 33);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.White;
			this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(328, 485);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(134, 33);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// TollingAgentRegistration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Yellow;
			this.ClientSize = new System.Drawing.Size(465, 518);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.txtCpassword);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtEmpNo);
			this.Controls.Add(this.txtIDNo);
			this.Controls.Add(this.txtFullname);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Name = "TollingAgentRegistration";
			this.Text = "TollingAgentRegistration";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
>>>>>>> parent of 5a30ca7... commit message
