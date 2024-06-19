using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Day_4;

namespace Day_4
{
    class Program 
    {
        static int data1; //private static
        string str; //private non-static
        public float fvar;//public non-static
        public static string s;//public and static
        internal int i; //internal member
        internal static double d; //static internal member
        protected indexer pt;
        internal protected int ip;
        public static void Main()
        {
            Program p = new Program();
            Console.WriteLine(data1 + " " + p.str +" " + p.fvar + " " + s);
            Console.WriteLine();
            Console.Read();

        }
    }

    class Driver //independent class
    {
        public static void accessprogram()
        {
            Program prg = new Program();
            //prg. we cannot access the private memebers of other clas, no visibility
            prg.fvar = 25.55f; //public memebers of one class are accessible in others usimg the object
            Program.s = "Hello"; //public memebers of one class are accessible in others usimg the object
            prg.i = 46; //non- static internal member accessed in another class of the same class
            Program.d = 55.55;////non- static internal member accessed in another class of the same class
            prg.ip = 89;

        }
    }

    class programChild : Program // child/deried/sub class of the program class
    {
        Program.d = 5.5;
            Program.s = "child";
            Program p1 = new Program();
        p1.fvar = 34.5f;
            p1.i = 10;
            p1.ip = 8;//internal protected beimg accessed either with the parent object or with 
            ProgramChild pc = new ProgramChild();
            pc.pt = 7;
            pc.ip = 6;


    }
}

