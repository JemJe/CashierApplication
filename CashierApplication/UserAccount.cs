using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccountNamespace
{
    public abstract class UserAccount
    {
        private string fullName;
        protected string username;
        protected string password;

        public UserAccount(string fullName, string username, string password)
        {
            this.fullName = fullName;
            this.username = username;
            this.password = password;
        }

        public abstract bool validateLogin(string username, string password);

        public string getFullName()
        {
            return fullName;
        }
    }
}
