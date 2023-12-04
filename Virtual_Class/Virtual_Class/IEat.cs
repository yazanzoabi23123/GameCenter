using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Class
{
    internal interface IEat
    {
        string FoodType { get; set; }
        void Eat();
    }
}
