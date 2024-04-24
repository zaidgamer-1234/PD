﻿using LMSlibrary.Bl;
using LMSlibrary.DLInterfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSlibrary.DL.DB
{
    public class MuserDbStore : IMuser
    {
        public string ConnectionString = Utility.Utility.GetConnectionstring();
        public MuserDbStore(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }

        private bool ValidateUser(Muser user , string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = string.Format("Select * from MUser where Username = '{0}'", user.GetUsername());
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            bool check = reader.Read();
            connection.Close();
            return check;
        }

       public void SignUp(Muser muser)
        {
            if(!ValidateUser(muser ,  ConnectionString))
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
                string InsertQuery = string.Format("INSERT INTO MUser (Username , Password , Role) VALUES ('{0}' , '{1}' , '{2}')", muser.GetUsername(), muser.GetPassword(), muser.GetRole());
                SqlCommand command = new SqlCommand(InsertQuery, connection);
                int RowsAffected = command.ExecuteNonQuery();
                connection.Close();
            }
        }

       public  Muser SignIn(Muser user)
        {
            SqlConnection connection = new SqlConnection (ConnectionString);
            connection.Open();
            string query = string.Format("SELECT * FROM MUser where Username = '{0}' AND Password ='{1}'", user.GetUsername(), user.GetPassword());
            SqlCommand command = new SqlCommand (query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {
                Muser muser = new Muser(reader.GetString(1), reader.GetString(2), reader.GetString(3));
                connection.Close();
                return muser;
            }
            connection.Close();
             return null;
        }

       public List<Muser> GetMuserList()
        {
            List<Muser>userList = new List<Muser>();
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string query = string.Format("SELECT * FROM MUser");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                Muser muser = new Muser(reader.GetString(1), reader.GetString(2), reader.GetString(3));
                userList.Add(muser);
            }
            connection.Close();
            return userList;
        }

       
    }
}
