using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Class
{
    internal class Dog:Animal
    {
        public Dog(string dogSound) {
            sound = dogSound;
        }
        public override void MakeSound()
        {
            Console.WriteLine("The dog does " + sound);
        }
    }
}
