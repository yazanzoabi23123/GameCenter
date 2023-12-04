using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Class
{
    internal class Vehicle
    {
        public virtual void Drive()
        {
            Console.WriteLine("The vheicle is driving");
        }
    }
}
