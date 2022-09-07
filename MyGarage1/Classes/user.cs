using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyGarage1.Classes
{
    public class user
    {
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string email { get; set; }


        public user(string username, string password, string name, string email)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.email = email;
        }
        public user(user u1)
        {
            this.username = u1.username;
            this.password = u1.password;
            this.name = u1.name;
            this.email = u1.email;
        }
    }
}