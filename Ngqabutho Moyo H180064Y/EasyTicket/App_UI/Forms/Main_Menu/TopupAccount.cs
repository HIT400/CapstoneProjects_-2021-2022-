<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using EasyTicket.Forms.Main_Menu;

namespace EasyTicket.Forms.Main_Menu
{
    public partial class TopupAccount : Form
    {
        //initialize a database instance
        DB db = new DB();
        Main_Menu mm = new Main_Menu();
        VerifyPassword verify = new VerifyPassword();

        //Assign username to labelUsername
        public void LoggedInUser(string username)
        {
            labelUsername.Text = username;
        }

        public TopupAccount()
        {
            InitializeComponent();
        }
        
        //Check for blank fields
        private bool CheckBlankFields()
        {
            if(txtAmount.Text == "" || 
                txtCurrentBalance.Text == "" || 
                txtNewBalance.Text == "" ||
                txtAccountNumber.Text == "" ||
                txtAccountNumber.Text == "000" ||
                txtNewBalance.Text == "" ||
                cbBank.SelectedItem.ToString() == "" || 
                cbTransactionType.SelectedItem.ToString() == "" ||
                txtAccountNumber.Text =="")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Topup amount cannot be $0.00 or less
        private bool CheckMinimumTopup(double topup_amount)
        {
            if (topup_amount <= 100.00)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        //Topup amount cannot be above $10 000
        private bool CheckTopupLimit(double topup_amount)
        {
            if(topup_amount > 10000.00)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        //Topup function: returns current balance + topup amount
        private double CalculateNewBalance(double current_balance, double topup_amount)
        {
            return current_balance + topup_amount;
        }
        
        //Function for populating datagrid view using the logged in user's username
        private void LoadDataGridView(string username)
        {            
            DataTable dt = new DataTable();
            using (NpgsqlConnection connection = db.GetConnection())
            {
                string select = "SELECT username, balance FROM public.commuter WHERE username=@username";
                NpgsqlCommand command = new NpgsqlCommand(select, connection);
                command.Parameters.AddWithValue(@"username", username);                
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                da.Fill(dt);
                dgvTopup.DataSource = dt;                
            }
        }

        private void TopupAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Assign username to username label when the form loads
        private void TopupAccount_Load(object sender, EventArgs e)
        {
            LoadDataGridView(labelUsername.Text);
            cbBank.SelectedItem = "CBZ";
            cbTransactionType.SelectedItem = "ZIPIT";           
        }

        //Preview event: preview changes before saving
        private void btnPreview_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvTopup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvTopup.Rows[e.RowIndex];
            txtCurrentBalance.Text = row.Cells["balance"].Value.ToString();
        }

        private void dgvTopup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvTopup.Rows[e.RowIndex];
            txtCurrentBalance.Text = row.Cells["balance"].Value.ToString();
        }

        //Back event: hide current form and show main menu
        private void llBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            Main_Menu mm = new Main_Menu();
            mm.LoggedInUsername(labelUsername.Text);
            this.Hide();
            mm.ShowDialog();
        }
        

        //Save event: commit changes to public.commuter
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string username = labelUsername.Text;
            string bank = cbBank.SelectedItem.ToString();
            string account_num = txtAccountNumber.Text;
            double current_balance = Convert.ToDouble(txtCurrentBalance.Text);
            double top_up_amount = Convert.ToDouble(txtAmount.Text);
            double new_balance = CalculateNewBalance(current_balance, top_up_amount);

            //Check for blank fields
            if (!CheckBlankFields())
            {
                //btnSave.Enabled = true;
                //Check if topup is $0.00 or less
                if (!CheckMinimumTopup(top_up_amount))
                {
                    //Check if topup is above $10 000
                    if (!CheckTopupLimit(top_up_amount))
                    {
                        try
                        {
                            //Verify the user's password before topping up
                            verify.LoggedInUser(username);
                            if (verify.ShowDialog() == DialogResult.OK)
                            {
                                if (verify.is_verified && db.UpdateCommuterBalance(username, new_balance))
                                {
                                    MessageBox.Show($"Your new balance is ${new_balance}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Hide();
                                    Main_Menu mm = new Main_Menu();
                                    mm.LoggedInUsername(labelUsername.Text);
                                    mm.ShowDialog();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update account", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("You have exceeded your transaction limit of $10 000", "Invalid Topup Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Topup amount cannot be <=$100.00", "Invalid Topup Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Fill in all fields", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Event: preview prior to saving
        private void btnPreview_Click_1(object sender, EventArgs e)
        {
            try
            {
                double current_balance = Convert.ToDouble(txtCurrentBalance.Text);
                double top_up_amount = Convert.ToDouble(txtAmount.Text);
                double new_balance = CalculateNewBalance(current_balance, top_up_amount);
                txtNewBalance.Text = Convert.ToString(new_balance);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTransactionType.Items.Clear();
            if (cbBank.SelectedItem.ToString() == "EcoCash")
            {
                cbTransactionType.Items.Add("ZIPIT");
            }
            else
            {
                cbTransactionType.Items.Add("ZIPIT");
                cbTransactionType.Items.Add("RTGS");
            }
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using EasyTicket.Forms.Main_Menu;

namespace EasyTicket.Forms.Main_Menu
{
    public partial class TopupAccount : Form
    {
        //initialize a database instance
        DB db = new DB();
        Main_Menu mm = new Main_Menu();
        VerifyPassword verify = new VerifyPassword();

        //Assign username to labelUsername
        public void LoggedInUser(string username)
        {
            labelUsername.Text = username;
        }

        public TopupAccount()
        {
            InitializeComponent();
        }
        
        //Check for blank fields
        private bool CheckBlankFields()
        {
            if(txtAmount.Text == "" || 
                txtCurrentBalance.Text == "" || 
                txtNewBalance.Text == "" ||
                txtAccountNumber.Text == "" ||
                txtAccountNumber.Text == "000" ||
                txtNewBalance.Text == "" ||
                cbBank.SelectedItem.ToString() == "" || 
                cbTransactionType.SelectedItem.ToString() == "" ||
                txtAccountNumber.Text =="")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Topup amount cannot be $0.00 or less
        private bool CheckMinimumTopup(double topup_amount)
        {
            if (topup_amount <= 100.00)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        //Topup amount cannot be above $10 000
        private bool CheckTopupLimit(double topup_amount)
        {
            if(topup_amount > 10000.00)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        //Topup function: returns current balance + topup amount
        private double CalculateNewBalance(double current_balance, double topup_amount)
        {
            return current_balance + topup_amount;
        }
        
        //Function for populating datagrid view using the logged in user's username
        private void LoadDataGridView(string username)
        {            
            DataTable dt = new DataTable();
            using (NpgsqlConnection connection = db.GetConnection())
            {
                string select = "SELECT username, balance FROM public.commuter WHERE username=@username";
                NpgsqlCommand command = new NpgsqlCommand(select, connection);
                command.Parameters.AddWithValue(@"username", username);                
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                da.Fill(dt);
                dgvTopup.DataSource = dt;                
            }
        }

        private void TopupAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Assign username to username label when the form loads
        private void TopupAccount_Load(object sender, EventArgs e)
        {
            LoadDataGridView(labelUsername.Text);
            cbBank.SelectedItem = "CBZ";
            cbTransactionType.SelectedItem = "ZIPIT";           
        }

        //Preview event: preview changes before saving
        private void btnPreview_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvTopup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvTopup.Rows[e.RowIndex];
            txtCurrentBalance.Text = row.Cells["balance"].Value.ToString();
        }

        private void dgvTopup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvTopup.Rows[e.RowIndex];
            txtCurrentBalance.Text = row.Cells["balance"].Value.ToString();
        }

        //Back event: hide current form and show main menu
        private void llBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            Main_Menu mm = new Main_Menu();
            mm.LoggedInUsername(labelUsername.Text);
            this.Hide();
            mm.ShowDialog();
        }
        

        //Save event: commit changes to public.commuter
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string username = labelUsername.Text;
            string bank = cbBank.SelectedItem.ToString();
            string account_num = txtAccountNumber.Text;
            double current_balance = Convert.ToDouble(txtCurrentBalance.Text);
            double top_up_amount = Convert.ToDouble(txtAmount.Text);
            double new_balance = CalculateNewBalance(current_balance, top_up_amount);

            //Check for blank fields
            if (!CheckBlankFields())
            {
                //btnSave.Enabled = true;
                //Check if topup is $0.00 or less
                if (!CheckMinimumTopup(top_up_amount))
                {
                    //Check if topup is above $10 000
                    if (!CheckTopupLimit(top_up_amount))
                    {
                        try
                        {
                            //Verify the user's password before topping up
                            verify.LoggedInUser(username);
                            if (verify.ShowDialog() == DialogResult.OK)
                            {
                                if (verify.is_verified && db.UpdateCommuterBalance(username, new_balance))
                                {
                                    MessageBox.Show($"Your new balance is ${new_balance}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Hide();
                                    Main_Menu mm = new Main_Menu();
                                    mm.LoggedInUsername(labelUsername.Text);
                                    mm.ShowDialog();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update account", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("You have exceeded your transaction limit of $10 000", "Invalid Topup Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Topup amount cannot be <=$100.00", "Invalid Topup Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Fill in all fields", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Event: preview prior to saving
        private void btnPreview_Click_1(object sender, EventArgs e)
        {
            try
            {
                double current_balance = Convert.ToDouble(txtCurrentBalance.Text);
                double top_up_amount = Convert.ToDouble(txtAmount.Text);
                double new_balance = CalculateNewBalance(current_balance, top_up_amount);
                txtNewBalance.Text = Convert.ToString(new_balance);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTransactionType.Items.Clear();
            if (cbBank.SelectedItem.ToString() == "EcoCash")
            {
                cbTransactionType.Items.Add("ZIPIT");
            }
            else
            {
                cbTransactionType.Items.Add("ZIPIT");
                cbTransactionType.Items.Add("RTGS");
            }
        }
    }
}
>>>>>>> parent of 5a30ca7... commit message
 