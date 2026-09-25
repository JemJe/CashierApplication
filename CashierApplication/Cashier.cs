using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccountNamespace
{
    public class Cashier : UserAccount
    {
        private string department;

        public Cashier(string name, string department,string username, string password) : base(name, username, password)
        {
            this.department = department;
        }

        public override bool validateLogin(string username, string password)
        {
            return this.username == username && this.password == password;
        }

        public string getDepartment()
        {
            return department;
        }
    }
}