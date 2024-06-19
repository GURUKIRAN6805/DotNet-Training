using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_assignment_a_given_number_is_positive_or_negative
{
    internal class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter a number:");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    if (number > 0)
                    {
                        Console.WriteLine("The number is positive.");
                        Console.ReadLine();
                    }
                    else if (number < 0)
                    {
                        Console.WriteLine("The number is negative.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("The number is zero.");
                        Console.ReadLine();
                }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer number.");
                    Console.ReadLine();
            }
            }
        

    }
}
