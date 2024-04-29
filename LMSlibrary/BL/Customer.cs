using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSlibrary.Bl
{
    public class Customer : Muser
    {
        private string Name;
        private string Gender;
        private string MobileNumber;
        private string FeedBack;
        public void SetFeedBack(string FeedBack)
        {
            this.FeedBack = FeedBack;
        }
        public string GetFeedBack()
        {
            return this.FeedBack;
        }
        private List<Book>BorrowedBooks = new List<Book>();

        public Customer(string Name , string Gender , string MobileNumber , string UserName, string Password,string Role) : base(UserName, Password, Role)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.MobileNumber = MobileNumber;

        }
        public Customer(string UserName, string Password, string Role) : base(UserName, Password, Role)
        {
            

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
            
        
        
    }
}
