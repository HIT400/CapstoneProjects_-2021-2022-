namespace EasyTicket.App_UI.Forms.Admin
{
    partial class RevenuePerTerminus
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvBusStation = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ll = new System.Windows.Forms.Label();
            this.llBack = new System.Windows.Forms.LinkLabel();
            this.labelUsername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBusStation
            // 
            this.dgvBusStation.AllowUserToAddRows = false;
            this.dgvBusStation.AllowUserToDeleteRows = false;
            this.dgvBusStation.AllowUserToResizeColumns = false;
            this.dgvBusStation.AllowUserToResizeRows = false;
            this.dgvBusStation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusStation.Location = new System.Drawing.Point(631, 37);
            this.dgvBusStation.Name = "dgvBusStation";
            this.dgvBusStation.Size = new System.Drawing.Size(288, 401);
            this.dgvBusStation.TabIndex = 4;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 37);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Revenue";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(613, 401);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // ll
            // 
            this.ll.AutoSize = true;
            this.ll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll.Location = new System.Drawing.Point(383, 9);
            this.ll.Name = "ll";
            this.ll.Size = new System.Drawing.Size(252, 25);
            this.ll.TabIndex = 5;
            this.ll.Text = "Revenue Per Terminus";
            // 
            // llBack
            // 
            this.llBack.AutoSize = true;
            this.llBack.Location = new System.Drawing.Point(887, 9);
            this.llBack.Name = "llBack";
            this.llBack.Size = new System.Drawing.Size(32, 13);
            this.llBack.TabIndex = 6;
            this.llBack.TabStop = true;
            this.llBack.Text = "Back";
            this.llBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llBack_LinkClicked);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(826, 9);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 22;
            this.labelUsername.Text = "Username";
            // 
            // RevenuePerTerminus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.ControlBox = false;
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.llBack);
            this.Controls.Add(this.ll);
            this.Controls.Add(this.dgvBusStation);
            this.Controls.Add(this.chart1);
            this.MaximizeBox = false;
            this.Name = "RevenuePerTerminus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RevenuePerTerminus";
            this.Load += new System.EventHandler(this.RevenuePerTerminus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBusStation;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label ll;
        private System.Windows.Forms.LinkLabel llBack;
        private System.Windows.Forms.Label labelUsername;
    }
}