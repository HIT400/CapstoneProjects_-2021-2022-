/*
 * Created by SharpDevelop.
 * User: 26378
 * Date: 4/4/2022
 * Time: 1:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Timers;
using System.Threading;
using MySql.Data.MySqlClient;


namespace Electronic_Tollgate
{
	/// <summary>
	/// Description of TransactionsDashboard.
	/// </summary>
	public partial class TransactionsDashboard : Form
	{   
		String received_data;
		String Vehiclenum;
		SerialPort COMPORT;
		 MySqlConnection con;
		String query;
		sbyte indexOfA;
		int VehicleAmnt;
		String databaseAmount;
		String ConnectionString = "server=127.0.0.1;uid=root;" + "pwd=;database=etolling;SSL Mode=0";
		String phoneNumber;
		String tollname;
		public TransactionsDashboard()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			cmbPORT.Items.AddRange(SerialPort.GetPortNames());
			btnConnect.Visible  = true;
			btnDisconnect.Visible = false;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void db_send(){
		
			con = new MySqlConnection();
            con.ConnectionString = ConnectionString;			
            con.Open();
			query = "SELECT VehicleClass FROM _register WHERE CardNumber = ('" + Vehiclenum +"')";
			MySqlCommand cmd = new MySqlCommand(query,con);
			MySqlDataReader dataReader = cmd.ExecuteReader();
			dataReader.Read();
			if(dataReader.HasRows){
			
				String Vclass = dataReader["VehicleClass"] + "";
				
			if(Vclass == "A"){
				VehicleAmnt = 10;
			}
		if(Vclass == "B"){
				VehicleAmnt = 20;
			}
		
			}
			
			con.Close();
			
			 			con = new MySqlConnection();
			con.ConnectionString = ConnectionString;
			con.Open();
			//String query = "SELECT + FROM + [user_data]";
				
			query = "SELECT AvailableBalance FROM _register WHERE CardNumber = ('" + Vehiclenum +"')";
			 cmd = new MySqlCommand(query,con);
			 dataReader = cmd.ExecuteReader();
			dataReader.Read();
			if(dataReader.HasRows){
			COMPORT.WriteLine("1\r\n"); 
		    databaseAmount = dataReader["AvailableBalance"] + "";		
			int dbAmnt = Convert.ToInt16(databaseAmount);
			con.Close();
			
			con = new MySqlConnection();
			con.ConnectionString = ConnectionString;
			con.Open();
			query = "SELECT PhoneNumber FROM _register WHERE CardNumber = ('" + Vehiclenum +"')";
			 cmd = new MySqlCommand(query,con);
			 dataReader = cmd.ExecuteReader();
			dataReader.Read();
			if(dataReader.HasRows){
				phoneNumber = dataReader["PhoneNumber"] + "";
			}
			tollname = cmbTollgate.SelectedItem.ToString();
			
			if(dbAmnt >= VehicleAmnt){
			dbAmnt = dbAmnt - VehicleAmnt;
			databaseAmount = Convert.ToString(dbAmnt);
			txtBalance.Text = databaseAmount;
				con = new MySqlConnection();
                con.ConnectionString = ConnectionString;			
                con.Open();
			     query = "UPDATE _register SET AvailableBalance = ('"+ databaseAmount + "') WHERE CardNumber = ('" + Vehiclenum +"')";
			    cmd = new MySqlCommand(query,con);
	            dataReader = cmd.ExecuteReader();
			    dataReader.Read();
			    con.Close();
              // COMPORT.WriteLine(phoneNumber + "," + databaseAmount + "," + tollname + "," + "R" + "," + "\n");
			    //Thread.Sleep(500); 
			
          COMPORT.WriteLine(phoneNumber + "," + databaseAmount + "," + tollname + "," + "C" + "\n");
          
          if(tollname == "TollgateA"){
 var date1 = DateTime.Now;
String val = date1.ToLongDateString();         
con = new MySqlConnection();
con.ConnectionString = ConnectionString;			
con.Open();
query = "INSERT INTO TollgateA (CardNumber,PhoneNumber,AmountPaid,Date,Day) VALUES('" + Vehiclenum + "','" + phoneNumber +"','" + VehicleAmnt +"','"+ DateTime.Now.ToString() +"','"+ val+"')";
 cmd = new MySqlCommand(query,con);
cmd.ExecuteNonQuery();
con.Close();
          
          }
          
          if(tollname == "TollgateB"){
 var date1 = DateTime.Now;
String val = date1.ToLongDateString();
 con = new MySqlConnection();
con.ConnectionString = ConnectionString;			
con.Open();
query = "INSERT INTO TollgateB (CardNumber,PhoneNumber,AmountPaid,Date,Day) VALUES('" + Vehiclenum + "','" + phoneNumber +"','" + VehicleAmnt +"','"+ DateTime.Now.ToString() +"','"+val +"')";
 cmd = new MySqlCommand(query,con);
cmd.ExecuteNonQuery();
con.Close();
          
          
          }
          
          if(tollname == "TollgateC"){
  			var date1 = DateTime.Now;
			String val = date1.ToLongDateString();          	
con = new MySqlConnection();
con.ConnectionString = ConnectionString;			
con.Open();
query = "INSERT INTO TollgateC (CardNumber,PhoneNumber,AmountPaid,Date,Day) VALUES('" + Vehiclenum + "','" + phoneNumber +"','" + VehicleAmnt +"','"+ DateTime.Now.ToString() +"','"+val +"')";
 cmd = new MySqlCommand(query,con);
cmd.ExecuteNonQuery();
con.Close();
          
          }
			
          if(tollname == "TollgateD"){
  			var date1 = DateTime.Now;
			String val = date1.ToLongDateString();
 con = new MySqlConnection();
con.ConnectionString = ConnectionString;			 
con.Open();
query = "INSERT INTO TollgateD (CardNumber,PhoneNumber,AmountPaid,Date,Day) VALUES('" + Vehiclenum + "','" + phoneNumber +"','" + VehicleAmnt +"','"+ DateTime.Now.ToString() +"','"+ val +"')";
 cmd = new MySqlCommand(query,con);
cmd.ExecuteNonQuery();
con.Close();
          
          }
			}
			
			if(dbAmnt < VehicleAmnt){
			
		COMPORT.WriteLine(phoneNumber + "," + databaseAmount + "," + tollname + "," + "I" + "\n");
			
			}
			
			
			
			
			
			}
			
			
			
			else{
				//unregistered vehicle
	 
			COMPORT.WriteLine( "0\r\n");
			}
		
		
		}
		
			private void receive(object sender, System.IO.Ports.SerialDataReceivedEventArgs e){
			received_data += COMPORT.ReadLine();
			this.Invoke(new  EventHandler(ProcessData));
			//Log.Text = received_data;
			received_data = "";
		   
		} 
		
				private void ProcessData(object sender, EventArgs e){
		
			try{
			indexOfA = Convert.ToSByte(received_data.IndexOf("A"));
		    Vehiclenum = received_data.Substring(0, indexOfA);
		    txtCardnumber.Text = Vehiclenum;
 
			db_send();
			}
					
		catch(Exception ex){
				MessageBox.Show(ex.ToString());
				COMPORT.Close();
			}
		
		}
		void BtnConnectClick(object sender, EventArgs e)
		{
	
		string PORT_NAME = cmbPORT.SelectedItem.ToString();
			const int baudrate = 9600;
			COMPORT = new SerialPort(PORT_NAME,baudrate);
			
			try{
				COMPORT.Open();
			btnConnect.Visible  = false;
			btnDisconnect.Visible = true;
			COMPORT.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(receive);
			
			
			}
			
			catch(Exception ex){
			
				MessageBox.Show(ex.ToString());
			}
				
			
		}
		void BtnDisconnectClick(object sender, EventArgs e)
		{
	        COMPORT.Close();
			btnConnect.Visible = true;
			btnDisconnect.Visible = false;
		}
		void BtnExitClick(object sender, EventArgs e)
		{
			MainForm fm = new MainForm();
			fm.Show();
			this.Hide();
			
		}
		void BtnTopUpClick(object sender, EventArgs e)
		{
	
			
 con = new MySqlConnection(); 
con.ConnectionString = ConnectionString;			
con.Open();
query = "SELECT AvailableBalance FROM _register WHERE CardNumber = ('" +  Vehiclenum +"')";
MySqlCommand cmd = new MySqlCommand(query,con);
			MySqlDataReader dataReader = cmd.ExecuteReader();
			dataReader.Read();
			if(dataReader.HasRows){
		String availbal = dataReader["AvailableBalance"] + "";
		int currentbal = Convert.ToInt16(availbal);
		int updatAmnt = Convert.ToInt16(txtAmntTopUp.Text);
		currentbal = currentbal + updatAmnt;
		String newbal  = Convert.ToString(currentbal);
		txtBalance.Text = newbal;
		con.Close();
		
				con = new MySqlConnection();
                con.ConnectionString = ConnectionString;			
                con.Open();
			     query = "UPDATE _register SET AvailableBalance = ('"+ newbal + "') WHERE CardNumber = ('" + Vehiclenum +"')";
			    cmd = new MySqlCommand(query,con);
	            dataReader = cmd.ExecuteReader();
			    dataReader.Read();
			    con.Close();
			    MessageBox.Show("Transaction Successfull");
			    //txtCardNum.Text = txtScardNum.Text = txtSnewBal.Text = "";
			    
			    
		
				
			
			
			}
			
			else{
				MessageBox.Show("Unregistered vehicle");
				//txtCardNum.Text = txtScardNum.Text = "";
			
			
			}			
		}
 
	}
}
