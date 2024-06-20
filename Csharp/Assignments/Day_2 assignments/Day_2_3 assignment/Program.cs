using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_3_assignment
{
public class Program
        {
            public static void Main()
            {
                int num1, num2, sum, product, difference;

                
                Console.Write("Enter the first number: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the second number: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                int division = CalculatorFunc(num1, num2, out sum, out product, out difference);

                Console.WriteLine("Sum: " + sum);
                Console.WriteLine("Product: " + product);
                Console.WriteLine("Difference: " + difference);
                Console.WriteLine("Division: " + division);
                Console.ReadLine();
            }
            public static int CalculatorFunc(int a, int b, out int sum, out int product, out int difference)
            {
                sum = a + b;
                product = a * b;
                difference = a - b;
                return a / b;
            }
        }

    
}

