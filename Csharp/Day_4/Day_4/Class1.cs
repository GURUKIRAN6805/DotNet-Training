using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
     class Polymorphism
    {
        public int Add(int x, int y)
        {

        return x + y;
        }

        public float Add(int a, int b, int c)
        {

        return a + b + c; 
        }

        public static void Main()
        {
            Polymorphism pol = new Polymorphism();
            Console.WriteLine(Poly.Add(5, 5)); //goto line no.12
            Console.WriteLine(Polymorphism.Add(5,5,5)); //goto line no.17
        }
    
    }

    public static void swap (int number1, int number2)
    {
        number1 = number1 1
    }

}
