using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_extension_LINQ
{
    internal class UserRegistration
    {
        public delegate void UserRegistered();
        public event UserRegistered OnUserRegistered;
        public void Registration()
        {
            Console.WriteLine("User registered!");
            OnUserRegistered?.Invoke();
        }
    }

}

