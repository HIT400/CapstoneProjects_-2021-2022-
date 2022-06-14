<<<<<<< HEAD
﻿using System;
using EasyTicket.Forms.Main_Menu;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Npgsql;
using NpgsqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyTicket.Forms
{
    public partial class Login : Form
    {
        DB db = new DB();
        public Register reg = new Register();
        public AdminLogin admin_login = new AdminLogin();

        public Login()
        {
            InitializeComponent();            
        }
        
        //Check for blank fields
        private bool CheckBlankFields()
        {
            if ((txtUsername.Text == "") || (txtPassword.Text == ""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Login event
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string pass = txtPassword.Text;

            //Fields should not be blank
            if (!CheckBlankFields())
            {
                if (db.LoginUser(username, pass))
                {
                    MessageBox.Show($"Welcome {username}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Main_Menu.Main_Menu mm = new Main_Menu.Main_Menu();
                    mm.LoggedInUsername(username);
                    mm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Your username or password is incorrect", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Enter your username and password", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void llRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            reg.ShowDialog();
        }

        private void llLoginAsAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            admin_login.Show();
        }
    }
}
=======
﻿using System;
using EasyTicket.Forms.Main_Menu;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Npgsql;
using NpgsqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyTicket.Forms
{
    public partial class Login : Form
    {
        DB db = new DB();
        public Register reg = new Register();
        public AdminLogin admin_login = new AdminLogin();

        public Login()
        {
            InitializeComponent();            
        }
        
        //Check for blank fields
        private bool CheckBlankFields()
        {
            if ((txtUsername.Text == "") || (txtPassword.Text == ""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Login event
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string pass = txtPassword.Text;

            //Fields should not be blank
            if (!CheckBlankFields())
            {
                if (db.LoginUser(username, pass))
                {
                    MessageBox.Show($"Welcome {username}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Main_Menu.Main_Menu mm = new Main_Menu.Main_Menu();
                    mm.LoggedInUsername(username);
                    mm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Your username or password is incorrect", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Enter your username and password", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void llRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            reg.ShowDialog();
        }

        private void llLoginAsAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            admin_login.Show();
        }
    }
}
>>>>>>> parent of 5a30ca7... commit message
