using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSlibrary.Bl
{
    public class Admin : Muser
    {
        private List<Book> book = new List<Book>();

        public Admin(string Username , string Password , string Role) : base(Username , Password , Role) 
        {

        }


        public void AddBook(Book book)
        {
            this.book.Add(book);
        }
        public void RemoveBook(Book book)
        {
            this.book.Remove(book);
        }
        public List<Book> GetBookList()
        {
            return this.book;
        }
        
    }
}
