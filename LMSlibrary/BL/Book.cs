using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMSlibrary.DL;

namespace LMSlibrary.Bl
{
    public class Book
    {
        private string BookTitle;
        private string BookIsbn;
        private string Edition;
        private string Status;
        private Author author;
     
        
        public Book()
        {

        }

        public Book(string BookTitle , string BookIsbn , string Edition,string status, string Name, string Cnic)
        {
            this.BookTitle = BookTitle;
            this.BookIsbn = BookIsbn;
            this.Edition = Edition;
            this.Status = status;
            author=new Author(Name, Cnic);
           
        }
        public void SetStatus(string Status)
        {
            this.Status=Status;
        }
        public string GetStatus()
        {
            return this.Status;
        }
        public void AddAuthor(Author author)
        {
            this.author = author;
        }
        public Author GetBookAuthor()
        {
            return this.author;
        }
        public void SetBookTitle(string BookTitle)
        {
            this.BookTitle = BookTitle;
        }

        public void SetBookIsbn(string BookIsbn)
        {
            this.BookIsbn = BookIsbn;
        }

        public void SetEdition(string Edition)
        {
            this.Edition = Edition;
        }

        public string GetBookTitle() 
        {
            return BookTitle;
        }

        public string GetBookISbn()
        {
            return BookIsbn;
        }

        public string GetEdition()
        {
            return Edition;
        }
    }
}
