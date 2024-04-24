using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSlibrary.Bl
{
    public class Admin : Muser
    {
        public Admin(string Username , string Password , string Role) : base(Username , Password , Role) 
        {

        }

        private List<Book>book = new List<Book>();
        
    }
}
