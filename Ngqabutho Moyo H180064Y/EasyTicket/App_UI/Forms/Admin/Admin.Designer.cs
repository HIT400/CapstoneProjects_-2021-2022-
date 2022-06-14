<<<<<<< HEAD
﻿namespace EasyTicket
{
    partial class Admin
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
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvActiveUsers = new System.Windows.Forms.DataGridView();
            this.dgvNonActiveUsers = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.dgvCommuters = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNonActiveUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommuters)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AllowUserToAddRows = false;
            this.dgvAdmin.AllowUserToDeleteRows = false;
            this.dgvAdmin.AllowUserToResizeColumns = false;
            this.dgvAdmin.AllowUserToResizeRows = false;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Location = new System.Drawing.Point(11, 66);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.Size = new System.Drawing.Size(212, 76);
            this.dgvAdmin.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total Revenue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Active Users";
            // 
            // dgvActiveUsers
            // 
            this.dgvActiveUsers.AllowUserToAddRows = false;
            this.dgvActiveUsers.AllowUserToDeleteRows = false;
            this.dgvActiveUsers.AllowUserToResizeColumns = false;
            this.dgvActiveUsers.AllowUserToResizeRows = false;
            this.dgvActiveUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActiveUsers.Location = new System.Drawing.Point(315, 66);
            this.dgvActiveUsers.Name = "dgvActiveUsers";
            this.dgvActiveUsers.Size = new System.Drawing.Size(212, 208);
            this.dgvActiveUsers.TabIndex = 17;
            // 
            // dgvNonActiveUsers
            // 
            this.dgvNonActiveUsers.AllowUserToAddRows = false;
            this.dgvNonActiveUsers.AllowUserToDeleteRows = false;
            this.dgvNonActiveUsers.AllowUserToResizeColumns = false;
            this.dgvNonActiveUsers.AllowUserToResizeRows = false;
            this.dgvNonActiveUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNonActiveUsers.Location = new System.Drawing.Point(11, 182);
            this.dgvNonActiveUsers.Name = "dgvNonActiveUsers";
            this.dgvNonActiveUsers.Size = new System.Drawing.Size(212, 92);
            this.dgvNonActiveUsers.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Non Active Users";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(495, 9);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 20;
            this.labelUsername.Text = "Username";
            // 
            // dgvCommuters
            // 
            this.dgvCommuters.AllowUserToAddRows = false;
            this.dgvCommuters.AllowUserToDeleteRows = false;
            this.dgvCommuters.AllowUserToResizeColumns = false;
            this.dgvCommuters.AllowUserToResizeRows = false;
            this.dgvCommuters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommuters.Location = new System.Drawing.Point(315, 280);
            this.dgvCommuters.Name = "dgvCommuters";
            this.dgvCommuters.Size = new System.Drawing.Size(212, 208);
            this.dgvCommuters.TabIndex = 21;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 496);
            this.ControlBox = false;
            this.Controls.Add(this.dgvCommuters);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.dgvNonActiveUsers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvActiveUsers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAdmin);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNonActiveUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommuters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvActiveUsers;
        private System.Windows.Forms.DataGridView dgvNonActiveUsers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.DataGridView dgvCommuters;
    }
=======
﻿namespace EasyTicket
{
    partial class Admin
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
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvActiveUsers = new System.Windows.Forms.DataGridView();
            this.dgvNonActiveUsers = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.dgvCommuters = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNonActiveUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommuters)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AllowUserToAddRows = false;
            this.dgvAdmin.AllowUserToDeleteRows = false;
            this.dgvAdmin.AllowUserToResizeColumns = false;
            this.dgvAdmin.AllowUserToResizeRows = false;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Location = new System.Drawing.Point(11, 66);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.Size = new System.Drawing.Size(212, 76);
            this.dgvAdmin.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total Revenue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Active Users";
            // 
            // dgvActiveUsers
            // 
            this.dgvActiveUsers.AllowUserToAddRows = false;
            this.dgvActiveUsers.AllowUserToDeleteRows = false;
            this.dgvActiveUsers.AllowUserToResizeColumns = false;
            this.dgvActiveUsers.AllowUserToResizeRows = false;
            this.dgvActiveUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActiveUsers.Location = new System.Drawing.Point(315, 66);
            this.dgvActiveUsers.Name = "dgvActiveUsers";
            this.dgvActiveUsers.Size = new System.Drawing.Size(212, 208);
            this.dgvActiveUsers.TabIndex = 17;
            // 
            // dgvNonActiveUsers
            // 
            this.dgvNonActiveUsers.AllowUserToAddRows = false;
            this.dgvNonActiveUsers.AllowUserToDeleteRows = false;
            this.dgvNonActiveUsers.AllowUserToResizeColumns = false;
            this.dgvNonActiveUsers.AllowUserToResizeRows = false;
            this.dgvNonActiveUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNonActiveUsers.Location = new System.Drawing.Point(11, 182);
            this.dgvNonActiveUsers.Name = "dgvNonActiveUsers";
            this.dgvNonActiveUsers.Size = new System.Drawing.Size(212, 92);
            this.dgvNonActiveUsers.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Non Active Users";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(495, 9);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 20;
            this.labelUsername.Text = "Username";
            // 
            // dgvCommuters
            // 
            this.dgvCommuters.AllowUserToAddRows = false;
            this.dgvCommuters.AllowUserToDeleteRows = false;
            this.dgvCommuters.AllowUserToResizeColumns = false;
            this.dgvCommuters.AllowUserToResizeRows = false;
            this.dgvCommuters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommuters.Location = new System.Drawing.Point(315, 280);
            this.dgvCommuters.Name = "dgvCommuters";
            this.dgvCommuters.Size = new System.Drawing.Size(212, 208);
            this.dgvCommuters.TabIndex = 21;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 496);
            this.ControlBox = false;
            this.Controls.Add(this.dgvCommuters);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.dgvNonActiveUsers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvActiveUsers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAdmin);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNonActiveUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommuters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvActiveUsers;
        private System.Windows.Forms.DataGridView dgvNonActiveUsers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.DataGridView dgvCommuters;
    }
>>>>>>> parent of 5a30ca7... commit message
}