using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class program
    {
        static void main(string[] args)
        {

            //StringOps();
          
            Console.ReadKey();
        }

        public static void StringOps()
        {
            string s = "Hello";
            Console.WriteLine("s for the First Time is {0}", s.GetHashCode());

            s = "Hello World";
            Console.WriteLine("s after change of value is {0}", s.GetHashCode());

            string s1 = "CSharp";
            Console.WriteLine(" S1 new value from the pool {0}", s1.GetHashCode());

            string s2 = s1;
            Console.WriteLine("S2 sharing the same reference as that of s1 {0}", s2.GetHashCode());

            string s3 = "Hello";
            Console.WriteLine("S3 existing value from the pool {0}", s3.GetHashCode());

            Console.WriteLine("------String Builder-----");
            StringBuilder sb = new StringBuilder("Hello");
            Console.WriteLine("Sb's hash code :{0}", sb.GetHashCode());
            sb.Append("World");
            Console.WriteLine("Sb's hash code :{0}", sb.GetHashCode());
            Console.WriteLine(sb);
            Console.WriteLine(sb.Capacity);

        }

    

    public static void Struct_vs_Class()
    {
        Student s1; //or
                    // Student s1 = new Student();

        s1.marks1 = 50;
        s1.marks2 = 60;
        Console.WriteLine(s1.marks1 + s1.marks2);

        //Student s2 = new Student();
        Student s2;
            // s2 = s1;
            s2 = s1;
          
        Console.WriteLine(s2.marks1 + s2.marks2);

            // let us change the value of any one student variable

            s1.marks1 = 80;
            s2.marks2 = 80;

    }
}
    class Student
    {
        //public fields
        public int marks1;
        public int marks2;
        //public string name;
    }

}
