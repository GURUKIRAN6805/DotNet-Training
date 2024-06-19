using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    class Distance
    {
        public int dist1;
        
        public Distance(int d)
        {
            dist1 = d;

        }

        
        public static Distance operator + (Distance  dist1, Distance dist2)
        {
            Distance temp = new Distance(1);
            temp.dist1 = dist1.dist1 + dist2.dist1;
           // temp.myvariable = 25;
            return temp;
        }

        public static Distance operator ++(Distance d)
        {
            Distance dtemp = new Distance(d.dist1);
            dtemp.dist1 = d.dist1 + 1;
            return dtemp;
        }
    }
    class OperatorOverloading
    {
        static void Main()
        {
            Distance d1 = new Distance(10);
            Distance d2 = new Distance(50);
            d1.dist1 = 50;
            d2.dist1 = 80;
            Distance totaldistance = d1 + d2;

            Console.WriteLine("The overall Distance is {0} ans Myvar is {1}", totaldistance.dist1);
            d1++;
            totaldistance.dist1 = d1.dist1;
            Console.WriteLine(d1.dist1 + " " + totaldistance.dist1);
            Console.Read();
        }
    }
}
