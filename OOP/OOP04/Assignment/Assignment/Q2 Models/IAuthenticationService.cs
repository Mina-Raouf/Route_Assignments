using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Q2_Models
{
    internal interface IAuthenticationService
    {
        public bool AuthenticateUser(string UserName,string Password);
        public bool AuthorizeUser(string UserName);
    }
}
