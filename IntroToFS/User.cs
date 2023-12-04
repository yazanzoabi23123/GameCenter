using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IntroToFS
{
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public User(string FirstName,string LastName ) {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
       
    }
}
