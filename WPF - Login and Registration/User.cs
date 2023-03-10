using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usern
{
    internal class User
    {
        public string? Name { get; set; }
        public string? Password { get; set; }
        
        public List<User> users { get; set; }

        public User()
        {
        }

        public User(string? name, string? password)
        {
            Name = name;
            Password = password;
        }
    }
}
