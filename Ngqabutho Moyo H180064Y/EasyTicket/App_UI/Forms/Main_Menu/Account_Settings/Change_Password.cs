<<<<<<< HEAD
﻿using EasyTicket.Forms.Main_Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using EasyTicket.Forms.Main_Menu;

namespace EasyTicket.App_UI.Forms.Main_Menu.Account_Settings
{
    public partial class Change_Password : Form
    {        
        public void SetLoggedInUsername(string user)
        {
            labelUsername.Text = user;
        }
        DB db = new DB();
        public Change_Password()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string user = labelUsername.Text;
            string new_password = txtNewPassword.Text;
            if (!CheckBlankFields() && CheckMatchingPasswords() && (db.ChangePassword(user, new_password)))
            {
                MessageBox.Show("Your password has been changed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Your password could not be changed", "Failed To Change Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool CheckBlankFields()
        {
            if((txtUsername.Text == "") || (txtOldPassword.Text == "") || (txtNewPassword.Text == "") || (txtConfirmNewPassword.Text == ""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckMatchingPasswords()
        {
            string password = txtNewPassword.Text;
            string confirm_password = txtConfirmNewPassword.Text;

            if(password == confirm_password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void llMainMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AccountSettings accountSettings = new AccountSettings();
            accountSettings.LoggedInUser(labelUsername.Text);
            accountSettings.ShowDialog();
        }
    }
}
=======
﻿using EasyTicket.Forms.Main_Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using EasyTicket.Forms.Main_Menu;

namespace EasyTicket.App_UI.Forms.Main_Menu.Account_Settings
{
    public partial class Change_Password : Form
    {        
        public void SetLoggedInUsername(string user)
        {
            labelUsername.Text = user;
        }
        DB db = new DB();
        public Change_Password()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string user = labelUsername.Text;
            string new_password = txtNewPassword.Text;
            if (!CheckBlankFields() && CheckMatchingPasswords() && (db.ChangePassword(user, new_password)))
            {
                MessageBox.Show("Your password has been changed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Your password could not be changed", "Failed To Change Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool CheckBlankFields()
        {
            if((txtUsername.Text == "") || (txtOldPassword.Text == "") || (txtNewPassword.Text == "") || (txtConfirmNewPassword.Text == ""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckMatchingPasswords()
        {
            string password = txtNewPassword.Text;
            string confirm_password = txtConfirmNewPassword.Text;

            if(password == confirm_password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void llMainMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AccountSettings accountSettings = new AccountSettings();
            accountSettings.LoggedInUser(labelUsername.Text);
            accountSettings.ShowDialog();
        }
    }
}
>>>>>>> parent of 5a30ca7... commit message
