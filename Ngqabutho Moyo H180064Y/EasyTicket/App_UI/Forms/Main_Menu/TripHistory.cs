using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace EasyTicket.Forms.Main_Menu
{
    public partial class TripHistory : Form
    {
        DB db = new DB();
        DataTable dt = new DataTable();

        public void LoggedInUsername(string username)
        {
            labelUsername.Text = username;
        }

        public TripHistory()
        {
            InitializeComponent();
        }

        private void TripHistory_Load(object sender, EventArgs e)
        {            
            SelectFromTrip(labelUsername.Text);            
        }

        //Populate datagrid view with commuter's past trips
        private void SelectFromTrip(string username)
        {
            string select = "SELECT _from, _to, price, _date, _time FROM public.trip WHERE username=@username;";
            using(NpgsqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(select, connection);
                    command.Parameters.AddWithValue(@"username", username);
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                    da.Fill(dt);
                    dgvCommutingHistory.DataSource = dt;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        //Search trip history by '_from'
        /*
        public bool SearchTripBySource(string username, string _from)
        {
            string search = "SELECT _from, _to, price, _date, _time FROM public.trip WHERE username=@username AND _from=@_from;";
            using (NpgsqlConnection connection = db.GetConnection())
            {
                try
                {                    
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(search, connection);
                    command.Parameters.AddWithValue(@"username", username);
                    command.Parameters.AddWithValue(@"_from", _from);
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                    da.Fill(dt);                    
                    dgvCommutingHistory.Hide();                    
                    
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        */
        //Order trip history by _from


        //Event: go back to main menu
        private void llMainMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main_Menu mm = new Main_Menu();
            mm.LoggedInUsername(labelUsername.Text);
            this.Hide();
            mm.ShowDialog();
        }

        private void TripHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /*
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string username = labelUsername.Text;
            if (txtSource.Enabled == true)
            {
                string _from = txtSource.Text;
                //SearchTripBySource(username, _from);
            }
        }

        private void txtSource_TextChanged(object sender, EventArgs e)
        {
            txtDestination.Enabled = false;
            txtPrice.Enabled = false;
            dtpDate.Enabled = false;

            if (txtSource.Text == "")
            {
                txtDestination.Enabled = true;
                txtPrice.Enabled = true;
                dtpDate.Enabled = true;
            }
        }

        private void txtDestination_TextChanged(object sender, EventArgs e)
        {
            txtSource.Enabled = false;
            txtPrice.Enabled = false;
            dtpDate.Enabled = false;

            if (txtDestination.Text == "")
            {
                txtSource.Enabled = true;
                txtPrice.Enabled = true;
                dtpDate.Enabled = true;
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            txtSource.Enabled = false;
            txtDestination.Enabled = false;
            dtpDate.Enabled = false;

            if (txtPrice.Text == "")
            {
                txtDestination.Enabled = true;
                txtSource.Enabled = true;
                dtpDate.Enabled = true;
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            txtSource.Enabled = false;
            txtDestination.Enabled = false;
            txtPrice.Enabled = false;

            if (Convert.ToDateTime(dtpDate.Value) == DateTime.Now)
            {
                txtDestination.Enabled = true;
                txtPrice.Enabled = true;
                txtPrice.Enabled = true;
            }
        }
        */
    }
}
