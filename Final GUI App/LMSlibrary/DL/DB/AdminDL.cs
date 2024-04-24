using LMSlibrary.Bl;
using LMSlibrary.DLInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace LMSlibrary.DL
{
    public class AdminDL : IAdmin
    {
        public string ConnectionString = Utility.Utility.GetConnectionstring();
        public AdminDL(string ConnectionString) 
        {
            this.ConnectionString = ConnectionString; 
        }

        public void AddBook(Book book)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string InsertQuery = string.Format("Insert into Books (Title , Isbn, Edition) VALUES ('{0}' , '{1}' , '{2}') ", book.GetBookTitle(), book.GetBookISbn(), book.GetEdition()); 
            SqlCommand command = new SqlCommand(InsertQuery, conn); 
            int RowsAffected = command.ExecuteNonQuery();
           
        }

        public void RemoveBook(string book) 
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string DltQuery = string.Format("Delete FROM Books where Title = '{0}'", book);
            SqlCommand command = new SqlCommand(DltQuery, connection);
            int rows = command.ExecuteNonQuery();   
            

        }

        public void UpdateBook(string edition , string Title)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string UpdateQuery = string.Format("Update Books SET Edition = '{0}' where Title = '{1}'", edition , Title);
            SqlCommand command = new SqlCommand(UpdateQuery, connection);
            int rows = command.ExecuteNonQuery();
            
        }

        public List<Book> GetBooksInfo()
        {
            List<Book> BookList = new List<Book>();
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = string.Format("SELECT * FROM Books");
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while(reader.Read())
            {
                Book book = new Book(reader.GetString(0) , reader.GetString(1) , reader.GetString(2));
                BookList.Add(book); 
            }
            connection.Close();
            return BookList;

        }
        public void RemoveAcc(string name)
        {
            SqlConnection connection = new SqlConnection(Utility.Utility.GetConnectionstring());
            connection.Open();
            string DltQuery = string.Format("Delete FROM MUser where Username = '{0}'", name);
            SqlCommand command = new SqlCommand(DltQuery, connection);
            int rows = command.ExecuteNonQuery();


        }

        public void UpdateAcc(string name, string password)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string UpdateQuery = string.Format("Update MUser SET Password = '{0}' where Username = '{1}'", password, name);
            SqlCommand command = new SqlCommand(UpdateQuery, connection);
            int rows = command.ExecuteNonQuery();
        }
    }
}
