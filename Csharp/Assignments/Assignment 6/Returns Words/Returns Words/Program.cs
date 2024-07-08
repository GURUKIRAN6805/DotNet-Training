using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Returns_Words
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a words:");
            string input = Console.ReadLine();
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var result = words
                .Where(word => word.StartsWith("a", StringComparison.OrdinalIgnoreCase) && word.EndsWith("m", StringComparison.OrdinalIgnoreCase))
                .ToList();
            Console.WriteLine("Words starting with 'a' and ending with 'm':");
            foreach (var word in result)
            {
                Console.WriteLine(word);
                Console.ReadLine();
            }
        }
    }

}
