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

namespace EasyTicket.App_UI.Forms.Admin
{    
    public partial class RevenuePerTerminus : Form
    {
        DataTable dt = new DataTable();
        string series = "Revenue";

        public void LoggedInUser(string username)
        {
            labelUsername.Text = username;
        }

        public RevenuePerTerminus()
        {
            InitializeComponent();
        }

        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Host=localhost; Port=5432; User Id=postgres; Password=LookSideways220; Database=easyticket;");
        }

        private void RevenuePerTerminus_Load(object sender, EventArgs e)
        {
            string select = "SELECT _from, SUM(price) AS revenue FROM public.trip GROUP BY _from";
            using (NpgsqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(select, connection);
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                    da.Fill(dt);

                    dgvBusStation.DataSource = dt;
                    chart1.DataSource = dt;
                    chart1.Series[series].XValueMember = "_from";
                    chart1.Series[series].YValueMembers = "revenue";
                    chart1.DataBind();                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void llBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdminRevised admin = new AdminRevised();
            admin.LoggedInUser(labelUsername.Text);
            admin.ShowDialog();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
