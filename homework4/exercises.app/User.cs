using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises.app
{
    public class User
    {
        public User (int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
            Message = new string[] { "Hi there", "I hope you're having a great week" };
        }
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string[] Message { get; set; }
    }
}
