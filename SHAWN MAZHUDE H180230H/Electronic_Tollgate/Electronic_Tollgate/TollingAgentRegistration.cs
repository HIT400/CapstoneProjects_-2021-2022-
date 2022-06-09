/*
 * Created by SharpDevelop.
 * User: 26378
 * Date: 4/4/2022
 * Time: 10:23 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;
using System.Threading;
using MySql.Data.MySqlClient;

namespace Electronic_Tollgate
{
	/// <summary>
	/// Description of TollingAgentRegistration.
	/// </summary>
	public partial class TollingAgentRegistration : Form
	{
		
		MySqlConnection con;
		String query;
		String ConnectionString = "server=127.0.0.1;uid=root;" + "pwd=;database=etolling;SSL Mode=0";
		
		
		public TollingAgentRegistration()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnExitClick(object sender, EventArgs e)
		{
			MainForm fm = new MainForm();
			fm.Show();
			this.Hide();
		}
		void BtnSaveClick(object sender, EventArgs e)
		{
			if(txtPassword.Text == txtCpassword.Text){
			
							con = new MySqlConnection();
                            con.ConnectionString = ConnectionString;			
                            con.Open();
 query = "INSERT INTO _agents (FullName,IDNumber,EmployeeNumber,Password) VALUES('" +  txtFullname.Text +"','"+  txtIDNo.Text +"','" + txtEmpNo.Text + "','" +  txtPassword.Text +"')";			 
MySqlCommand cmd = new MySqlCommand(query,con);
cmd.ExecuteNonQuery();
 con.Close();
 MessageBox.Show("Registration succesfull!!");
 txtCpassword.Text =txtEmpNo.Text = txtFullname.Text = txtIDNo.Text = txtPassword.Text = "";
			}
			
			else{
			
				MessageBox.Show("Password did not match");
				txtPassword.Text = txtCpassword.Text = "";
			
			}
		}
	}
}
