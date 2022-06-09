using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyTicket
{
    public partial class VerifyPassword : Form
    {
        DataTable dt = new DataTable();
        DB db = new DB();

        public bool is_verified;

        public VerifyPassword()
        {
            InitializeComponent();
        }        

        //Display logged in user in the top right corner
        public void LoggedInUser(string username)
        {
            labelUsername.Text = username;
        }        

        private void btnVerify_Click_1(object sender, EventArgs e)
        {
            string username = labelUsername.Text;
            string password = txtPassword.Text;

            if (db.VerifyPassword(username, password))
            {
                is_verified = true;
                MessageBox.Show("Password verified", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Text = "";
            }
            else
            {
                is_verified = false;
                MessageBox.Show("Your password is incorrect", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Text = "";
            }
        }
    }
}
