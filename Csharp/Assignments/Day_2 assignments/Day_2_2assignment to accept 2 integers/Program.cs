using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_assignment_to_accept_2_integers
{
    internal class Program
    {
        static void Main()
        {
                Console.WriteLine("Enter the first integer:");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second integer:");
                int num2 = int.Parse(Console.ReadLine());

                if (num1 == num2)
                {
                    Console.WriteLine("The numbers are equal.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("The numbers are not equal.");
                    Console.ReadLine();
                }
            
        }
    }
    
}
