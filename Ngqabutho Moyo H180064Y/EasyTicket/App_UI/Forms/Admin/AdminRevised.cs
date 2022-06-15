<<<<<<< HEAD
﻿using EasyTicket.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyTicket.App_UI.Forms.Admin
{
    public partial class AdminRevised : Form
    {
        DB db = new DB();        
        public AdminRevised()
        {
            InitializeComponent();
        }

        public void LoggedInUser(string username)
        {
            labelUsername.Text = username;
        }

        private void btnLoadPieChart_Click(object sender, EventArgs e)
        {
            //LoadPieChart();
            //btnLoadPieChart.Enabled = false;
        }

        private void LoadPieChart()
        {
            try
            {
                //dgvActiveUsers.DataSource = db.SelectActiveUsers();
                //dgvNonActiveUsers.DataSource = db.SelectNonActiveUsers();
                //chart1.Series["Revenues"].Points.Clear();
                chart1.DataSource = db.SelectActiveUsers();
                chart1.Series["Revenues"].XValueMember = "commuter";
                chart1.Series["Revenues"].YValueMembers = "revenue";
                chart1.DataBind();
                //btnLoadPieChart.Enabled = false;
                //chart1.Series["Revenues"].Points.Clear();
                dgvActiveUsers.DataSource = chart1.DataSource;
                dgvActiveUsers.DataSource = db.CalculateRevenue();
                dgvNonActiveUsers.DataSource = db.SelectNonActiveUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminRevised_Load(object sender, EventArgs e)
        {
            LoadPieChart();            
        }

        private void llLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void llRevenuePerTerminus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RevenuePerTerminus rpt = new RevenuePerTerminus();
            rpt.LoggedInUser(labelUsername.Text);
            rpt.ShowDialog();
        }
    }
}
=======
﻿using EasyTicket.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyTicket.App_UI.Forms.Admin
{
    public partial class AdminRevised : Form
    {
        DB db = new DB();        
        public AdminRevised()
        {
            InitializeComponent();
        }

        public void LoggedInUser(string username)
        {
            labelUsername.Text = username;
        }

        private void btnLoadPieChart_Click(object sender, EventArgs e)
        {
            //LoadPieChart();
            //btnLoadPieChart.Enabled = false;
        }

        private void LoadPieChart()
        {
            try
            {
                //dgvActiveUsers.DataSource = db.SelectActiveUsers();
                //dgvNonActiveUsers.DataSource = db.SelectNonActiveUsers();
                //chart1.Series["Revenues"].Points.Clear();
                chart1.DataSource = db.SelectActiveUsers();
                chart1.Series["Revenues"].XValueMember = "commuter";
                chart1.Series["Revenues"].YValueMembers = "revenue";
                chart1.DataBind();
                //btnLoadPieChart.Enabled = false;
                //chart1.Series["Revenues"].Points.Clear();
                dgvActiveUsers.DataSource = chart1.DataSource;
                dgvActiveUsers.DataSource = db.CalculateRevenue();
                dgvNonActiveUsers.DataSource = db.SelectNonActiveUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminRevised_Load(object sender, EventArgs e)
        {
            LoadPieChart();            
        }

        private void llLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void llRevenuePerTerminus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RevenuePerTerminus rpt = new RevenuePerTerminus();
            rpt.LoggedInUser(labelUsername.Text);
            rpt.ShowDialog();
        }
    }
}
>>>>>>> parent of 5a30ca7... commit message
