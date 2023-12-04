using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Logger
    {
        private Logger()
        {
            Console.WriteLine("Connecting to the db....");

        }
        static private Lazy<Logger> instance = new Lazy<Logger>(() => new Logger());
        static public Logger Instance { get { return instance.Value; } }
        public void RecordLogIn(string user)
        {

            Console.WriteLine("new log in user : " + user);

        }

        public void RecordSignUp(string user)

        {

            Console.WriteLine("new sign up - user : " + user);

        }
    }
}
