using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testConsware.Models
{
    public class User
    {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int shop { get; set; }

        public User(string Email, string Password, int Shop)
        {
            email = Email;
            password = Password;
            shop = Shop;

        }
    }
}
