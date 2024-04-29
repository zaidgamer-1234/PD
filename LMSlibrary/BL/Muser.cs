using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSlibrary.Bl
{
    public  class Muser
    {
        protected string Username;
        protected string Password;
        protected string Role;

        public Muser()
        {

        }
        public Muser(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password; 
        }

        public Muser(string Username, string Password, string Role)
        {
            this.Username = Username;
            this.Password = Password;
            this.Role = Role;
        }

        public bool SetUsername(string username)
        {
            if (!string.IsNullOrEmpty(username))
            {
                this.Username = username;
                return true;
            }
            return false;
        }

        public bool SetPassword(string password)
        {
            if (!string.IsNullOrEmpty(password))
            {
                this.Password = password;
                return true;
            }
            return false;
        }

        public bool SetRole(string role)
        {
            if (!string.IsNullOrEmpty(role))
            {
                this.Role = role;
                return true;
            }
            return false;
        }

        public string GetUsername()
        {
            return Username;
        }

        public string GetPassword()
        {
            return Password;
        }

        public string GetRole()
        {
            return Role;
        }

        public bool isAdmin()
        {
            if (this.Role == "admin")
            {

                return true;
            }
            else
            {
                return false;
            }

        }

        public bool isCustomer()
        {
            if (this.Role == "customer")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
