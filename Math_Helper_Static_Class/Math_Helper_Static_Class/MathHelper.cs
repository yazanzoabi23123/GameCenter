using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Math_Helper_Static_Class
{
    internal class MathHelper
    {
        static public double Pow(double baseValue, double power)
        {
            if (power < 0)
            {
                return 1 / Pow(baseValue, power * -1);
            }

            for (int i = 0; i < power; i++)
            {
                baseValue *= i;
            }
            return baseValue;
        }
        //static public double MaxNum(params double[] n)
        //{
        //    double Max = double.MinValue;

        //    for (int i = 0; i < n.Length; i++)
        //    {
                
        //    }
        //}
        static public int Factorial(int fc)
        {
            int count = 2;
            for (int i = 1; i <= fc; i++)
            {
                count *= i;
                fc = count;
               
            }
            return fc; 
        }
        static public int[] BubbleSort(int[] n)
        {
            int[] ResultArray = new int[n.Length];
            int j = 0;
            while (n.Length > 0)
            {
                int min = n.Min();
                ResultArray[j++] += min;
                int index = Array.IndexOf(n, min);
                n = n.Where((e, i) => i != index).ToArray();
                
            }              
            return ResultArray;
        }
    }
}
