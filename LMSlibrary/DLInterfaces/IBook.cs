using LMSlibrary.Bl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSlibrary.DLInterfaces
{
    public interface IBook
    {
        bool AddBook(Book book);
        bool RemoveBook(string ISBN);
        bool UpdateBookTitle(string ISBN, string Title);
        bool UpdateBookEdition(string ISBN, string Edition);
        List<Book> GetAllBooks();
        bool BorrowBooks(string ISBN);
        List<Book> GetBorrowedBooks();
    }
}
