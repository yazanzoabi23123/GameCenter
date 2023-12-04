using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Class
{
    internal class Animal
    {
        protected string sound="AnimalSound";

       
        public virtual void  MakeSound()
        {
            Console.WriteLine("The animal "+sound);
        }
    }
}
