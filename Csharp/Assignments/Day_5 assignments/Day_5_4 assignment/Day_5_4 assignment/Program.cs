using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_4_assignment
{
    class program
    {
        static void Main()
        {
            int[] marks = new int[10];
            Console.WriteLine("Enter ten integer marks:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter mark {i + 1}: ");
                marks[i] = int.Parse(Console.ReadLine());
            }
            int total = 0;
            foreach (int mark in marks)
            {
                total += mark;
            }
            double average = (double)total / marks.Length;

            int min = marks[0];
            int max = marks[0];
            foreach (int mark in marks)
            {
                if (mark < min)
                    min = mark;
                if (mark > max)
                    max = mark;
            }

            Console.WriteLine($"\nTotal marks: {total}");
            Console.WriteLine($"Average marks: {average:F2}");
            Console.WriteLine($"Minimum mark: {min}");
            Console.WriteLine($"Maximum mark: {max}");

            Array.Sort(marks);
            Console.WriteLine("\nMarks in ascending order:");
            foreach (int mark in marks)
            {
                Console.Write($"{mark} ");
            }
            Console.WriteLine();
            Array.Reverse(marks);
            Console.WriteLine("\nMarks in descending order:");
            foreach (int mark in marks)
            {
                Console.Write($"{mark} ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

