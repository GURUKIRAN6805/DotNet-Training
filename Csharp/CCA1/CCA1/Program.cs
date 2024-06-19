using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCA1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();
            int position;
            bool validInput = false;
            do
            {
                Console.Write($"Enter the position to remove (0 to {inputString.Length - 1}): ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out position) && position >= 0 && position < inputString.Length)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid position. Please enter a valid position.");
                    Console.ReadLine();
                }
            } while (!validInput);
            string result = RemoveCharacterAtPosition(inputString, position);
            Console.WriteLine("Resulting string: " + result);
            Console.ReadLine();
            }
        static string RemoveCharacterAtPosition(string s, int pos)
        {
            return s.Substring(0, pos) + s.Substring(pos + 1);
            }
        }

    }


