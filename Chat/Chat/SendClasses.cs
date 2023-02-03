using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    public class Login { 
        public string username; 
        public Login(string username)
        {
            this.username = username;
        } 
    }
    public class Message
    {
        public string message; public string target; public bool isPrivate;
        public Message(string message, string target)
        {
            this.message = message;
            this.target = target;
        }
    }
    public class Response
    {
        int code; string error = null; string message = null; string from = null; bool isPrivate = false;
    }
}
