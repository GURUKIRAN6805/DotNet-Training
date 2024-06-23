using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_called_student_which_has_data_members
{
    internal class Student
    {
        private int rollNo;
        private string name;
        private string className;
        private int semester;
        private string branch;
        private int[] marks = new int[5];
        public Student(int rollNo, string name, string className, int semester, string branch)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.className = className;
            this.semester = semester;
            this.branch = branch;
        }
        public void GetMarks()
        {
            Console.WriteLine($"Enter marks for student {name} (Roll No: {rollNo}):");

            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write($"Enter marks for Subject {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void DisplayResult()
        {
            double averageMarks = CalculateAverageMarks();
            bool allSubjectsPassed = true;

            foreach (var mark in marks)
            {
                if (mark < 35)
                {
                    allSubjectsPassed = false;
                    break;
                }
            }
            if (!allSubjectsPassed || averageMarks < 50)
            {
                Console.WriteLine("Result: Failed");
            }
            else
            {
                Console.WriteLine("Result: Passed");
            }
        }
        private double CalculateAverageMarks()
        {
            int sum = 0;
            foreach (var mark in marks)
            {
                sum += mark;
            }
            return (double)sum / marks.Length;
        }
        public void DisplayData()
        {
            Console.WriteLine($"Student Details:");
            Console.WriteLine($"Roll No: {rollNo}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Class: {className}");
            Console.WriteLine($"Semester: {semester}");
            Console.WriteLine($"Branch: {branch}");
            Console.WriteLine("Marks:");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"Subject {i + 1}: {marks[i]}");
                Console.ReadLine();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student details:");
            Console.Write("Roll No: ");
            int rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Class: ");
            string className = Console.ReadLine();
            Console.Write("Semester: ");
            int semester = Convert.ToInt32(Console.ReadLine());
            Console.Write("Branch: ");
            string branch = Console.ReadLine();
            Student student = new Student(rollNo, name, className, semester, branch);
            student.GetMarks();
            student.DisplayResult();
            student.DisplayData();
            Console.ReadLine();
        }
    }
}
