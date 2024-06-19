using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_4_assignment
{
    internal class Program
    {
        static void Main()
        {
                int num1, num2, temp;
                Console.Write("Enter the first number: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter the second number: ");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nBefore swapping: num1 = {num1}, num2 = {num2}");

                temp = num1;
                num1 = num2;
                num2 = temp;

                Console.WriteLine($"After swapping: num1 = {num1}, num2 = {num2}");
                Console.ReadLine();
        }

    }
}

