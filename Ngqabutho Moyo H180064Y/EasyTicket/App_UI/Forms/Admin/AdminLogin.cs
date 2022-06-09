using EasyTicket.App_UI.Forms.Admin;
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
    public partial class AdminLogin : Form
    {
        DB db = new DB();
        public Admin admin = new Admin();
        public AdminRevised admin_revised = new AdminRevised();

        public AdminLogin()
        {
            InitializeComponent();
        }

        //Check for blank fields
        private bool CheckBlankFields()
        {
            if ((txtAdminID.Text == "") || (txtPassword.Text == ""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();   
        }

        private void Login()
        {
            string admin_id = txtAdminID.Text;
            string password = txtPassword.Text;

            if (!CheckBlankFields())
            {
                if(db.LoginAdmin(admin_id, password))
                {
                    MessageBox.Show($"Welcome {admin_id}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    admin_revised.LoggedInUser(admin_id);
                    admin_revised.Show();
                }
                else
                {
                    MessageBox.Show("Your username or password is incorrect", "Incorrect Username or Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Fill in all fields", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AdminLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
