using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box_that_has_Length_and_breadth
{
    public class Box
    {
        private double length;
        private double breadth;
        public Box(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public static Box AddBoxes(Box box1, Box box2)
        {
            double newLength = box1.length + box2.length;
            double newBreadth = box1.breadth + box2.breadth;
            return new Box(newLength, newBreadth);
        }
        public void Display()
        {
            Console.WriteLine($"Box dimensions - Length: {length}, Breadth: {breadth}");
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter dimensions for Box 1:");
            Console.Write("Length: ");
            double length1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Breadth: ");
            double breadth1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter dimensions for Box 2:");
            Console.Write("Length: ");
            double length2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Breadth: ");
            double breadth2 = Convert.ToDouble(Console.ReadLine());
            Box box1 = new Box(length1, breadth1);
            Box box2 = new Box(length2, breadth2);
            Box box3 = Box.AddBoxes(box1, box2);
            Console.WriteLine("\nBox 1:");
            box1.Display();
            Console.WriteLine("\nBox 2:");
            box2.Display();
            Console.WriteLine("\nBox 3 (Sum of Box 1 and Box 2):");
            box3.Display();
            Console.ReadLine();
        }
    }
}