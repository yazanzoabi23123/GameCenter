using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Class
{
    internal class Pizaa
    {
        internal class Pizza
        {
            private string _baseType;
            private string[] _toppings;
            private int _bakeTime;

            public Pizza(string baseType, string[] toppings)
            {
                _baseType = baseType;
                _toppings = toppings;
            }

            public void MakePizza()
            {
                MakeBase();
                MakeToppings();
                Bake();
            }
            private void MakeBase()
            {
                Console.WriteLine("Making the base " + _baseType);
            }
            private void MakeToppings()
            {
                foreach (string topping in _toppings)
                {
                    Console.WriteLine("Adding the topping " + topping);
                }
            }

            private void Bake()
            {
                _bakeTime = _baseType == "thing" ? 10 : 20;
                Console.WriteLine("Baking for " + _bakeTime + " minutes");
            }


        }
    }
}
