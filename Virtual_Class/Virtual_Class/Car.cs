using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Class
{
    internal class Car: Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("The CAR is driving");
        }
    }
}
