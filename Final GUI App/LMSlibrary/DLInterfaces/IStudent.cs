using LMSlibrary.Bl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSlibrary.DLInterfaces
{
    public interface IStudent
    {
        void AddStudent(Customer customer);

        List<Customer> GetInfo();

        void UpdateInfo(string name , string Email);

        void BorrowBook(string Title);

        List<Muser> GetStudent();
    }
}
