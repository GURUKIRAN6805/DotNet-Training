using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_5_assignment
{
    internal class Program
    {
        static void Main()
        {
                Console.Write("Enter a digit: ");
                int number = int.Parse(Console.ReadLine());


                Console.WriteLine("{0} {0} {0} {0}", number);
                Console.ReadLine();
                Console.WriteLine("{0}{0}{0}{0}", number);
                Console.ReadLine() ;
                Console.WriteLine("{0} {0} {0} {0}", number);
                Console.ReadLine() ;
                Console.WriteLine("{0}{0}{0}{0}", number);
                Console.ReadLine();
            
        }

    }
}

