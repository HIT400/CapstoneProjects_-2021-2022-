<<<<<<< HEAD
﻿/*
 * Created by SharpDevelop.
 * User: 26378
 * Date: 3/31/2022
 * Time: 12:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Timers;
using System.Threading;
using MySql.Data.MySqlClient;

namespace Electronic_Tollgate
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		String positionTxt;
        MySqlConnection con;
		String query;
		String ConnectionString = "server=127.0.0.1;uid=root;" + "pwd=;database=etolling;SSL Mode=0";
		String password;
		//tabName = "tollingagents_admins";
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		 
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnSignUpClick(object sender, EventArgs e)
		{
			positionTxt = cmbOfficial.SelectedItem.ToString();
			if((txtName.Text == "zinara") && (txtPassword.Text == "official22") && (positionTxt =="ZINARA ADMINSTRATOR")){
			
				ZINARAdmin za = new ZINARAdmin();
				za.Show();
				this.Hide();
			
			}
			
	     else if((txtName.Text == "zinara") && (txtPassword.Text == "official22") && (positionTxt =="TOLLING AGENT")){
			
				TollingAgentRegistration tr = new TollingAgentRegistration();
				tr.Show();
				this.Hide();
			
			}
			
			else{
			
				MessageBox.Show("Invalid username or Password");
				txtPassword.Text = txtName.Text = "";
				cmbOfficial.SelectedIndex = -1;
			
			}
		}
		void BtnLoginClick(object sender, EventArgs e)
		{
		
			try{
	positionTxt = cmbOfficial.SelectedItem.ToString();
	
			if(positionTxt == "TOLLING AGENT"){
			
					
con = new MySqlConnection();
con.ConnectionString = ConnectionString;
con.Open();
query = "SELECT Password FROM _agents WHERE FullName = ('" + txtName.Text +"')";
MySqlCommand cmd = new MySqlCommand(query,con);
MySqlDataReader dataReader = cmd.ExecuteReader();
			dataReader.Read();
			if(dataReader.HasRows){
				
				String AgentPAss = dataReader["Password"] + "";
				String AgentName = "";
				con.Close();
				con = new MySqlConnection();
con.ConnectionString = ConnectionString;
con.Open();
query = "SELECT FullName FROM _agents WHERE Password = ('" + txtPassword.Text +"')";
cmd = new MySqlCommand(query,con);
dataReader = cmd.ExecuteReader();
			dataReader.Read();
			if(dataReader.HasRows){
				AgentName = dataReader["FullName"] + "";

			}
			
			
			if(AgentName == txtName.Text && AgentPAss == txtPassword.Text){
				TransactionsDashboard td  = new TransactionsDashboard();
				td.Show();
				this.Hide();
				con.Close();
			}
			
			else{
			    MessageBox.Show("Invalid username or password");
				txtPassword.Text = txtName.Text = "";
				cmbOfficial.SelectedIndex = -1;
					con.Close();
			
			}
			}
			
			else{
				MessageBox.Show("Invalid username or password");
				txtPassword.Text = txtName.Text = "";
				cmbOfficial.SelectedIndex = -1;
					con.Close();
			
			}
			
			}
			
 if(positionTxt == "ZINARA ADMINSTRATOR"){
				
con = new MySqlConnection();
con.ConnectionString = ConnectionString;
con.Open();
query = "SELECT Password FROM _admins WHERE FullName = ('" + txtName.Text +"')";
MySqlCommand cmd = new MySqlCommand(query,con);
MySqlDataReader dataReader = cmd.ExecuteReader();
			dataReader.Read();
			if(dataReader.HasRows){
				
				String ZinaraPass = dataReader["Password"] + "";
				String ZinaraName= "";
				con.Close();
				
con = new MySqlConnection();
con.ConnectionString = ConnectionString;
con.Open();
query = "SELECT FullName FROM _admins WHERE Password = ('" + txtPassword.Text +"')";
cmd = new MySqlCommand(query,con);
dataReader = cmd.ExecuteReader();
			dataReader.Read();
			if(dataReader.HasRows){	
				ZinaraName = dataReader["Fullname"] + "";
			
			}
				
			if(ZinaraPass == txtPassword.Text && ZinaraName == txtName.Text){
				RegistrationDashboard rd = new RegistrationDashboard();
				rd.Show();
				this.Hide();
			    con.Close();
			}
			
						else{
			    MessageBox.Show("Invalid username or password");
				txtPassword.Text = txtName.Text = "";
				cmbOfficial.SelectedIndex = -1;
			    	con.Close();
			}
			
			}
			
			else{
			    MessageBox.Show("Invalid username or password");
				txtPassword.Text = txtName.Text = "";
				cmbOfficial.SelectedIndex = -1;
			    	con.Close();
			}
			
			
			}
		 
			
			}
			
			
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
			
		}
 
 
	}
}
=======
﻿/*
 * Created by SharpDevelop.
 * User: 26378
 * Date: 3/31/2022
 * Time: 12:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Timers;
using System.Threading;
using MySql.Data.MySqlClient;

namespace Electronic_Tollgate
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		String positionTxt;
        MySqlConnection con;
		String query;
		String ConnectionString = "server=127.0.0.1;uid=root;" + "pwd=;database=etolling;SSL Mode=0";
		String password;
		//tabName = "tollingagents_admins";
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		 
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnSignUpClick(object sender, EventArgs e)
		{
			positionTxt = cmbOfficial.SelectedItem.ToString();
			if((txtName.Text == "zinara") && (txtPassword.Text == "official22") && (positionTxt =="ZINARA ADMINSTRATOR")){
			
				ZINARAdmin za = new ZINARAdmin();
				za.Show();
				this.Hide();
			
			}
			
	     else if((txtName.Text == "zinara") && (txtPassword.Text == "official22") && (positionTxt =="TOLLING AGENT")){
			
				TollingAgentRegistration tr = new TollingAgentRegistration();
				tr.Show();
				this.Hide();
			
			}
			
			else{
			
				MessageBox.Show("Invalid username or Password");
				txtPassword.Text = txtName.Text = "";
				cmbOfficial.SelectedIndex = -1;
			
			}
		}
		void BtnLoginClick(object sender, EventArgs e)
		{
		
			try{
	positionTxt = cmbOfficial.SelectedItem.ToString();
	
			if(positionTxt == "TOLLING AGENT"){
			
					
con = new MySqlConnection();
con.ConnectionString = ConnectionString;
con.Open();
query = "SELECT Password FROM _agents WHERE FullName = ('" + txtName.Text +"')";
MySqlCommand cmd = new MySqlCommand(query,con);
MySqlDataReader dataReader = cmd.ExecuteReader();
			dataReader.Read();
			if(dataReader.HasRows){
				
				String AgentPAss = dataReader["Password"] + "";
				String AgentName = "";
				con.Close();
				con = new MySqlConnection();
con.ConnectionString = ConnectionString;
con.Open();
query = "SELECT FullName FROM _agents WHERE Password = ('" + txtPassword.Text +"')";
cmd = new MySqlCommand(query,con);
dataReader = cmd.ExecuteReader();
			dataReader.Read();
			if(dataReader.HasRows){
				AgentName = dataReader["FullName"] + "";

			}
			
			
			if(AgentName == txtName.Text && AgentPAss == txtPassword.Text){
				TransactionsDashboard td  = new TransactionsDashboard();
				td.Show();
				this.Hide();
				con.Close();
			}
			
			else{
			    MessageBox.Show("Invalid username or password");
				txtPassword.Text = txtName.Text = "";
				cmbOfficial.SelectedIndex = -1;
					con.Close();
			
			}
			}
			
			else{
				MessageBox.Show("Invalid username or password");
				txtPassword.Text = txtName.Text = "";
				cmbOfficial.SelectedIndex = -1;
					con.Close();
			
			}
			
			}
			
 if(positionTxt == "ZINARA ADMINSTRATOR"){
				
con = new MySqlConnection();
con.ConnectionString = ConnectionString;
con.Open();
query = "SELECT Password FROM _admins WHERE FullName = ('" + txtName.Text +"')";
MySqlCommand cmd = new MySqlCommand(query,con);
MySqlDataReader dataReader = cmd.ExecuteReader();
			dataReader.Read();
			if(dataReader.HasRows){
				
				String ZinaraPass = dataReader["Password"] + "";
				String ZinaraName= "";
				con.Close();
				
con = new MySqlConnection();
con.ConnectionString = ConnectionString;
con.Open();
query = "SELECT FullName FROM _admins WHERE Password = ('" + txtPassword.Text +"')";
cmd = new MySqlCommand(query,con);
dataReader = cmd.ExecuteReader();
			dataReader.Read();
			if(dataReader.HasRows){	
				ZinaraName = dataReader["Fullname"] + "";
			
			}
				
			if(ZinaraPass == txtPassword.Text && ZinaraName == txtName.Text){
				RegistrationDashboard rd = new RegistrationDashboard();
				rd.Show();
				this.Hide();
			    con.Close();
			}
			
						else{
			    MessageBox.Show("Invalid username or password");
				txtPassword.Text = txtName.Text = "";
				cmbOfficial.SelectedIndex = -1;
			    	con.Close();
			}
			
			}
			
			else{
			    MessageBox.Show("Invalid username or password");
				txtPassword.Text = txtName.Text = "";
				cmbOfficial.SelectedIndex = -1;
			    	con.Close();
			}
			
			
			}
		 
			
			}
			
			
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
			
		}
 
 
	}
}
>>>>>>> parent of 5a30ca7... commit message
