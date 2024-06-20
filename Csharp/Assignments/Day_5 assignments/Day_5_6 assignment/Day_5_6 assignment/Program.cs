using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_6_assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a word:");
            string inputWord = Console.ReadLine();
            int length = inputWord.Length;
            Console.WriteLine($"Length of the word '{inputWord}' is: {length}");
            Console.ReadKey();
        }
    }
}