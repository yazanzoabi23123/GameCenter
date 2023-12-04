//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LINQ
//{
//    internal class StringExtensions
//    {
//        public static bool IsPalindrome(this string s)
//        {

//            //return s.Reverse() == s; 

//            for (int i = 0; i < s.Length / 2; i++)
//            {
//                if (s[i] != s[s.Length - i - 1])
//                {
//                    return false;
//                }
//            }
//            return true;

//        }
//           public static string ToCamelCase(this string s)
//           {
//             StringBuilder sb = new StringBuilder();
//            for (int i = 0;i <=s.Length ; i++) 
//            {
//                if (s[i] == ' ')
//                {
//                    s.Remove(i); 
//                }
//                else
//                {

//                }
//            }
//           }


//            public static string Encrypt(this string s, int n = 3)
//            {
//                StringBuilder sb = new StringBuilder();

//                foreach (char c in s)
//                {
//                    if (char.ToLower(c) >= 'a' && char.ToLower(c) <= 'z')
//                    {
//                        if (char.ToLower(c) <= 'z' - n) // w x y z 
//                        {
//                            sb.Append((char)(c + n));
//                        }
//                        else
//                        {
//                            char c2 = (char)(char.IsUpper(c) ? ('A' + (c - 'Z')) : ('a' + (c - 'z')));
//                            c2 =(char) (c2 + n-1);
//                            sb.Append(c2);
//                        }
//                    }
//                    else
//                    {
//                        sb.Append(c);
//                    }

//                }
//                return sb.ToString();

//           }
        
//    }
//}
