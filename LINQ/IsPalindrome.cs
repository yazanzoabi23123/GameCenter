//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LINQ
//{
//    internal class IsPalindrome
//    {

//    }
//    public static string Encrypt(this string s, int n = 3)
//    {
//        StringBuilder sb = new StringBuilder();
//        foreach (char c in s)
//        {
//            if (char.ToLower(c) >= 'a' && char.ToLower(c) <= 'z')
//            {
//                if (char.ToLower(c) <= 'z' - n) // w x y z 
//                {
//                    sb.Append((char)(c + n));
//                }
//                else
//                {
//                    char c2 = (char)(char.IsUpper(c) ? ('A' + (c - 'Z') + n) : ('a' + (c - 'z') + n));
//                    sb.Append(c2);
//                }
//            }
//            else
//            {
//                sb.Append(c);
//            }
//        }
//        return sb.ToString();
//    }
//}
