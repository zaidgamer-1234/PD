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
     
        
        public Book()
        {

        }

        public Book(string BookTitle , string BookIsbn , string Edition)
        {
            this.BookTitle = BookTitle;
            this.BookIsbn = BookIsbn;
            this.Edition = Edition;
           
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
