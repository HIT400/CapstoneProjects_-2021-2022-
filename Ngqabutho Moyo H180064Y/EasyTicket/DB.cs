<<<<<<< HEAD
﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyTicket
{
    //Public database class containing CRUD functions

    class DB
    {
        //DataTable objects will be referenced by all SELECT queries
        DataTable dt = new DataTable();
        DataTable dtActiveUsers = new DataTable();
        DataTable dtNonActiveUsers = new DataTable();

        //Generate and return a connection string
        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Host=localhost; Port=5432; User Id=postgres; Password=LookSideways220; Database=easyticket;");
        }

        //Populate commuter table
        public bool InsertIntoCommuter(string national_id, string first_name, string last_name, DateTime dob, string sex, string address, string phone, string email, string username, string password, DateTime created_on, double deposit)
        {
            string insert = "INSERT INTO public.commuter(national_id, first_name, last_name, date_of_birth, sex, address, phone, email, username, password, created_on, balance) " +
                "VALUES(@national_id, @first_name, @last_name, @date_of_birth, @sex, @address, @phone, @email, @username, @password, @created_on, @balance);";
            using (NpgsqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(insert, connection);
                    command.Parameters.AddWithValue(@"national_id", national_id);
                    command.Parameters.AddWithValue(@"first_name", first_name);
                    command.Parameters.AddWithValue(@"last_name", last_name);
                    command.Parameters.AddWithValue(@"date_of_birth", dob);
                    command.Parameters.AddWithValue(@"sex", sex);
                    command.Parameters.AddWithValue(@"address", address);
                    command.Parameters.AddWithValue(@"phone", phone);
                    command.Parameters.AddWithValue(@"email", email);
                    command.Parameters.AddWithValue(@"username", username);
                    command.Parameters.AddWithValue(@"password", password);
                    command.Parameters.AddWithValue(@"created_on", created_on);
                    command.Parameters.AddWithValue(@"balance", deposit);

                    command.ExecuteNonQuery();

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

        //Insert into public.trip when a commuter pays; this table will be used for maintaining a record of a commuter's receipts
        public bool InsertIntoTrip(string username, string _from, string _to, double price)
        {
            DateTime date_of_trip = DateTime.Today;
            DateTime time_of_trip = DateTime.Now.ToLocalTime();
            string insert = "INSERT INTO public.trip(username, _from, _to, price, _date, _time) " +
                "VALUES (@username, @_from, @_to, @price, @_date, @_time);";
            using (NpgsqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(insert, connection);
                    command.Parameters.AddWithValue(@"username", username);
                    command.Parameters.AddWithValue(@"_from", _from);
                    command.Parameters.AddWithValue(@"_to", _to);
                    command.Parameters.AddWithValue(@"price", price);
                    command.Parameters.AddWithValue(@"_date", date_of_trip);
                    command.Parameters.AddWithValue(@"_time", time_of_trip);

                    command.ExecuteNonQuery();

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

        //Logging in as a user
        public bool LoginUser(string username, string password)
        {
            string select_sql = "SELECT * FROM public.commuter WHERE username=@username AND password=@password;";
            //DataTable dt = new DataTable();

            using (NpgsqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(select_sql, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

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

        //Logging in as an admin
        public bool LoginAdmin(string admin_id, string password)
        {
            string select_sql = "SELECT * FROM public.admin WHERE admin_id=@admin_id AND password=@password;";
            //DataTable dt = new DataTable();

            using (NpgsqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(select_sql, connection);
                    command.Parameters.AddWithValue("@admin_id", admin_id);
                    command.Parameters.AddWithValue("@password", password);
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

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

        //Return revenue per commuter 
        //For admin use only
        public DataTable SelectActiveUsers()
        {
            string select = "SELECT username AS commuter, SUM(price) AS revenue FROM public.trip GROUP BY username;";

            using(NpgsqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(select, connection);
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                    da.Fill(dtActiveUsers);
                    return dtActiveUsers;                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        //Return total revenue
        //For admin use only
        public DataTable CalculateRevenue()
        {
            string select = "SELECT SUM(price) AS total_revenue FROM public.trip";
            using(NpgsqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(select, connection);
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                    adapter.Fill(dtActiveUsers);
                    return dtActiveUsers;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        //Return non-active users (registered accounts that have not paid for a trip)
        //For admin use only
        public DataTable SelectNonActiveUsers()
        {
            string select = "SELECT DISTINCT ON (commuter.username) commuter.username FROM public.commuter LEFT JOIN public.trip ON commuter.username = trip.username WHERE trip.username IS NULL";
            using (NpgsqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(select, connection);
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                    da.Fill(dtNonActiveUsers);
                    return dtNonActiveUsers;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

       //Verifying a password prior to a transaction
       public bool VerifyPassword(string username, string password)
        {
            DataTable dt = new DataTable();
            string select_sql = "SELECT username, password FROM public.commuter WHERE username=@username AND password=@password;";

            using (NpgsqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(select_sql, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

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

        //Updating a record after a topup or payment
        public bool UpdateCommuterBalance(string username, double new_balance)
        {
            string update = "UPDATE public.commuter SET balance=@balance WHERE username=@username;";
            using (NpgsqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(update, connection);
                    command.Parameters.AddWithValue(@"balance", new_balance);
                    command.Parameters.AddWithValue(@"username", username);

                    command.ExecuteNonQuery();

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

        //Updating a user's personal details
        public bool UpdateCommuterDetails(string username, string address, string phone, string email)
        {
            string update = "UPDATE public.commuter	SET address=@address, phone=@phone, email=@email WHERE username=@username;";
            using (NpgsqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(update, connection);
                    command.Parameters.AddWithValue(@"address", address);
                    command.Parameters.AddWithValue(@"phone", phone);
                    command.Parameters.AddWithValue(@"email", email);
                    command.Parameters.AddWithValue(@"username", username);

                    command.ExecuteNonQuery();

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

        //Updating a user's password
        public bool ChangePassword(string username, string password)
        {
            string update = "UPDATE public.commuter SET password=@password WHERE username=@username;";
            using (NpgsqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(update, connection);
                    command.Parameters.AddWithValue(@"username", username);
                    command.Parameters.AddWithValue(@"password", password);

                    command.ExecuteNonQuery();

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

        //Delete a user's account
        public bool DeleteAccount(string username)
        {
            string delete = "DELETE FROM public.commuter WHERE username=@username";
            using(NpgsqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(delete, connection);
                    command.Parameters.AddWithValue(@"username", username);
                    command.ExecuteNonQuery();

                    return true;
                }
                catch(Exception ex)
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
    }
}
=======
﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyTicket
{
    //Public database class containing CRUD functions

    class DB
    {
        //DataTable objects will be referenced by all SELECT queries
        DataTable dt = new DataTable();
        DataTable dtActiveUsers = new DataTable();
        DataTable dtNonActiveUsers = new DataTable();

        //Generate and return a connection string
        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Host=localhost; Port=5432; User Id=postgres; Password=LookSideways220; Database=easyticket;");
        }

        //Populate commuter table
        public bool InsertIntoCommuter(string national_id, string first_name, string last_name, DateTime dob, string sex, string address, string phone, string email, string username, string password, DateTime created_on, double deposit)
        {
            string insert = "INSERT INTO public.commuter(national_id, first_name, last_name, date_of_birth, sex, address, phone, email, username, password, created_on, balance) " +
                "VALUES(@national_id, @first_name, @last_name, @date_of_birth, @sex, @address, @phone, @email, @username, @password, @created_on, @balance);";
            using (NpgsqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(insert, connection);
                    command.Parameters.AddWithValue(@"national_id", national_id);
                    command.Parameters.AddWithValue(@"first_name", first_name);
                    command.Parameters.AddWithValue(@"last_name", last_name);
                    command.Parameters.AddWithValue(@"date_of_birth", dob);
                    command.Parameters.AddWithValue(@"sex", sex);
                    command.Parameters.AddWithValue(@"address", address);
                    command.Parameters.AddWithValue(@"phone", phone);
                    command.Parameters.AddWithValue(@"email", email);
                    command.Parameters.AddWithValue(@"username", username);
                    command.Parameters.AddWithValue(@"password", password);
                    command.Parameters.AddWithValue(@"created_on", created_on);
                    command.Parameters.AddWithValue(@"balance", deposit);

                    command.ExecuteNonQuery();

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

        //Insert into public.trip when a commuter pays; this table will be used for maintaining a record of a commuter's receipts
        public bool InsertIntoTrip(string username, string _from, string _to, double price)
        {
            DateTime date_of_trip = DateTime.Today;
            DateTime time_of_trip = DateTime.Now.ToLocalTime();
            string insert = "INSERT INTO public.trip(username, _from, _to, price, _date, _time) " +
                "VALUES (@username, @_from, @_to, @price, @_date, @_time);";
            using (NpgsqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(insert, connection);
                    command.Parameters.AddWithValue(@"username", username);
                    command.Parameters.AddWithValue(@"_from", _from);
                    command.Parameters.AddWithValue(@"_to", _to);
                    command.Parameters.AddWithValue(@"price", price);
                    command.Parameters.AddWithValue(@"_date", date_of_trip);
                    command.Parameters.AddWithValue(@"_time", time_of_trip);

                    command.ExecuteNonQuery();

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

        //Logging in as a user
        public bool LoginUser(string username, string password)
        {
            string select_sql = "SELECT * FROM public.commuter WHERE username=@username AND password=@password;";
            //DataTable dt = new DataTable();

            using (NpgsqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(select_sql, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

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

        //Logging in as an admin
        public bool LoginAdmin(string admin_id, string password)
        {
            string select_sql = "SELECT * FROM public.admin WHERE admin_id=@admin_id AND password=@password;";
            //DataTable dt = new DataTable();

            using (NpgsqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(select_sql, connection);
                    command.Parameters.AddWithValue("@admin_id", admin_id);
                    command.Parameters.AddWithValue("@password", password);
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

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

        //Return revenue per commuter 
        //For admin use only
        public DataTable SelectActiveUsers()
        {
            string select = "SELECT username AS commuter, SUM(price) AS revenue FROM public.trip GROUP BY username;";

            using(NpgsqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(select, connection);
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                    da.Fill(dtActiveUsers);
                    return dtActiveUsers;                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        //Return total revenue
        //For admin use only
        public DataTable CalculateRevenue()
        {
            string select = "SELECT SUM(price) AS total_revenue FROM public.trip";
            using(NpgsqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(select, connection);
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                    adapter.Fill(dtActiveUsers);
                    return dtActiveUsers;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        //Return non-active users (registered accounts that have not paid for a trip)
        //For admin use only
        public DataTable SelectNonActiveUsers()
        {
            string select = "SELECT DISTINCT ON (commuter.username) commuter.username FROM public.commuter LEFT JOIN public.trip ON commuter.username = trip.username WHERE trip.username IS NULL";
            using (NpgsqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(select, connection);
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                    da.Fill(dtNonActiveUsers);
                    return dtNonActiveUsers;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

       //Verifying a password prior to a transaction
       public bool VerifyPassword(string username, string password)
        {
            DataTable dt = new DataTable();
            string select_sql = "SELECT username, password FROM public.commuter WHERE username=@username AND password=@password;";

            using (NpgsqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(select_sql, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

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

        //Updating a record after a topup or payment
        public bool UpdateCommuterBalance(string username, double new_balance)
        {
            string update = "UPDATE public.commuter SET balance=@balance WHERE username=@username;";
            using (NpgsqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(update, connection);
                    command.Parameters.AddWithValue(@"balance", new_balance);
                    command.Parameters.AddWithValue(@"username", username);

                    command.ExecuteNonQuery();

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

        //Updating a user's personal details
        public bool UpdateCommuterDetails(string username, string address, string phone, string email)
        {
            string update = "UPDATE public.commuter	SET address=@address, phone=@phone, email=@email WHERE username=@username;";
            using (NpgsqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(update, connection);
                    command.Parameters.AddWithValue(@"address", address);
                    command.Parameters.AddWithValue(@"phone", phone);
                    command.Parameters.AddWithValue(@"email", email);
                    command.Parameters.AddWithValue(@"username", username);

                    command.ExecuteNonQuery();

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

        //Updating a user's password
        public bool ChangePassword(string username, string password)
        {
            string update = "UPDATE public.commuter SET password=@password WHERE username=@username;";
            using (NpgsqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(update, connection);
                    command.Parameters.AddWithValue(@"username", username);
                    command.Parameters.AddWithValue(@"password", password);

                    command.ExecuteNonQuery();

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

        //Delete a user's account
        public bool DeleteAccount(string username)
        {
            string delete = "DELETE FROM public.commuter WHERE username=@username";
            using(NpgsqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(delete, connection);
                    command.Parameters.AddWithValue(@"username", username);
                    command.ExecuteNonQuery();

                    return true;
                }
                catch(Exception ex)
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
    }
}
>>>>>>> parent of 5a30ca7... commit message
