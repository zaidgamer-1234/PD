using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSlibrary.Bl
{
    public  class Author
    {
        private string Name;
        private string CNIC;

        public Author(string Name, string CNIC)
        {
            this.Name = Name;
            this.CNIC = CNIC;
        }

        public Author() 
        {

        }

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public void SetCnic(string CNIC)
        {
            this.CNIC = CNIC;
        }

        public string GetName()
        {
            return this.Name;
        }

        public string GetCnic()
        {
            return this.CNIC;
        }
    }
}
