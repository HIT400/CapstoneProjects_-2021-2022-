using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTicket.App_UI.Forms.Main_Menu.Account_Settings;

namespace EasyTicket.Forms.Main_Menu
{
    public partial class Main_Menu : Form
    {
        public void LoggedInUsername(string username)
        {            
            labelUsername.Text = username;
        }

        public Main_Menu()
        {
            InitializeComponent();            
        }

        //Open Account Settings form
        private void llAccountSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            string user = labelUsername.Text;
            AccountSettings _as = new AccountSettings();
            _as.LoggedInUser(user);
            this.Hide();            
            _as.ShowDialog();
        }

        //Open Pay form
        private void llPay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string user = labelUsername.Text;
            Pay pay = new Pay();
            pay.LoggedInUser(user);
            this.Hide();
            pay.ShowDialog();
        }

        //Open Topup Account form
        private void llTopupAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string user = labelUsername.Text;
            TopupAccount topup = new TopupAccount();
            topup.LoggedInUser(user);
            this.Hide();
            topup.ShowDialog();
        }

        //Open Trip History form
        private void llTripHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string user = labelUsername.Text;
            TripHistory trip = new TripHistory();
            trip.LoggedInUsername(user);
            this.Hide();
            trip.ShowDialog();
        }       

        //Logging out
        private void llLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Press OK to log out", "Logging out", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        //Close application when user closes the form
        private void Main_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
