using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class DatabaseConnection
    {
        private DatabaseConnection()
        {
            Console.WriteLine("Connecting to the db....");

        }

        static private Lazy<DatabaseConnection> instance = new Lazy<DatabaseConnection>(() => new DatabaseConnection());

        static public DatabaseConnection Instance { get { return instance.Value; } }



        //methods.....

        public void SayHello()
        {

            Console.WriteLine("Hello from connection");
        }
    }
        
}
