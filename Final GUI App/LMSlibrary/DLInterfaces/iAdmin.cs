using LMSlibrary.Bl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSlibrary.DLInterfaces
{
    public interface IAdmin
    {
        void AddBook(Book book);

        void RemoveBook(string book);
        void UpdateBook(string edition , string Title);
        void RemoveAcc(string name);

        List<Book> GetBooksInfo();

        void UpdateAcc(string name, string password);
    }
}
