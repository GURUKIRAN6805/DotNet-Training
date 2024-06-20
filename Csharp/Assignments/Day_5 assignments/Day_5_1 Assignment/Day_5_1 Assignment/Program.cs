using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_1_Assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the first integer:");
            string input1 = Console.ReadLine();
            int a = int.Parse(input1);
            Console.WriteLine("Enter the second integer:");
            string input2 = Console.ReadLine();
            int b = int.Parse(input2);
            int result = SumOrTripleSum(a, b);
            Console.WriteLine($"Result: {result}");
            Console.ReadLine();
        }
        static int SumOrTripleSum(int x, int y)
        {
            int sum = x + y;
            if (x == y)
            {
                sum *= 3;
            }
            return sum;
        }
    }

}
