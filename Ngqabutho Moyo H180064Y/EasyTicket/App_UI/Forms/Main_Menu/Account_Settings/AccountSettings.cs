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
    public partial class AccountSettings : Form
    {
        DB db = new DB();
        VerifyPassword verify = new VerifyPassword();
        Register register = new Register();
        Main_Menu mm = new Main_Menu();
        
        //Assign logged in username
        public void LoggedInUser(string username)
        {
            labelUsername.Text = username;              
        }

        public AccountSettings()
        {
            InitializeComponent();
        }

        //Hide form; display 'Edit Personal Info' form
        private void llEditPersonalInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string user = labelUsername.Text;
            this.Hide();
            Update_Personal_Info update = new Update_Personal_Info();
            update.SetLoggedInUsername(user);
            update.ShowDialog();
        }

        private void llChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string user = labelUsername.Text;
            this.Hide();
            Change_Password cp = new Change_Password();
            cp.SetLoggedInUsername(user);
            cp.ShowDialog();
        }

        private void AccountSettings_Load(object sender, EventArgs e)
        {

        }

        private void llUnsubscribe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string user = labelUsername.Text;
            verify.LoggedInUser(user);
            if(verify.ShowDialog() == DialogResult.OK)
            {
                if (verify.is_verified && db.DeleteAccount(user))
                {
                    MessageBox.Show("Your account has been deleted successfully", "Account Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();                    
                    register.Show();
                }
                else
                {
                    MessageBox.Show("Your account could not be deleted", "Failed To Unsubscribe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void llMainMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string user = labelUsername.Text;
            mm.LoggedInUsername(user);
            this.Hide();
            mm.ShowDialog();            
        }

        private void AccountSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
