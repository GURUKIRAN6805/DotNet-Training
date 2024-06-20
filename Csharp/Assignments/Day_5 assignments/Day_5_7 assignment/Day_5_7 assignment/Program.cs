using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_7_assignment
{
    class Program
    {
        static void Main()
        {
            {
                Console.WriteLine("Enter a word:");
                string inputWord = Console.ReadLine();
                string reversedWord = ReverseString(inputWord);
                Console.WriteLine($"Reverse of '{inputWord}' is: {reversedWord}");
                Console.ReadKey();
            }
             string ReverseString(string str)
            {
                string reversed = "";
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    reversed += str[i];
                }
                return reversed;
            }
        }

    }
}
