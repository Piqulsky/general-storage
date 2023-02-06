using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
    public class Login { 
        public string username { get; set; }
        public Login(string username)
        {
            this.username = username;
        } 
    }
    public class Message
    {
        public string message { get; set; }
        public string target { get; set; }
        public bool isPrivate { get; set; }
        public Message(string message, string target, bool isPrivate)
        {
            this.message = message;
            this.target = target;
            this.isPrivate = isPrivate;
        }
    }
    public class Response
    {
        public int code { get; set; }
        public string error = null; public string message = null; public string from = null; public bool isPrivate = false;
    }
}
