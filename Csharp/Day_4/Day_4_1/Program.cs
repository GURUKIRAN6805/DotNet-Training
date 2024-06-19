using System;
using Day_4_1;

namespace Day_4_1
{
     class callingProgram :program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.fvar = 500.55; // public of the other class, accessed using an object of class
            program.s = "hh"; // static public member of the other clas accessed usimg the classname
            //cannot access any internal memebers of the assembly

            callingProgram cp = new 
        }
    }
}
