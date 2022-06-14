/*
 * Created by SharpDevelop.
 * User: 26378
 * Date: 3/31/2022
 * Time: 12:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Electronic_Tollgate
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnSignUp;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.ComboBox cmbOfficial;
		private System.Windows.Forms.Label label4;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnSignUp = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.cmbOfficial = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(58, 62);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(300, 171);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(39, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(411, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Welcome To Electronic Tolling";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(39, 265);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(139, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Admin Name: ";
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(170, 267);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(264, 29);
			this.txtName.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(39, 339);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(139, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Password: ";
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(170, 334);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(264, 29);
			this.txtPassword.TabIndex = 3;
			// 
			// btnSignUp
			// 
			this.btnSignUp.BackColor = System.Drawing.Color.White;
			this.btnSignUp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSignUp.Location = new System.Drawing.Point(170, 443);
			this.btnSignUp.Name = "btnSignUp";
			this.btnSignUp.Size = new System.Drawing.Size(115, 34);
			this.btnSignUp.TabIndex = 4;
			this.btnSignUp.Text = "SignUp";
			this.btnSignUp.UseVisualStyleBackColor = false;
			this.btnSignUp.Click += new System.EventHandler(this.BtnSignUpClick);
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.White;
			this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Location = new System.Drawing.Point(324, 443);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(110, 34);
			this.btnLogin.TabIndex = 5;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.BtnLoginClick);
			// 
			// cmbOfficial
			// 
			this.cmbOfficial.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbOfficial.FormattingEnabled = true;
			this.cmbOfficial.Items.AddRange(new object[] {
			"ZINARA ADMINSTRATOR",
			"TOLLING AGENT"});
			this.cmbOfficial.Location = new System.Drawing.Point(170, 392);
			this.cmbOfficial.Name = "cmbOfficial";
			this.cmbOfficial.Size = new System.Drawing.Size(264, 27);
			this.cmbOfficial.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(39, 392);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(139, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "Position: ";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Yellow;
			this.ClientSize = new System.Drawing.Size(446, 478);
			this.Controls.Add(this.cmbOfficial);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.btnSignUp);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "MainForm";
			this.Text = "Electronic_Tollgate";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
