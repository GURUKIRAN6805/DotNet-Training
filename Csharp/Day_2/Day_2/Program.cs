using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
     class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine("x before calling function",x);
            CallByValue(x); //calling a function
            Console.WriteLine("x is {0}",x);
            Console.WriteLine("++++++++");

            Program program = new Program();
            Console.WriteLine("x before calling function", x);
            program.CallByRef(ref x);

            Console.WriteLine("x before calling function", x);
            Console.WriteLine("-----out parameter----");
            int total; prod; diff; div = 0;
            div = CalculatorFunc(15, 10, out total, out prod, out diff);
            Console.WriteLine($"Sum is {total}, product is {prod}, Difference is {diff}");
            Console.Read();
        }
        public static void CallByValue(int j) //called function
        {
            Console.WriteLine("j is {0}", j);
            j = 100;
            Console.WriteLine("j is {0}", j);
        }

        public void CallByRef(ref int j)
        {
            Console.WriteLine("j is {0}", j);
            j = 100;
            Console.WriteLine("j is {0}", j);
        }

        public static int CalculatorFunc(int a, int b, int sum, out int product, out int difference)
        {
            sum = a + b;
            product = a * b;
            difference = a - b;
            return a / b;
        }
    }
}
