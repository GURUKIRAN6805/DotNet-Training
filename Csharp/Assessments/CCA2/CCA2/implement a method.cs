using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCA2
{
    class implement_a_method
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int number = ReadAndValidateNumber();
            if (number != int.MinValue)
            {
                Console.WriteLine($"The number {number} is valid.");
            }
            Console.ReadLine();
        }
        static int ReadAndValidateNumber()
        {
            int number;
            try
            {
                number = int.Parse(Console.ReadLine());
                CheckNumber(number);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Exception caught: {ex.Message}");
                number = int.MinValue;
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Invalid input format: {ex.Message}");
                number = int.MinValue;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error occurred: {ex.Message}");
                number = int.MinValue;
            }
            return number;
        }
        static void CheckNumber(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Number cannot be negative.");
            }
        }
    }
}

