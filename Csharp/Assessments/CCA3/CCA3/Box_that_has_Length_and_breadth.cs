using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCA3
{
    class Box_that_has_Length_and_breadth
    {
        public float Length { get; set; }
        public float Breadth { get; set; }
        public Box_that_has_Length_and_breadth(float length, float breadth)
        {
            Length = length;
            Breadth = breadth;
        }
        public static Box_that_has_Length_and_breadth AddBoxes(Box_that_has_Length_and_breadth box1, Box_that_has_Length_and_breadth box2)
        {
            float sumLength = box1.Length + box2.Length;
            float sumBreadth = box1.Breadth + box2.Breadth;
            return new Box_that_has_Length_and_breadth(sumLength, sumBreadth);
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Length: {Length}");
            Console.WriteLine($"Breadth: {Breadth}");
        }
    }
    class Box
    {
        static void Main()
        {
            Console.Write("Enter length of Box 1: ");
            float length1 = float.Parse(Console.ReadLine());
            Console.Write("Enter breadth of Box 1: ");
            float breadth1 = float.Parse(Console.ReadLine());

            Console.Write("\nEnter length of Box 2: ");
            float length2 = float.Parse(Console.ReadLine());
            Console.Write("Enter breadth of Box 2: ");
            float breadth2 = float.Parse(Console.ReadLine());

            Box_that_has_Length_and_breadth box1 = new Box_that_has_Length_and_breadth(length1, breadth1);
            Box_that_has_Length_and_breadth box2 = new Box_that_has_Length_and_breadth(length2, breadth2);

            Box_that_has_Length_and_breadth box3 = Box_that_has_Length_and_breadth.AddBoxes(box1, box2);

            Console.WriteLine("\nDetails of Box 3 (Result of Addition):");
            box3.DisplayDetails();
            Console.ReadLine();
        }
    }
}
