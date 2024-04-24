using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSlibrary.Bl
{
    public class Customer
    {
        private string Name;
        private string Gender;
        private string MobileNumber;
        private string Email;
        private List<Book>book = new List<Book>();

        public Customer(string Name , string Gender , string MobileNumber , string Email) 
        {
            this.Name = Name;
            this.Gender = Gender;
            this.MobileNumber = MobileNumber;
            this.Email = Email;
        }

        public void SetCustomerName(string Name)
        {
            this.Name = Name;
        }

        public void SetGender(string Gender) 
        {
            this.Gender = Gender;   
        }

        public void SetMblNmbr(string MobileNumber)
        {
            this.MobileNumber = MobileNumber;
        }
        public void SetEmail(string Email)
        {
            this.Email = Email;
        }
        public string GetName() 
        {
            return this.Name;
        }
        public string GetGender()
        {
            return this.Gender;
        }
        public string GetNumber()
        {
            return this.MobileNumber;
        }

        public string GetEmail()
        {
            return this.Email;
        }
            
        
        
    }
}
