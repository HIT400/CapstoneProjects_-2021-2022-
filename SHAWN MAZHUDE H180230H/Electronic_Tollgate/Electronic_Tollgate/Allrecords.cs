<<<<<<< HEAD
﻿/*
 * Created by SharpDevelop.
 * User: 26378
 * Date: 5/1/2022
 * Time: 11:27 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Electronic_Tollgate
{
	/// <summary>
	/// Description of Allrecords.
	/// </summary>
	public partial class Allrecords : Form
	{
		MySqlConnection con;
		String query;
		String ConnectionString = "server=127.0.0.1;uid=root;" + "pwd=;database=etolling;SSL Mode=0";
		
		public Allrecords()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			String op =	 cmboptions.SelectedItem.ToString();
			
			if(op == "Records"){
				txttrans.Text = txtamnt.Text = "";
	    con = new MySqlConnection();
        con.ConnectionString = ConnectionString;			
        con.Open();
        query = "SELECT * FROM _register";		
         MySqlCommand cmd = new MySqlCommand(query,con);
			MySqlDataReader dataReader = cmd.ExecuteReader();
			//dataReader.Read();
			DataTable dt = new DataTable();
			dt.Load(dataReader);
			dataGridView1.DataSource = dt;
			con.Close();
			
			}

						if(op == "TollgateA"){
			
	    con = new MySqlConnection();
        con.ConnectionString = ConnectionString;			
        con.Open();
        query = "SELECT * FROM tollgateA";		
         MySqlCommand cmd = new MySqlCommand(query,con);
			MySqlDataReader dataReader = cmd.ExecuteReader();
			//dataReader.Read();
			DataTable dt = new DataTable();
			dt.Load(dataReader);
			dataGridView1.DataSource = dt;
			con.Close();
			var date1 = DateTime.Now;
			String val = date1.ToLongDateString();	
					con = new MySqlConnection();
        con.ConnectionString = ConnectionString;			
        con.Open();
        query = "SELECT Count(*) FROM tollgateA WHERE Day = ('"+ val +"')";
        cmd = new MySqlCommand(query,con); 
       var num = cmd.ExecuteScalar();
       txttrans.Text = Convert.ToString(num);
       con.Close();
       
       		con = new MySqlConnection();
        con.ConnectionString = ConnectionString;			
        con.Open();
        query = "SELECT SUM(AmountPaid) FROM tollgateA WHERE Day = ('"+ val +"')";
        cmd = new MySqlCommand(query,con); 
        var amnt = cmd.ExecuteScalar();
        txtamnt.Text = Convert.ToString(amnt);
        con.Close();
			}
			
						if(op == "TollgateB"){
			
	    con = new MySqlConnection();
        con.ConnectionString = ConnectionString;			
        con.Open();
        query = "SELECT * FROM tollgateB";		
         MySqlCommand cmd = new MySqlCommand(query,con);
			MySqlDataReader dataReader = cmd.ExecuteReader();
			//dataReader.Read();
			DataTable dt = new DataTable();
			dt.Load(dataReader);
			dataGridView1.DataSource = dt;
			con.Close();
			
				var date1 = DateTime.Now;
			String val = date1.ToLongDateString();	
			
			con = new MySqlConnection();
        con.ConnectionString = ConnectionString;			
        con.Open();
        query = "SELECT Count(*) FROM tollgateB WHERE Day = ('"+val +"')";
        cmd = new MySqlCommand(query,con); 
       var num = cmd.ExecuteScalar();
       txttrans.Text = Convert.ToString(num);
       con.Close();
       
       		con = new MySqlConnection();
        con.ConnectionString = ConnectionString;			
        con.Open();
        query = "SELECT SUM(AmountPaid) FROM tollgateB WHERE Day = ('"+ val +"')";
        cmd = new MySqlCommand(query,con); 
        var amnt = cmd.ExecuteScalar();
        txtamnt.Text = Convert.ToString(amnt);
        con.Close();
			}
			
		if(op == "TollgateC"){
			
 	    con = new MySqlConnection();
        con.ConnectionString = ConnectionString;			
        con.Open();
        query = "SELECT * FROM tollgateC";		
         MySqlCommand cmd = new MySqlCommand(query,con);
			MySqlDataReader dataReader = cmd.ExecuteReader();
			//dataReader.Read();
			DataTable dt = new DataTable();
			dt.Load(dataReader);
			dataGridView1.DataSource = dt;
			con.Close();
				
				var date1 = DateTime.Now;
			String val = date1.ToLongDateString();			
			con = new MySqlConnection();
        con.ConnectionString = ConnectionString;			
        con.Open();
        query = "SELECT Count(*) FROM tollgateC WHERE Day = ('"+val +"')";
        cmd = new MySqlCommand(query,con); 
       var num = cmd.ExecuteScalar();
       txttrans.Text = Convert.ToString(num);
       con.Close();
       
       		con = new MySqlConnection();
        con.ConnectionString = ConnectionString;			
        con.Open();
        query = "SELECT SUM(AmountPaid) FROM tollgateC WHERE Day = ('"+ val +"')";
        cmd = new MySqlCommand(query,con); 
        var amnt = cmd.ExecuteScalar();
        txtamnt.Text = Convert.ToString(amnt);
        con.Close();
				
			}
			
						if(op == "TollgateD"){
			
	    con = new MySqlConnection();
        con.ConnectionString = ConnectionString;			
        con.Open();
        query = "SELECT * FROM tollgateD";		
         MySqlCommand cmd = new MySqlCommand(query,con);
			MySqlDataReader dataReader = cmd.ExecuteReader();
			//dataReader.Read();
			DataTable dt = new DataTable();
			dt.Load(dataReader);
			dataGridView1.DataSource = dt;
			con.Close();
			
		var date1 = DateTime.Now;
		String val = date1.ToLongDateString();	
		con = new MySqlConnection();
        con.ConnectionString = ConnectionString;			
        con.Open();
        query = "SELECT Count(*) FROM tollgateD WHERE Day = ('"+ val +"')";
        cmd = new MySqlCommand(query,con); 
       var num = cmd.ExecuteScalar();
       txttrans.Text = Convert.ToString(num);
       con.Close();
       
		con = new MySqlConnection();
        con.ConnectionString = ConnectionString;			
        con.Open();
        query = "SELECT SUM(AmountPaid) FROM tollgateD WHERE Day = ('"+ val +"')";
        cmd = new MySqlCommand(query,con); 
        var amnt = cmd.ExecuteScalar();
        txtamnt.Text = Convert.ToString(amnt);
        con.Close();
         
        
			}
			
			
		}
		void BtnExitClick(object sender, EventArgs e)
		{
			RegistrationDashboard rd = new RegistrationDashboard();
			rd.Show();
			this.Hide();
			
		}
		void BtnSaveClick(object sender, EventArgs e)
		{
	con.Close();
String toll =  cmboptions.SelectedItem.ToString();

if(toll != "Records"){
con = new MySqlConnection();
con.ConnectionString = ConnectionString;			
con.Open();
query = "INSERT INTO  daily_transactions (Tollgate,NumberOfTransactions,Amount,Date) VALUES('" + toll + "','" + txttrans.Text +"','" + txtamnt.Text +"','"+ DateTime.Now.ToString() +"')";
MySqlCommand cmd = new MySqlCommand(query,con);
cmd.ExecuteNonQuery();
MessageBox.Show("Transaction recorded");

}

else{
//

}
		}
	}
}
=======
﻿/*
 * Created by SharpDevelop.
 * User: 26378
 * Date: 5/1/2022
 * Time: 11:27 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Electronic_Tollgate
{
	/// <summary>
	/// Description of Allrecords.
	/// </summary>
	public partial class Allrecords : Form
	{
		MySqlConnection con;
		String query;
		String ConnectionString = "server=127.0.0.1;uid=root;" + "pwd=;database=etolling;SSL Mode=0";
		
		public Allrecords()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			String op =	 cmboptions.SelectedItem.ToString();
			
			if(op == "Records"){
				txttrans.Text = txtamnt.Text = "";
	    con = new MySqlConnection();
        con.ConnectionString = ConnectionString;			
        con.Open();
        query = "SELECT * FROM _register";		
         MySqlCommand cmd = new MySqlCommand(query,con);
			MySqlDataReader dataReader = cmd.ExecuteReader();
			//dataReader.Read();
			DataTable dt = new DataTable();
			dt.Load(dataReader);
			dataGridView1.DataSource = dt;
			con.Close();
			
			}

						if(op == "TollgateA"){
			
	    con = new MySqlConnection();
        con.ConnectionString = ConnectionString;			
        con.Open();
        query = "SELECT * FROM tollgateA";		
         MySqlCommand cmd = new MySqlCommand(query,con);
			MySqlDataReader dataReader = cmd.ExecuteReader();
			//dataReader.Read();
			DataTable dt = new DataTable();
			dt.Load(dataReader);
			dataGridView1.DataSource = dt;
			con.Close();
			var date1 = DateTime.Now;
			String val = date1.ToLongDateString();	
					con = new MySqlConnection();
        con.ConnectionString = ConnectionString;			
        con.Open();
        query = "SELECT Count(*) FROM tollgateA WHERE Day = ('"+ val +"')";
        cmd = new MySqlCommand(query,con); 
       var num = cmd.ExecuteScalar();
       txttrans.Text = Convert.ToString(num);
       con.Close();
       
       		con = new MySqlConnection();
        con.ConnectionString = ConnectionString;			
        con.Open();
        query = "SELECT SUM(AmountPaid) FROM tollgateA WHERE Day = ('"+ val +"')";
        cmd = new MySqlCommand(query,con); 
        var amnt = cmd.ExecuteScalar();
        txtamnt.Text = Convert.ToString(amnt);
        con.Close();
			}
			
						if(op == "TollgateB"){
			
	    con = new MySqlConnection();
        con.ConnectionString = ConnectionString;			
        con.Open();
        query = "SELECT * FROM tollgateB";		
         MySqlCommand cmd = new MySqlCommand(query,con);
			MySqlDataReader dataReader = cmd.ExecuteReader();
			//dataReader.Read();
			DataTable dt = new DataTable();
			dt.Load(dataReader);
			dataGridView1.DataSource = dt;
			con.Close();
			
				var date1 = DateTime.Now;
			String val = date1.ToLongDateString();	
			
			con = new MySqlConnection();
        con.ConnectionString = ConnectionString;			
        con.Open();
        query = "SELECT Count(*) FROM tollgateB WHERE Day = ('"+val +"')";
        cmd = new MySqlCommand(query,con); 
       var num = cmd.ExecuteScalar();
       txttrans.Text = Convert.ToString(num);
       con.Close();
       
       		con = new MySqlConnection();
        con.ConnectionString = ConnectionString;			
        con.Open();
        query = "SELECT SUM(AmountPaid) FROM tollgateB WHERE Day = ('"+ val +"')";
        cmd = new MySqlCommand(query,con); 
        var amnt = cmd.ExecuteScalar();
        txtamnt.Text = Convert.ToString(amnt);
        con.Close();
			}
			
		if(op == "TollgateC"){
			
 	    con = new MySqlConnection();
        con.ConnectionString = ConnectionString;			
        con.Open();
        query = "SELECT * FROM tollgateC";		
         MySqlCommand cmd = new MySqlCommand(query,con);
			MySqlDataReader dataReader = cmd.ExecuteReader();
			//dataReader.Read();
			DataTable dt = new DataTable();
			dt.Load(dataReader);
			dataGridView1.DataSource = dt;
			con.Close();
				
				var date1 = DateTime.Now;
			String val = date1.ToLongDateString();			
			con = new MySqlConnection();
        con.ConnectionString = ConnectionString;			
        con.Open();
        query = "SELECT Count(*) FROM tollgateC WHERE Day = ('"+val +"')";
        cmd = new MySqlCommand(query,con); 
       var num = cmd.ExecuteScalar();
       txttrans.Text = Convert.ToString(num);
       con.Close();
       
       		con = new MySqlConnection();
        con.ConnectionString = ConnectionString;			
        con.Open();
        query = "SELECT SUM(AmountPaid) FROM tollgateC WHERE Day = ('"+ val +"')";
        cmd = new MySqlCommand(query,con); 
        var amnt = cmd.ExecuteScalar();
        txtamnt.Text = Convert.ToString(amnt);
        con.Close();
				
			}
			
						if(op == "TollgateD"){
			
	    con = new MySqlConnection();
        con.ConnectionString = ConnectionString;			
        con.Open();
        query = "SELECT * FROM tollgateD";		
         MySqlCommand cmd = new MySqlCommand(query,con);
			MySqlDataReader dataReader = cmd.ExecuteReader();
			//dataReader.Read();
			DataTable dt = new DataTable();
			dt.Load(dataReader);
			dataGridView1.DataSource = dt;
			con.Close();
			
		var date1 = DateTime.Now;
		String val = date1.ToLongDateString();	
		con = new MySqlConnection();
        con.ConnectionString = ConnectionString;			
        con.Open();
        query = "SELECT Count(*) FROM tollgateD WHERE Day = ('"+ val +"')";
        cmd = new MySqlCommand(query,con); 
       var num = cmd.ExecuteScalar();
       txttrans.Text = Convert.ToString(num);
       con.Close();
       
		con = new MySqlConnection();
        con.ConnectionString = ConnectionString;			
        con.Open();
        query = "SELECT SUM(AmountPaid) FROM tollgateD WHERE Day = ('"+ val +"')";
        cmd = new MySqlCommand(query,con); 
        var amnt = cmd.ExecuteScalar();
        txtamnt.Text = Convert.ToString(amnt);
        con.Close();
         
        
			}
			
			
		}
		void BtnExitClick(object sender, EventArgs e)
		{
			RegistrationDashboard rd = new RegistrationDashboard();
			rd.Show();
			this.Hide();
			
		}
		void BtnSaveClick(object sender, EventArgs e)
		{
	con.Close();
String toll =  cmboptions.SelectedItem.ToString();

if(toll != "Records"){
con = new MySqlConnection();
con.ConnectionString = ConnectionString;			
con.Open();
query = "INSERT INTO  daily_transactions (Tollgate,NumberOfTransactions,Amount,Date) VALUES('" + toll + "','" + txttrans.Text +"','" + txtamnt.Text +"','"+ DateTime.Now.ToString() +"')";
MySqlCommand cmd = new MySqlCommand(query,con);
cmd.ExecuteNonQuery();
MessageBox.Show("Transaction recorded");

}

else{
//

}
		}
	}
}
>>>>>>> parent of 5a30ca7... commit message
