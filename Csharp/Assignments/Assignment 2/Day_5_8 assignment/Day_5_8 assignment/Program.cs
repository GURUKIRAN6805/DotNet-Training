using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_8_assignment
{
    class Program
    {
        static void Main()
        {
            {
                Console.WriteLine("Enter the first word:");
                string word1 = Console.ReadLine();
                Console.WriteLine("Enter the second word:");
                string word2 = Console.ReadLine();
                bool areSame = AreWordsSame(word1, word2);
                if (areSame )
                {
                    Console.WriteLine($"The words '{word1}' and '{word2}' are the same.");
                }
                else
                {
                    Console.WriteLine($"The words '{word1}' and '{word2}' are different.");
                }
                Console.ReadKey();
            }
             bool AreWordsSame(string word1, string word2)
            {
                return word1.Equals(word2);
            }
        }

    }
}
