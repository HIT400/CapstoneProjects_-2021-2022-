/*
 * Created by SharpDevelop.
 * User: 26378
 * Date: 4/4/2022
 * Time: 10:24 AM
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
	/// Description of ZINARAdmin.
	/// </summary>
	public partial class ZINARAdmin : Form
	{
		
		MySqlConnection con;
		String query;
		String ConnectionString = "server=127.0.0.1;uid=root;" + "pwd=;database=etolling;SSL Mode=0";
		
		public ZINARAdmin()
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
			if(txtCpass.Text == txtPass.Text){
						    con = new MySqlConnection();
                            con.ConnectionString = ConnectionString;			
                            con.Open();
 query = "INSERT INTO _admins (FullName,IDNumber,EmployeeNumber,Password) VALUES('" +  txtFullName.Text +"','"+  txtIDNo.Text +"','" + txtEmpNo.Text + "','" +  txtPass.Text +"')";			 
MySqlCommand cmd = new MySqlCommand(query,con);
cmd.ExecuteNonQuery();
 con.Close();
 MessageBox.Show("Registration succesfull!!");
 txtCpass.Text =txtEmpNo.Text = txtFullName.Text = txtIDNo.Text = txtPass.Text = "";
			
			
			}
			
			else{
			
			
				MessageBox.Show("Password did not match");
				txtCpass.Text = txtPass.Text = "";	
			
			}
		}
	}
}
