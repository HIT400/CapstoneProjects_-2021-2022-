using Npgsql;
using System;
using EasyTicket.Forms.Main_Menu;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using EasyTicket.Forms;

namespace EasyTicket
{
    public partial class Register : Form
    {
        DB db = new DB();        

        public Register()
        {
            InitializeComponent();
        }

        //Boolean function to check for matching passwords
        private bool CheckMatchingPasswords(string password, string confirm_password)
        {
            if(password == confirm_password)
            {
                return true;
            }
            else
            {
                //MessageBox.Show("Passwords do not match");
                return false;
            }
        }

        //Validate phone number
        private bool RegexPhoneNumber(string phone_number)
        {
            string regex = "^2637(1|3|7|8)[0-9]{7}$";
            Regex re = new Regex(regex);
            if (re.IsMatch(phone_number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool RegexNationalID(string national_id)
        {
            string regex = "^[0-9]{2}-[0-9]{6,7} [A-Z] [0-9]{2}$";
            Regex re = new Regex(regex);
            if (re.IsMatch(national_id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool RegexEmail(string email)
        {
            string regex = "^[a-z0-9.]{4,16}@[a-z]{4,16}.(com|uk)$";
            Regex re = new Regex(regex);
            if (re.IsMatch(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Checking for blank fields
        private bool CheckBlankFields()
        {
            if (txtNationalID.Text == "" ||
                txtFirstName.Text == "" ||
                txtLastName.Text == "" ||
                txtPhone.Text == "" ||
                txtEmail.Text == "" ||
                txtUsername.Text == "" ||
                txtPassword.Text == "" ||
                txtConfirmPassword.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Sex radio choice
        private string SelectRadioButton()
        {
            string sex = "";

            if (rbMale.Checked == true)
            {
                sex = "Male";
            }
            else if (rbFemale.Checked == true)
            {
                sex = "Female";
            }
            else
            {
                sex = "Other";
            }            
            return sex;
        }

        //Registration event
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string national_id = txtNationalID.Text;
            string first_name = txtFirstName.Text;
            string last_name = txtLastName.Text;
            DateTime dob = Convert.ToDateTime(dtpDOB.Value);
            string sex = SelectRadioButton();
            string address = txtAddress1.Text + " " + txtAddress2.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirm_password = txtConfirmPassword.Text;
            DateTime created_on = DateTime.Now;
            double deposit = 0.00;            

            //Fields shouldn't be blank 
            if (!CheckBlankFields())
            {
                //Validate phone number
                if (RegexPhoneNumber(phone))
                {
                    //Validate national ID
                    if (RegexNationalID(national_id))
                    {
                        //Validate email
                        if (RegexEmail(email))
                        {
                            //Passwords should match
                            if (CheckMatchingPasswords(password, confirm_password))
                            {
                                //Insert details into database
                                if (db.InsertIntoCommuter(
                                    national_id,
                                    first_name,
                                    last_name,
                                    dob,
                                    sex,
                                    address,
                                    phone,
                                    email,
                                    username,
                                    password,
                                    created_on,
                                    deposit))
                                {
                                    MessageBox.Show($"Welcome {first_name} {last_name}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Hide();
                                    Main_Menu mm = new Main_Menu();
                                    mm.LoggedInUsername(username);
                                    mm.ShowDialog();
                                }
                                else
                                {
                                    MessageBox.Show($"{first_name} {last_name} could not be added", "Failed to add", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Passwords do not match", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Email was in an invalid format", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("National ID was not in the correct format (xx-xxxxxxx x xx)", "Invalid National ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Phone number was not in the correct format", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Fill in all fields", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            db.GetConnection();
        }

        private void llLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
