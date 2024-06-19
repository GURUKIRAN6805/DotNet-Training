using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    internal class Class1
    {
        public void checkGrade()
            {
            char grade;
            Console.Write("enter your grade:");
            grade = Convert.ToChar(Console.ReadLine());
            if (grade == 'O' || grade == 'o')
                Console.WriteLine("Outstanding");
            else if (grade == 'A' || grade == 'a')
                Console.WriteLine("Excellent");
            else if (grade == 'B' || grade == 'b')
                Console.WriteLine("Very Good");
            else if (grade == 'C' || grade == 'c')
                Console.WriteLine("Can improve");
            else
                Console.WriteLine("Invalid Grade");
 
        }
    }
}
