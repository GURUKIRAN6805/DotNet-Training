using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCA4
{
    public delegate int CalculatorOperation(int a, int b);
    class Calculator_Functionalities
    {
        static void Main()
        {
            int num1, num2;
            while (true)
            {
                Console.WriteLine("Enter first number:");
                if (int.TryParse(Console.ReadLine(), out num1))
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            while (true)
            {
                Console.WriteLine("Enter second number:");
                if (int.TryParse(Console.ReadLine(), out num2))
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            CalculatorOperation add = (a, b) => a + b;
            CalculatorOperation subtract = (a, b) => a - b;
            CalculatorOperation multiply = (a, b) => a * b;
            Console.WriteLine($"Result of addition: {num1} + {num2} = {add(num1, num2)}");
            Console.WriteLine($"Result of subtraction: {num1} - {num2} = {subtract(num1, num2)}");
            Console.WriteLine($"Result of multiplication: {num1} * {num2} = {multiply(num1, num2)}");
            Console.ReadLine();
        }
    }

}
