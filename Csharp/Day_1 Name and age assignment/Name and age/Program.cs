using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_and_age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age:");
                string ageInput = Console.ReadLine();
                if (int.TryParse(ageInput, out int age))
                {
                    Console.WriteLine($"Your name is {name} and you are {age} years old.");
                }
                else
                {
                    Console.WriteLine("Invalid age input. Please enter a valid number.");
                }
            

            Console.Read();
        }
    }
}
