using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_abstract_project
{
    internal abstract class Shape
    {
        public string Name { get; set; }
        public int Angles { get; set; }
        public void SayMyName()
        {
            Console.WriteLine("Hello I am " + Name);
        }
       
        public abstract double CalculatePerimeter();
        public abstract double CalculateArea();

    }
}
