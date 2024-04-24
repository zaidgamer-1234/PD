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
        
        List<Muser> GetMuserList();

        Muser SignIn(Muser user);

        void SignUp(Muser muser);
      


    }
}
