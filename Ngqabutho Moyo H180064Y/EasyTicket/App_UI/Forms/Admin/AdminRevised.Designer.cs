<<<<<<< HEAD
﻿namespace EasyTicket.App_UI.Forms.Admin
{
    partial class AdminRevised
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvActiveUsers = new System.Windows.Forms.DataGridView();
            this.dgvNonActiveUsers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelUsername = new System.Windows.Forms.Label();
            this.llLogout = new System.Windows.Forms.LinkLabel();
            this.llRevenuePerTerminus = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNonActiveUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActiveUsers
            // 
            this.dgvActiveUsers.AllowUserToAddRows = false;
            this.dgvActiveUsers.AllowUserToDeleteRows = false;
            this.dgvActiveUsers.AllowUserToResizeColumns = false;
            this.dgvActiveUsers.AllowUserToResizeRows = false;
            this.dgvActiveUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActiveUsers.Location = new System.Drawing.Point(12, 34);
            this.dgvActiveUsers.Name = "dgvActiveUsers";
            this.dgvActiveUsers.ReadOnly = true;
            this.dgvActiveUsers.Size = new System.Drawing.Size(366, 238);
            this.dgvActiveUsers.TabIndex = 0;
            // 
            // dgvNonActiveUsers
            // 
            this.dgvNonActiveUsers.AllowUserToAddRows = false;
            this.dgvNonActiveUsers.AllowUserToDeleteRows = false;
            this.dgvNonActiveUsers.AllowUserToResizeColumns = false;
            this.dgvNonActiveUsers.AllowUserToResizeRows = false;
            this.dgvNonActiveUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNonActiveUsers.Location = new System.Drawing.Point(12, 298);
            this.dgvNonActiveUsers.Name = "dgvNonActiveUsers";
            this.dgvNonActiveUsers.ReadOnly = true;
            this.dgvNonActiveUsers.Size = new System.Drawing.Size(217, 150);
            this.dgvNonActiveUsers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Active Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Non-Active Users";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(384, 34);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Revenues";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(493, 414);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(771, 15);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 21;
            this.labelUsername.Text = "Username";
            // 
            // llLogout
            // 
            this.llLogout.AutoSize = true;
            this.llLogout.Location = new System.Drawing.Point(832, 15);
            this.llLogout.Name = "llLogout";
            this.llLogout.Size = new System.Drawing.Size(45, 13);
            this.llLogout.TabIndex = 57;
            this.llLogout.TabStop = true;
            this.llLogout.Text = "Log Out";
            this.llLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLogout_LinkClicked);
            // 
            // llRevenuePerTerminus
            // 
            this.llRevenuePerTerminus.AutoSize = true;
            this.llRevenuePerTerminus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.llRevenuePerTerminus.Location = new System.Drawing.Point(381, 470);
            this.llRevenuePerTerminus.Name = "llRevenuePerTerminus";
            this.llRevenuePerTerminus.Size = new System.Drawing.Size(116, 13);
            this.llRevenuePerTerminus.TabIndex = 58;
            this.llRevenuePerTerminus.TabStop = true;
            this.llRevenuePerTerminus.Text = "Revenue Per Terminus";
            this.llRevenuePerTerminus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRevenuePerTerminus_LinkClicked);
            // 
            // AdminRevised
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 511);
            this.ControlBox = false;
            this.Controls.Add(this.llRevenuePerTerminus);
            this.Controls.Add(this.llLogout);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNonActiveUsers);
            this.Controls.Add(this.dgvActiveUsers);
            this.Name = "AdminRevised";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminRevised";
            this.Load += new System.EventHandler(this.AdminRevised_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNonActiveUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActiveUsers;
        private System.Windows.Forms.DataGridView dgvNonActiveUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.LinkLabel llLogout;
        private System.Windows.Forms.LinkLabel llRevenuePerTerminus;
    }
=======
﻿namespace EasyTicket.App_UI.Forms.Admin
{
    partial class AdminRevised
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvActiveUsers = new System.Windows.Forms.DataGridView();
            this.dgvNonActiveUsers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelUsername = new System.Windows.Forms.Label();
            this.llLogout = new System.Windows.Forms.LinkLabel();
            this.llRevenuePerTerminus = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNonActiveUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActiveUsers
            // 
            this.dgvActiveUsers.AllowUserToAddRows = false;
            this.dgvActiveUsers.AllowUserToDeleteRows = false;
            this.dgvActiveUsers.AllowUserToResizeColumns = false;
            this.dgvActiveUsers.AllowUserToResizeRows = false;
            this.dgvActiveUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActiveUsers.Location = new System.Drawing.Point(12, 34);
            this.dgvActiveUsers.Name = "dgvActiveUsers";
            this.dgvActiveUsers.ReadOnly = true;
            this.dgvActiveUsers.Size = new System.Drawing.Size(366, 238);
            this.dgvActiveUsers.TabIndex = 0;
            // 
            // dgvNonActiveUsers
            // 
            this.dgvNonActiveUsers.AllowUserToAddRows = false;
            this.dgvNonActiveUsers.AllowUserToDeleteRows = false;
            this.dgvNonActiveUsers.AllowUserToResizeColumns = false;
            this.dgvNonActiveUsers.AllowUserToResizeRows = false;
            this.dgvNonActiveUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNonActiveUsers.Location = new System.Drawing.Point(12, 298);
            this.dgvNonActiveUsers.Name = "dgvNonActiveUsers";
            this.dgvNonActiveUsers.ReadOnly = true;
            this.dgvNonActiveUsers.Size = new System.Drawing.Size(217, 150);
            this.dgvNonActiveUsers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Active Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Non-Active Users";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(384, 34);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Revenues";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(493, 414);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(771, 15);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 21;
            this.labelUsername.Text = "Username";
            // 
            // llLogout
            // 
            this.llLogout.AutoSize = true;
            this.llLogout.Location = new System.Drawing.Point(832, 15);
            this.llLogout.Name = "llLogout";
            this.llLogout.Size = new System.Drawing.Size(45, 13);
            this.llLogout.TabIndex = 57;
            this.llLogout.TabStop = true;
            this.llLogout.Text = "Log Out";
            this.llLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLogout_LinkClicked);
            // 
            // llRevenuePerTerminus
            // 
            this.llRevenuePerTerminus.AutoSize = true;
            this.llRevenuePerTerminus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.llRevenuePerTerminus.Location = new System.Drawing.Point(381, 470);
            this.llRevenuePerTerminus.Name = "llRevenuePerTerminus";
            this.llRevenuePerTerminus.Size = new System.Drawing.Size(116, 13);
            this.llRevenuePerTerminus.TabIndex = 58;
            this.llRevenuePerTerminus.TabStop = true;
            this.llRevenuePerTerminus.Text = "Revenue Per Terminus";
            this.llRevenuePerTerminus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRevenuePerTerminus_LinkClicked);
            // 
            // AdminRevised
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 511);
            this.ControlBox = false;
            this.Controls.Add(this.llRevenuePerTerminus);
            this.Controls.Add(this.llLogout);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNonActiveUsers);
            this.Controls.Add(this.dgvActiveUsers);
            this.Name = "AdminRevised";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminRevised";
            this.Load += new System.EventHandler(this.AdminRevised_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNonActiveUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActiveUsers;
        private System.Windows.Forms.DataGridView dgvNonActiveUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.LinkLabel llLogout;
        private System.Windows.Forms.LinkLabel llRevenuePerTerminus;
    }
>>>>>>> parent of 5a30ca7... commit message
}