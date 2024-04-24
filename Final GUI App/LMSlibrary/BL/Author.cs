using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSlibrary.Bl
{
    public  class Author
    {
        private string Name;
        private string CNIC;
        private Book book;
        private List<Book>Book = new List<Book>();

        public Author(string Name, string CNIC , string BookTitle , string BookIsbn , string Edition)
        {
            this.Name = Name;
            this.CNIC = CNIC;
            book = new Book(BookTitle, BookIsbn, Edition);
        }

        public Author() 
        {

        }

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public void SetCnic(string CNIC)
        {
            this.CNIC = CNIC;
        }

        public string GetName()
        {
            return this.Name;
        }

        public string GetCnic()
        {
            return this.CNIC;
        }
    }
}
