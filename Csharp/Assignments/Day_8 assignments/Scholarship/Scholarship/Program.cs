using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student's marks (0-100):");
            int marks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter total fees:");
            double fees = Convert.ToDouble(Console.ReadLine());
            Scholarship scholarshipCalculator = new Scholarship();
            double scholarshipAmount = scholarshipCalculator.Merit(marks, fees);
            Console.WriteLine($"Scholarship amount for marks {marks} is: {scholarshipAmount}");
            Console.ReadKey();
        }
    }
    public class Scholarship
    {
        public double Merit(int marks, double fees)
        {
            double scholarshipAmount = 0;
            if (marks >= 70 && marks <= 80)
            {
                scholarshipAmount = 0.2 * fees;
            }
            else if (marks > 80 && marks <= 90)
            {
                scholarshipAmount = 0.3 * fees; 
            }
            else if (marks > 90)
            {
                scholarshipAmount = 0.5 * fees; 
            }
            return scholarshipAmount;
        }
    }
}
