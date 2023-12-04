using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToFS
{
    internal class Students
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public List<string> courses { get; set; }
        public List<Students> students { get; set; }

    }
}
