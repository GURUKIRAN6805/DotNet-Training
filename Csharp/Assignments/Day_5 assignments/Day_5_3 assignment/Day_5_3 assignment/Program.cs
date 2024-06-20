using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_3_assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the integer values :");
            string input = Console.ReadLine();
            string[] inputs = input.Split(' ');
            int[] numbers = new int[inputs.Length];

            for (int i = 0; i < inputs.Length; i++)
            {
                numbers[i] = int.Parse(inputs[i]);
            }
            double average = CalculateAverage(numbers);
            Console.WriteLine($"Average value of array elements: {average}");
            int min = FindMinimum(numbers);
            int max = FindMaximum(numbers);
            Console.WriteLine($"Minimum value in the array: {min}");
            Console.WriteLine($"Maximum value in the array: {max}");
            Console.ReadKey();
        }
        static double CalculateAverage(int[] arr)
        {
            int sum = 0;

            foreach (int num in arr)
            {
                sum += num;
            }
            return (double)sum / arr.Length;
        }
        static int FindMinimum(int[] arr)
        {
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        static int FindMaximum(int[] arr)
        {
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }

}
