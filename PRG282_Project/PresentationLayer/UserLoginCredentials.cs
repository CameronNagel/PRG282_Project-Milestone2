using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project.PresentationLayer
{
    class UserLoginCredentials
    {
        string username;
        string password;
        public UserLoginCredentials() { }

        public UserLoginCredentials(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        //Methods to get username and password
        public string getUserName(string username)
        {
            return username;
        }

        public string getUserPassword(string password)
        {
            return password;
        }
    }
}
