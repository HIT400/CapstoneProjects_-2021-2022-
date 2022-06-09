using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Net;
using System.Net.Mail;

namespace EasyTicket.Forms.Main_Menu
{
    public partial class Pay : Form
    {
        DB db = new DB();
        SavePDFReceipt receipt = new SavePDFReceipt();
        DataTable dt = new DataTable();        
        Main_Menu mm = new Main_Menu();
        //OTP otp = new OTP();
        VerifyPassword verify = new VerifyPassword();
        String message;       

        public void LoggedInUser(string username)
        {
            labelUsername.Text = username;
        }

        public Pay()
        {
            InitializeComponent();
        }

        

        //Only a-z and A-Z are allowed in the 'from' and 'to' textboxes
        private bool ValidateFromTo(string from, string to)
        {
            string regex = "[A-Za-z0-9]";
            Regex r = new Regex(regex);
            if (r.IsMatch(from) && r.IsMatch(to))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        //Check for blank fields
        private bool CheckBlankFields()
        {
            if(txtCurrentBalance.Text == "" || 
                cbFrom.SelectedItem.ToString() == "" || 
                cbTo.SelectedItem.ToString() == "" || 
                cbPrice.SelectedItem.ToString() == "") 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Does the commuter have sufficient funds?
        private bool CheckBalanceAndPrice(double balance, double price)
        {
            if (balance < price)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //No free trips
        private bool InvalidFare(double payment)
        {
            if (payment == 0.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Deduct trip price from commuter's balance
        private double CalculateNewBalance(double current_balance, double price)
        {
            return current_balance - price;
        }

        //Event: pay for a trip; deduct appropriate amount from commuter's account        
        private void btnPay_Click_1(object sender, EventArgs e)
        {   
            string username = labelUsername.Text;
            string from = cbFrom.SelectedItem.ToString();
            string to = cbTo.SelectedItem.ToString();            
            double price = Convert.ToDouble(cbPrice.SelectedItem.ToString());
            double current_balance = Convert.ToDouble(txtCurrentBalance.Text);
            double new_balance = CalculateNewBalance(current_balance, price);
            string time = cbHour.Text + ":" + cbMinute.Text;

            //No field should be left blank
            if(!CheckBlankFields())
            {
                //Are the 'from' and 'to' fields a-z and/or A-Z?
                if(ValidateFromTo(from, to))
                {
                    //If there are sufficient funds, process the ticket
                    if (!CheckBalanceAndPrice(current_balance, price))
                    {
                        //Price cannot be 0.00
                        if (!InvalidFare(price))
                        {
                            //Verify the user's password before paying                    
                            verify.LoggedInUser(username);
                            if (verify.ShowDialog() == DialogResult.OK)
                            {
                                if (verify.is_verified && db.UpdateCommuterBalance(username, new_balance) && 
                                    db.InsertIntoTrip(username, from, to, price))
                                {
                                    message = $"{DateTime.Now}\n\nYou paid: ${price} \nFrom: {from} \nTo: {to}\nYour new balance is ${new_balance}";
                                    MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    receipt.SaveReceipt(username, from, to, time, price);
                                    dgvPay.ClearSelection();
                                    this.Hide();
                                    Main_Menu mm = new Main_Menu();
                                    mm.LoggedInUsername(labelUsername.Text);
                                    mm.ShowDialog();
                                }
                                else
                                {
                                    MessageBox.Show("Your password could not be verified", "Payment Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Payment failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Price cannot be 0.00", "Invalid price", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    //Else raise an error for insufficient funds
                    else
                    {
                        MessageBox.Show("You have insufficient funds for this journey", "Insufficient funds", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Your route details are invalid", "Invalid Route", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Fill in all fields", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Call LoadDataGridView() when the form loads
        private void Pay_Load(object sender, EventArgs e)
        {
            LoadDataGridView();            
        }       

        //Automatically populate the commuter's balance inside the 'Current Balance' textbox
        private void dgvPay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvPay.Rows[e.RowIndex];
            txtCurrentBalance.Text = row.Cells["balance"].Value.ToString();
        }

        //Retrieve balance and automatically fill in the 'balance' textbox
        private void GetBalance()
        {
            string username = labelUsername.Text;
            string select = "SELECT balance FROM public.commuter WHERE username=@username";
            using (NpgsqlConnection connection = db.GetConnection())
            {
                NpgsqlCommand command = new NpgsqlCommand(select, connection);
                command.Parameters.AddWithValue(@"username", username);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                da.Fill(dt);
                txtCurrentBalance.Text = dt.ToString();
            }
        }

        //Populate the datagrid view with the commuter's account details
        private void LoadDataGridView()
        {
            string username = labelUsername.Text;
            string select = "SELECT first_name, last_name, balance FROM public.commuter WHERE username=@username";
            using (NpgsqlConnection connection = db.GetConnection())
            {
                NpgsqlCommand command = new NpgsqlCommand(select, connection);
                command.Parameters.AddWithValue(@"username", username);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                da.Fill(dt);
                dgvPay.DataSource = dt;
            }            
        }

        //Close the application when the user closes the form
        private void Pay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Navigate back to the main menu
        private void llMainMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mm.LoggedInUsername(labelUsername.Text);
            this.Hide();
            mm.Show();
        }

        private void cbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTo.Items.Clear();
            if (cbFrom.SelectedItem.ToString() == "Copacabana")
            {
                cbTo.Items.Add("Belvedere");
                cbTo.Items.Add("Kuwadzana");
                cbTo.Items.Add("West Gate");
                cbTo.Items.Add("Warren Park");
                cbTo.Items.Add("Milton Park");
                cbTo.Items.Add("Marimba");
            }
            else if (cbFrom.SelectedItem.ToString() == "Market Square")
            {
                cbTo.Items.Add("Southerton");
                cbTo.Items.Add("Lochinvar");
                cbTo.Items.Add("Budiriro 4");
                cbTo.Items.Add("Budiriro 5");
                cbTo.Items.Add("Glen View 1");
                cbTo.Items.Add("Waterfalls");
                cbTo.Items.Add("Parktown");
            }
            else if (cbFrom.SelectedItem.ToString() == "4th Street")
            {
                cbTo.Items.Add("Ruwa");
                cbTo.Items.Add("Zimre Park");
                cbTo.Items.Add("Kamfinsa");
                cbTo.Items.Add("Chisipite");
                cbTo.Items.Add("Newlands");
                cbTo.Items.Add("Mabvuku");
                cbTo.Items.Add("Tafara");
                cbTo.Items.Add("Manresa");
                cbTo.Items.Add("Borrowdale");
                cbTo.Items.Add("Hatcliffe");
            }
            else if (cbFrom.SelectedItem.ToString() == "Rezende")
            {
                cbTo.Items.Add("Mt Pleasant");
            }
            else if (cbFrom.SelectedItem.ToString() == "Charge Office")
            {
                cbTo.Items.Add("Chitungwiza");
            }
        }

        private void dgvPay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }        
    }    
}
