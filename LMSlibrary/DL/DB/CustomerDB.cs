using LMSlibrary.Bl;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMSlibrary.DLInterfaces;
using System.Xml.Linq;
using System.Data;

namespace LMSlibrary.DL.DB
{
    public class CustomerDB:ICustomer 
    {
        public string ConnectionString = Utility.Utility.GetConnectionstring();
        public CustomerDB(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }
        public bool AddCustomer(Customer customer)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string InsertQuery = string.Format("Insert into Customer (Name , Gender, MblNo, Feedback, UserName) VALUES ('{0}' , '{1}' , '{2}', '{3}', '{4}') ", customer.GetName(), customer.GetGender(), customer.GetNumber(), customer.GetFeedBack(), customer.GetUsername());
            SqlCommand command = new SqlCommand(InsertQuery, conn);
            int RowsAffected = command.ExecuteNonQuery();
            if(RowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        public bool RemoveCustomer(string UserName)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string InsertQuery = string.Format("Delete FROM MUser where Username = '{0}'",UserName);
            SqlCommand command = new SqlCommand(InsertQuery, conn);
            int RowsAffected = command.ExecuteNonQuery();
            if (RowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateMobileNumber(string MobileNumber, string UserName)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string UpdateQuery = string.Format("Update Customer SET MblNo = '{0}' where UserName = '{1}'", MobileNumber, UserName);
            SqlCommand command = new SqlCommand(UpdateQuery, connection);
            int rows = command.ExecuteNonQuery();
            connection.Close();
            if(rows > 0)
            {
                return true;
            }
            return false;
        }
        public bool UpdateName(string Name, string UserName)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string UpdateQuery = string.Format("Update Customer SET Name = '{0}' where UserName = '{1}'", Name, UserName);
            SqlCommand command = new SqlCommand(UpdateQuery, connection);
            int rows = command.ExecuteNonQuery();
            connection.Close();
            if (rows > 0)
            {
                return true;
            }
            return false;
        }
        public bool UpdateFeedback(string Feedback, string UserName)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string UpdateQuery = string.Format("Update Customer SET Feedback = '{0}' where UserName = '{1}'", Feedback, UserName);
            SqlCommand command = new SqlCommand(UpdateQuery, connection);
            int rows = command.ExecuteNonQuery();
            connection.Close();
            if (rows > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateGender(string Gender, string UserName)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string UpdateQuery = string.Format("Update Customer SET Gender = '{0}' where UserName = '{1}'", Gender, UserName);
            SqlCommand command = new SqlCommand(UpdateQuery, connection);
            int rows = command.ExecuteNonQuery();
            connection.Close();
            if (rows > 0)
            {
                return true;
            }
            return false;
        }
        public List<Customer> GetCustomers()
        {
            List<Customer>userist = new List<Customer>();
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string query = string.Format("SELECT * FROM Customer");
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                Customer c = new Customer(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                userist.Add(c);
            }
            reader.Close();
            conn.Close();
            return userist;
        }
        public List<string> GetFeedback()
        {
            List<string> userist = new List<string>();
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string query = string.Format("SELECT * FROM Customer");
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                userist.Add(Convert.ToString(reader["Feedback"]));
            }
            reader.Close();
            conn.Close();
            return userist;
        }




    }
}
