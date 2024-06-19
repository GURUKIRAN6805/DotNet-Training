using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_1
{
    class A1
    {
        public int i = 0;

       

        public void Method1(string s)
        {
            Console.WriteLine("Message from A1 {0}",s);
        }
    }

    class B1 : A1
    {
        n int i; //name hiding
         public B1(int a, int b)
        {
            base.i = a;
            i = b;
        }
        //method hiding
        public new void Method1(string str)
        {
            Console.WriteLine("Message from B1" + " "+ str);
        }

        public void Show()
        {
            Console.WriteLine("i im A1 class : "+base.i);
            Console.WriteLine("i in B1 class : "

        }
    }

    class Name_Method_Hiding
    {
        public static void 
    }
}
