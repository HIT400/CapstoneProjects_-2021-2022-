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

namespace EasyTicket
{
    public partial class Admin : Form
    {
        DB db = new DB();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();
        //float total_revenue;

        public void LoggedInUser(string username)
        {
            labelUsername.Text = username;
        }

        public Admin()
        {
            InitializeComponent();
        }

        public void SelectRevenuePerCommuter()
        {
            string select = "SELECT username AS commuter, SUM(price) AS revenue FROM public.trip GROUP BY username;";
            using (NpgsqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(select, connection);
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                    da.Fill(dt4);
                    dgvCommuters.DataSource = dt4;

                    //return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void LoadDgvTotal()
        {
            string select = "SELECT SUM(price) AS total_revenue FROM public.trip";
            using(NpgsqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(select, connection);
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                    da.Fill(dt1);
                    dgvAdmin.DataSource = dt1;
                    //txtTotalRevenue.Text = dt.ToString();
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

        public void LoadDgvNonActiveUsers()
        {
            string select = "SELECT DISTINCT ON (commuter.username) commuter.username FROM public.commuter LEFT JOIN public.trip ON commuter.username = trip.username WHERE trip.username IS NULL";
            using (NpgsqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(select, connection);
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                    da.Fill(dt3);
                    dgvNonActiveUsers.DataSource = dt3;
                    //txtTotalRevenue.Text = dt.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public void LoadDgvActiveUsers()
        {
            string select = "SELECT DISTINCT ON (username) username FROM public.trip";
            using (NpgsqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(select, connection);
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                    da.Fill(dt2);
                    dgvActiveUsers.DataSource = dt2;
                    //txtTotalRevenue.Text = dt.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            LoadDgvTotal();
            LoadDgvActiveUsers();
            LoadDgvNonActiveUsers();
            SelectRevenuePerCommuter();
        }
    }
}
