using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_no.of_occurrences_of_a_letter
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();
            Console.WriteLine("Enter the letter to count:");
            char letter = char.Parse(Console.ReadLine());
            int count = 0;

            foreach (char c in inputString)
            {
                if (c == letter)
                {
                    count++;
                }
            }
            Console.WriteLine($"Number of occurrences of '{letter}' in the string: {count}");
            Console.ReadLine();
        }
    }

}
