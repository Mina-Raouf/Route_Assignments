using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{
    internal class UserViewModel
    {
        public  int Id { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }
        public string Email { get; set; }

        public static explicit operator UserViewModel (User user)
        {
            string[] names= user?.FullName?.Split (',');
            return new UserViewModel()
            {
                Id = user.Id,
                FName = names?.Length > 0 ? names[0] : "",
                LName = names?.Length > 1 ? names[1] : "",
                Email=user.Email
            };


        }
    }
}
