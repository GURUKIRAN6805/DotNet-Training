using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_5_assignment
{
    class Program
    {
        static void Main()
        {
            int[] originalArray = { 6, 5, 8, 0, 6 };
            int[] newArray = new int[originalArray.Length];
            for (int i = 0; i < originalArray.Length; i++)
            {
                Swap(originalArray, newArray, i);
            }
            Console.WriteLine("Original Array:");
            PrintArray(originalArray);
            Console.WriteLine("\nCopied Array:");
            PrintArray(newArray);
            Console.ReadKey();
        }
        static void Swap(int[] source, int[] destination, int index)
        {
            destination[index] = source[index];
        }
        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}

