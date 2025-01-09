using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Q2_Models
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public string UserName { get; set; } = "Mina";
        public string Password { get; set; } = "1234";

        public string authorized { get; set; } = "Mina";
        public bool AuthenticateUser(string UserName, string Password)
        {
            return this.UserName == UserName && this.Password == Password;
        }

        public bool AuthorizeUser(string UserName)
        {
            return UserName == authorized;
        }
    }
}
