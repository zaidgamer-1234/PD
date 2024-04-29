using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LMSlibrary.Bl;
namespace LMSlibrary.DLInterfaces
{
    public interface ICustomer
    {
        bool AddCustomer(Customer customer);
        bool RemoveCustomer(string UserName);
        bool UpdateMobileNumber(string MobileNumber, string UserName);
        bool UpdateGender(string MobileNumber, string UserName);
        bool UpdateName(string MobileNumber, string UserName);

        List<Customer> GetCustomers();
        List<string> GetFeedback();
        bool UpdateFeedback(string Feedback,string UserName);


    }
}
