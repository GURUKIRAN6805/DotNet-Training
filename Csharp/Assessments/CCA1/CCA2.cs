using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCA1
{
    class CCA2
    {
        static void Main()
        {
            string str1 = "abcd";
            string str2 = "a";
            string str3 = "xy";
            string result1 = ExchangeFirstAndLast(str1);
            string result2 = ExchangeFirstAndLast(str2);
            string result3 = ExchangeFirstAndLast(str3);
            Console.WriteLine(result1);
            Console.ReadLine();
            Console.WriteLine(result2); 
            Console.ReadLine();
            Console.WriteLine(result3); 
            Console.ReadLine();
        }
        static string ExchangeFirstAndLast(string s)
        {
            if (s.Length < 2)
            {
                return s; 
            }

            char firstChar = s[0];
            char lastChar = s[s.Length - 1];
            return lastChar + s.Substring(1, s.Length - 2) + firstChar;
        }
    }

}

