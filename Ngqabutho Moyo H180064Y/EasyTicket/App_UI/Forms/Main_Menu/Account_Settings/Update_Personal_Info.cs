using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTicket.Forms.Main_Menu;
using Npgsql;

namespace EasyTicket.App_UI.Forms.Main_Menu.Account_Settings
{
    public partial class Update_Personal_Info : Form
    {
        DB db = new DB();
        DataTable dt = new DataTable();
        //EasyTicket.Forms.Main_Menu.Main_Menu mm = new EasyTicket.Forms.Main_Menu.Main_Menu();

        public void SetLoggedInUsername(string username)
        {
            labelUsername.Text = username;
        }
        public Update_Personal_Info()
        {
            InitializeComponent();
        }

        private void Update_Personal_Info_Load(object sender, EventArgs e)
        {
            string username = labelUsername.Text;
            string select = "SELECT address, phone, email FROM public.commuter WHERE username=@username";
            using (NpgsqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(select, connection);
                    command.Parameters.AddWithValue(@"username", username);
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                    da.Fill(dt);
                    dgvDetails.DataSource = dt;                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string username = labelUsername.Text;
            string address = txtAddress1.Text + txtAddress2.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;

            if (db.UpdateCommuterDetails(username, address, phone, email))
            {
                MessageBox.Show("Your details have been updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void llBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void Update_Personal_Info_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgvDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvDetails.Rows[e.RowIndex];
            txtAddress1.Text = row.Cells["address"].Value.ToString();
            txtAddress2.Text = "";
            txtPhone.Text = row.Cells["phone"].Value.ToString();
            txtEmail.Text = row.Cells["email"].Value.ToString();
        }

        private void llBack_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            AccountSettings accountSettings = new AccountSettings();
            this.Hide();
            accountSettings.LoggedInUser(labelUsername.Text);
            accountSettings.ShowDialog();
        }
    }
}
