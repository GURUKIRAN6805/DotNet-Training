using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractices
{
    class Program
    {
        static void Main()
        {
            Distance d1 = new Distance(10);
            Distance d2 = +d1; // Unary plus operator
            Distance d3 = -d1; // Unary minus operator
            Console.WriteLine("Original Distance: " + d1);
            Console.WriteLine("Unary Plus Distance: " + d2);
            Console.WriteLine("Unary Minus Distance: " + d3);
            Console.ReadLine();
        }
    }
    public class Distance
    {
        private int dist1;
        public Distance(int distance)
        {
            this.dist1 = distance;
        }
        public static Distance operator +(Distance dis)
        {
            Distance temp = new Distance(dis.dist1);
            return temp;
        }
        public static Distance operator -(Distance dis)
        {
            Distance temp = new Distance(-dis.dist1);
            return temp;
        }
        public override string ToString()
        {
            return dist1.ToString();
        }
    }
}