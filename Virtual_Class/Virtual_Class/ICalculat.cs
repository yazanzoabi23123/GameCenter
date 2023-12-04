using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Class
{
    internal interface ICalculat
    {
        int Num1 { get; set; }
        int Num2 { get; set; }
        int Addition { get;}
        int Subtraction { get;}
        int Multiplication { get;}
        decimal Division { get; }
    }
}
