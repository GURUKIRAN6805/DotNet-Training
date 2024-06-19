using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCA1
{
    class CCA3
    {
        static void Main()
        {
            Console.WriteLine("Enter three integers separated by commas:");
            string input = Console.ReadLine();
            string[] numbersStr = input.Split(',');
            int num1 = int.Parse(numbersStr[0]);
            int num2 = int.Parse(numbersStr[1]);
            int num3 = int.Parse(numbersStr[2]);
            int max = num1;
            if (num2 > max)
            {
                max = num2;
            }
            if (num3 > max)
            {
                max = num3;
            }
            Console.WriteLine($"The largest number is: {max}");
            Console.ReadLine();
        }
    }
}

