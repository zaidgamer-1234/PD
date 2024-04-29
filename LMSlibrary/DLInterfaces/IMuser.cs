using LMSlibrary.Bl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSlibrary.DLInterfaces
{
    public interface IMuser
    {
        
        List<Muser> GetMuserList();//display user lists

        Muser SignIn(Muser user);//read data from database or file to log in

        void SignUp(Muser muser);// add data in database or file to sign up
        bool RemoveAccount(string UserName);
        bool UpdatePassword(string UserName, string Password);
        List<Muser> GetCustomerList();



    }
}
