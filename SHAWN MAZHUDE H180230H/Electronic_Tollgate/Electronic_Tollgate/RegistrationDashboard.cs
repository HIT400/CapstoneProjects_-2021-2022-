/*
 * Created by SharpDevelop.
 * User: 26378
 * Date: 4/4/2022
 * Time: 1:46 PM
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
	/// Description of RegistrationDashboard.
	/// </summary>
	public partial class RegistrationDashboard : Form
	{
		String received_data;
		String Vehiclenum;
		SerialPort COMPORT;
		String positionTxt;
        MySqlConnection con;
		String query;
		sbyte indexOfA;
		String ConnectionString = "server=127.0.0.1;uid=root;" + "pwd=;database=etolling;SSL Mode=0";
		
		
		public RegistrationDashboard()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			cmbPort.Items.AddRange(SerialPort.GetPortNames());
			btnConnect.Visible  = true;
			btnDisconnect.Visible = false;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
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
		    txtCardNum.Text = txtScardNum.Text = Vehiclenum;
			//txtCard.Text = ve;
			//Thread.Sleep(500);
			//db_send();
			COMPORT.WriteLine("T\r\n");
			}
					
		catch(Exception ex){
				MessageBox.Show(ex.ToString());
				COMPORT.Close();
			}
		
		}
		void Label5Click(object sender, EventArgs e)
		{
	
		}
		void BtnDisconnectClick(object sender, EventArgs e)
		{
			COMPORT.Close();
			btnConnect.Visible = true;
			btnDisconnect.Visible = false;
		}
		void BtnConnectClick(object sender, EventArgs e)
		{
			string PORT_NAME = cmbPort.SelectedItem.ToString();
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
		void BtnExitClick(object sender, EventArgs e)
		{
			MainForm fm = new MainForm();
			fm.Show();
			this.Hide();
		}
		void BtnRecordsClick(object sender, EventArgs e)
		{
			Allrecords ar = new Allrecords();
			ar.Show();
			this.Hide();
		}
		void BtnRegisterClick(object sender, EventArgs e)
		{
	           con = new MySqlConnection();
           con.ConnectionString = ConnectionString;			
con.Open();
query = "SELECT NumberPlate FROM _register WHERE CardNumber = ('" +  txtCardNum.Text +"')";
MySqlCommand cmd = new MySqlCommand(query,con);
			MySqlDataReader dataReader = cmd.ExecuteReader();
			dataReader.Read();
	if(dataReader.HasRows){
 
				MessageBox.Show("Already in the System");
				txtOwner.Text = txtPhonenum.Text = txtNumplate.Text = txtCardNum.Text = txtAmount.Text = "";
				cmbClass.SelectedIndex = -1;
				con.Close();
			}
			
			else{
			
con.Close();
con = new MySqlConnection();
con.ConnectionString = ConnectionString;			
con.Open();
String Vehicleclass = cmbClass.SelectedItem.ToString();
query = "INSERT INTO  _register (VehicleOwner,PhoneNumber,NumberPlate,CardNumber,VehicleClass,AvailableBalance,Date) VALUES('" + txtOwner.Text + "','" + txtPhonenum.Text +"','" + txtNumplate.Text +"','"+ txtCardNum.Text+"','"+ Vehicleclass+"','"+ txtAmount.Text +"','"+ DateTime.Now.ToString() +"')";
 cmd = new MySqlCommand(query,con);
cmd.ExecuteNonQuery();

query = "INSERT INTO  users (name,email,password) VALUES('" + txtOwner.Text + "','" + txtNumplate.Text +"@tollgate.co.zw','" + txtPhonenum.Text +"';";
 cmd = new MySqlCommand(query,con);
cmd.ExecuteNonQuery();


MessageBox.Show("Registration Successful");
txtOwner.Text = txtPhonenum.Text = txtNumplate.Text = txtCardNum.Text = txtAmount.Text = "";
cmbClass.SelectedIndex = -1;
 con.Close();
			
			}
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
		int updatAmnt = Convert.ToInt16(txtSamountPaid.Text);
		currentbal = currentbal + updatAmnt;
		String newbal  = Convert.ToString(currentbal);
		txtSnewBal.Text = newbal;
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
