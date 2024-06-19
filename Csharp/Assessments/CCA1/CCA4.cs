using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCA1
{
    class CCA4
    {
        static void Main()
        {
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Multiplication table of {number}:");
            for (int i = 0; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }
            Console.ReadLine(); 
        }
    }
}


