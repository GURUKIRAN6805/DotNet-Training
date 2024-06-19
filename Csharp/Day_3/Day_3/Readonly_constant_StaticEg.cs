using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
     class Readonly_constant_StaticEg
    {
        //reaonly variables declaration
        public readonly int myvar1 = 10; //assigning value to a readonly at the time of decl.
        public readonly string mydata;
        const float PI = 3.14f; //constant member
        int x; //non static member
        static int y = 200; //static member
        
        public Readonly_constant_StaticEg()
        {
            Console.WriteLine(myvar1);
            myvar1 = 20;
            mydata = "Readonly Variable";
            Console.WriteLine("Value of Myvar is {0}, and mydata is :{1}", myvar1, mydata);
        }

        public static void Main()
        {
            Readonly_constant_StaticEg rcs = new Readonly_constant_StaticEg();
            Console.WriteLine(rcs.myvar1 + "  " + rcs.mydata);
            Readonly_constant_StaticEg rcs2 = new Readonly_constant_StaticEg();
            Console.WriteLine(rcs2.mydata + "  " + rcs2.myvar1);
            Console.WriteLine(PI);
            rcs.x = 10;
            rcs.x = 100;
            Console.WriteLine($"X is {rcs.x}, Y is {y}, Myvar1 is {rcs.myvar1}, and Constant is {PI}");
            y = 300;
            Console.WriteLine($"X is {rcs.x}, Y is {y}, Myvar1 is {rcs.myvar1}, and Constant is {PI}");
           
            Console.Read();
        }
    }
}
