using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCA2
{
    public abstract class Student
    {
        public string Name { get; set; }
        public int StudentID { get; set; }
        public double Grade { get; set; }
        public abstract bool IsPassed(double grade);
    }
    public class Undergraduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 70.0;
        }
    }
    public class Graduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 80.0;
        }
    }
    class Program
    {
        static void Main()
        {
            Undergraduate undergradStudent = new Undergraduate
            {
                Name = "GURUKIRAN",
                StudentID = 6805,
                Grade = 92.3
            };
            Console.WriteLine($"Undergraduate Student: {undergradStudent.Name}, ID: {undergradStudent.StudentID}");
            Console.WriteLine($"Grade: {undergradStudent.Grade}, Passed: {undergradStudent.IsPassed(undergradStudent.Grade)}");
            Console.WriteLine();
            Graduate gradStudent = new Graduate
            {
                Name = "SKY",
                StudentID = 9531,
                Grade = 91.7 
            };
            Console.WriteLine($"Graduate Student: {gradStudent.Name}, ID: {gradStudent.StudentID}");
            Console.WriteLine($"Grade: {gradStudent.Grade}, Passed: {gradStudent.IsPassed(gradStudent.Grade)}");
            Console.ReadLine();
        }
    }
}

