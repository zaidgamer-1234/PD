using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSlibrary.Utility
{
    public class Utility//class to get connnection string
    {
        private static string ConnectionString = "Data Source=DESKTOP-T8PSK9I\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True;";
        public static string GetConnectionstring()
        {
            return ConnectionString;
        }
    

    }
}
