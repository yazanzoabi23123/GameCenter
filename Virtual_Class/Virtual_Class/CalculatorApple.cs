using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Class
{
    internal sealed class CalculatorApple:ICalculat
    {
        
        
        public CalculatorApple(int num1,int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }
        public int Num1 { get; set; }
        public  int Num2 { get; set; }
        public int Addition => Num1 + Num2;
        public int Subtraction => Num1 - Num2;
        public int Multiplication => Num1 * Num2;
        public decimal Division => Num1 / Num2;
    }
}
