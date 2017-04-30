using System;

namespace WebApplication1.Infrastructure.Events
{   
    public class ShowTextEventArgs : EventArgs
    {
        private readonly string _msg;
        public ShowTextEventArgs(string s)
        {
            _msg = s;
        }            

        public string Message
        {
            get { return _msg; }
        }
    }
    
}