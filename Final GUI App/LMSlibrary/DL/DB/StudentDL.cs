using LMSlibrary.Bl;
using LMSlibrary.DLInterfaces;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSlibrary.DL.DB
{
    public class StudentDL : IStudent
    {
        public string ConnectionString = Utility.Utility.GetConnectionstring();
        public StudentDL(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }
       public void AddStudent(Customer customer)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string InsertQuery = string.Format("Insert into Students (Name , Gender, MblNo , Email) VALUES ('{0}' , '{1}' , '{2}' , '{3}') ", customer.GetName() , customer.GetGender() , customer.GetNumber() , customer.GetEmail());
            SqlCommand command = new SqlCommand(InsertQuery, conn);
            int RowsAffected = command.ExecuteNonQuery();

        }

       public List<Customer> GetInfo()
        {
            List<Customer> userList = new List<Customer>();
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string query = string.Format("SELECT * FROM Students");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Customer c = new Customer(reader.GetString(0), reader.GetString(1), reader.GetString(2) , reader.GetString(3));
                userList.Add(c);
            }
            connection.Close();
            return userList;
        }

       public void UpdateInfo(string name , string Email)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string UpdateQuery = string.Format("Update Students SET Email = '{0}' where Name = '{1}'", Email, name);
            SqlCommand command = new SqlCommand(UpdateQuery, connection);
            int rows = command.ExecuteNonQuery();
        }

        public  void BorrowBook(string Title)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = string.Format("Update Books set Isbn = 'checked' where Title = '{0}'", Title);
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
        }
        public List<Muser>GetStudent()
        {
            List<Muser> userList = new List<Muser>();
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string query = string.Format("SELECT * FROM MUser where id = 'checked'");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Muser m = new Muser(reader.GetString(1), reader.GetString(2), reader.GetString(3));
                userList.Add(m);
            }
            connection.Close();
            return userList;
        }
    }
   
}
