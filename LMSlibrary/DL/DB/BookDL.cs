using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMSlibrary.Bl;
using LMSlibrary.DLInterfaces;

namespace LMSlibrary.DL.DB
{
    public class BookDL : IBook
    {
        private string ConnectionString;
        public BookDL(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }
        private bool ValidateProduct(Book book)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = string.Format("Select * from Books where Isbn = '{0}'", book.GetBookISbn());
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            bool check = reader.Read();
            connection.Close();
            return check;
        }
        public bool AddBook(Book book)
        {
            if (!ValidateProduct(book))
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                string InsertQuery = string.Format("Insert into Books (Title , Isbn, Edition, Status, AuthorName, AuthorCnic) VALUES ('{0}' , '{1}' , '{2}', '{3}', '{4}', '{5}') ", book.GetBookTitle(), book.GetBookISbn(), book.GetEdition(), book.GetStatus(), book.GetBookAuthor().GetName(), book.GetBookAuthor().GetCnic());
                SqlCommand command = new SqlCommand(InsertQuery, conn);
                int RowsAffected = command.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public List<Book> GetAllBooks()
        {
            List<Book> BookList = new List<Book>();
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = string.Format("SELECT * FROM Books");
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                
                Book book = new Book(Convert.ToString(reader["Title"]), Convert.ToString(reader["Isbn"]), Convert.ToString(reader["Edition"]), Convert.ToString(reader["Status"]), Convert.ToString(reader["AuthorName"]), Convert.ToString(reader["AuthorCnic"]));
                BookList.Add(book);
            }
            connection.Close();
            return BookList;
        }

        public bool RemoveBook(string ISBN)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string DltQuery = string.Format("Delete FROM Books where Isbn = '{0}'", ISBN);
            SqlCommand command = new SqlCommand(DltQuery, connection);
            int rows = command.ExecuteNonQuery();
            if(rows>1)
            {
                return true;
            }    
            else
            {
                return false;
            }
        }

        public bool UpdateBookEdition(string ISBN, string Edition)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string UpdateQuery = string.Format("Update Books SET Edition = '{0}' where Isbn = '{1}'", Edition, ISBN);
            SqlCommand command = new SqlCommand(UpdateQuery, connection);
            int rows = command.ExecuteNonQuery();
            if(rows>0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateBookTitle(string ISBN, string Title)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string UpdateQuery = string.Format("Update Books SET Title = '{0}' where Isbn = '{1}'", Title, ISBN);
            SqlCommand command = new SqlCommand(UpdateQuery, connection);
            int rows = command.ExecuteNonQuery();
            if (rows > 0)
            {
                return true;
            }
            return false;
        }
        public bool BorrowBooks(string Isbn)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = string.Format("Update Books set Status = 'checked' where Isbn = '{0}'", Isbn);
            SqlCommand cmd = new SqlCommand(query, connection);
            int rows = cmd.ExecuteNonQuery();
            if(rows > 0)
            {
                return true;
            }
            return false;
        }

        public List<Book> GetBorrowedBooks()
        {
            List<Book> BookList = new List<Book>();
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = string.Format("SELECT * FROM Books where Status = 'checked'");
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {

                Book book = new Book(Convert.ToString(reader["Title"]), Convert.ToString(reader["Isbn"]), Convert.ToString(reader["Edition"]), Convert.ToString(reader["Status"]), Convert.ToString(reader["AuthorName"]), Convert.ToString(reader["AuthorCnic"]));
                BookList.Add(book);
            }
            connection.Close();
            return BookList;
        }


    }
}
