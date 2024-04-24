using LMSlibrary.Bl;
using LMSlibrary.DLInterfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSlibrary.DL
{
    public class MuserDL
    {
        
        private static List<Muser>MuserList = new List<Muser>();

        public static void AddUserIntoList(Muser muser)
        {
            MuserList.Add(muser);
        }

        public  List<Muser> GetMuserList() 
        {
            return MuserList;
        }

        public static bool UserSignIn(Muser user)
        {
            foreach(Muser users in MuserList)
            {
                if(user.GetUsername() == users.GetUsername() && user.GetPassword() == users.GetPassword())
                {
                    return true;
                }
            }
            return false;
        }

        public  bool IsAdminRegistered(Muser user)
        {
            int AdminCount = 0;
            foreach(Muser musers in MuserList)
            {
                if(user.GetRole() == musers.GetRole())
                {
                    AdminCount++;
                }
            }
            return AdminCount >=1 ? true : false;
        }
      

    }
}
