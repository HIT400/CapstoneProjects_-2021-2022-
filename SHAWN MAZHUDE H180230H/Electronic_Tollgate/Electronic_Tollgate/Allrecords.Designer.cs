<<<<<<< HEAD
﻿/*
 * Created by SharpDevelop.
 * User: 26378
 * Date: 5/1/2022
 * Time: 11:27 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Electronic_Tollgate
{
	partial class Allrecords
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmboptions;
		private System.Windows.Forms.Button btnload;
		private System.Windows.Forms.TextBox txttrans;
		private System.Windows.Forms.TextBox txtamnt;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.cmboptions = new System.Windows.Forms.ComboBox();
			this.btnload = new System.Windows.Forms.Button();
			this.txttrans = new System.Windows.Forms.TextBox();
			this.txtamnt = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(742, 374);
			this.dataGridView1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(12, 411);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(164, 31);
			this.label1.TabIndex = 1;
			this.label1.Text = "Select Option:";
			// 
			// cmboptions
			// 
			this.cmboptions.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmboptions.FormattingEnabled = true;
			this.cmboptions.Items.AddRange(new object[] {
			"TollgateA",
			"TollgateB",
			"TollgateC",
			"TollgateD",
			"Records"});
			this.cmboptions.Location = new System.Drawing.Point(157, 413);
			this.cmboptions.Name = "cmboptions";
			this.cmboptions.Size = new System.Drawing.Size(268, 29);
			this.cmboptions.TabIndex = 2;
			// 
			// btnload
			// 
			this.btnload.BackColor = System.Drawing.Color.White;
			this.btnload.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnload.ForeColor = System.Drawing.Color.Black;
			this.btnload.Location = new System.Drawing.Point(157, 454);
			this.btnload.Name = "btnload";
			this.btnload.Size = new System.Drawing.Size(268, 28);
			this.btnload.TabIndex = 3;
			this.btnload.Text = "LOAD";
			this.btnload.UseVisualStyleBackColor = false;
			this.btnload.Click += new System.EventHandler(this.Button1Click);
			// 
			// txttrans
			// 
			this.txttrans.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txttrans.Location = new System.Drawing.Point(572, 411);
			this.txttrans.Name = "txttrans";
			this.txttrans.Size = new System.Drawing.Size(100, 26);
			this.txttrans.TabIndex = 4;
			// 
			// txtamnt
			// 
			this.txtamnt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtamnt.Location = new System.Drawing.Point(572, 456);
			this.txtamnt.Name = "txtamnt";
			this.txtamnt.Size = new System.Drawing.Size(100, 26);
			this.txtamnt.TabIndex = 4;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.White;
			this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(690, 411);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 31);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.White;
			this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(690, 456);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 29);
			this.btnExit.TabIndex = 6;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(431, 411);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "TransNumber";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(431, 454);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Amount";
			// 
			// Allrecords
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Yellow;
			this.ClientSize = new System.Drawing.Size(766, 497);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtamnt);
			this.Controls.Add(this.txttrans);
			this.Controls.Add(this.btnload);
			this.Controls.Add(this.cmboptions);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Allrecords";
			this.Text = "Allrecords";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
=======
﻿/*
 * Created by SharpDevelop.
 * User: 26378
 * Date: 5/1/2022
 * Time: 11:27 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Electronic_Tollgate
{
	partial class Allrecords
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmboptions;
		private System.Windows.Forms.Button btnload;
		private System.Windows.Forms.TextBox txttrans;
		private System.Windows.Forms.TextBox txtamnt;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.cmboptions = new System.Windows.Forms.ComboBox();
			this.btnload = new System.Windows.Forms.Button();
			this.txttrans = new System.Windows.Forms.TextBox();
			this.txtamnt = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(742, 374);
			this.dataGridView1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(12, 411);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(164, 31);
			this.label1.TabIndex = 1;
			this.label1.Text = "Select Option:";
			// 
			// cmboptions
			// 
			this.cmboptions.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmboptions.FormattingEnabled = true;
			this.cmboptions.Items.AddRange(new object[] {
			"TollgateA",
			"TollgateB",
			"TollgateC",
			"TollgateD",
			"Records"});
			this.cmboptions.Location = new System.Drawing.Point(157, 413);
			this.cmboptions.Name = "cmboptions";
			this.cmboptions.Size = new System.Drawing.Size(268, 29);
			this.cmboptions.TabIndex = 2;
			// 
			// btnload
			// 
			this.btnload.BackColor = System.Drawing.Color.White;
			this.btnload.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnload.ForeColor = System.Drawing.Color.Black;
			this.btnload.Location = new System.Drawing.Point(157, 454);
			this.btnload.Name = "btnload";
			this.btnload.Size = new System.Drawing.Size(268, 28);
			this.btnload.TabIndex = 3;
			this.btnload.Text = "LOAD";
			this.btnload.UseVisualStyleBackColor = false;
			this.btnload.Click += new System.EventHandler(this.Button1Click);
			// 
			// txttrans
			// 
			this.txttrans.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txttrans.Location = new System.Drawing.Point(572, 411);
			this.txttrans.Name = "txttrans";
			this.txttrans.Size = new System.Drawing.Size(100, 26);
			this.txttrans.TabIndex = 4;
			// 
			// txtamnt
			// 
			this.txtamnt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtamnt.Location = new System.Drawing.Point(572, 456);
			this.txtamnt.Name = "txtamnt";
			this.txtamnt.Size = new System.Drawing.Size(100, 26);
			this.txtamnt.TabIndex = 4;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.White;
			this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(690, 411);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 31);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.White;
			this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(690, 456);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 29);
			this.btnExit.TabIndex = 6;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(431, 411);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "TransNumber";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(431, 454);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Amount";
			// 
			// Allrecords
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Yellow;
			this.ClientSize = new System.Drawing.Size(766, 497);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtamnt);
			this.Controls.Add(this.txttrans);
			this.Controls.Add(this.btnload);
			this.Controls.Add(this.cmboptions);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Allrecords";
			this.Text = "Allrecords";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
>>>>>>> parent of 5a30ca7... commit message
