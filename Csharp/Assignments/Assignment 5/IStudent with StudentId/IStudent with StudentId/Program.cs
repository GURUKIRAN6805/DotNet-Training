using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IStudent_with_StudentId
{
    public interface IStudent
    {
        int StudentId { get; set; }
        string Name { get; set; }
        void ShowDetails();
    }
    public class Dayscholar : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public void ShowDetails()
        {
            Console.WriteLine($"Dayscholar Details:");
            Console.WriteLine($"Student ID: {StudentId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine("Type: Dayscholar");
            Console.ReadLine();
        }
    }
    public class Resident : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public void ShowDetails()
        {
            Console.WriteLine($"Resident Details:");
            Console.WriteLine($"Student ID: {StudentId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine("Type: Resident");
            Console.ReadLine();
        }
    }
    public class Program
    {
        public static void Main()
        {
            Dayscholar dayscholar = new Dayscholar();
            Console.WriteLine("Enter Dayscholar details:");
            Console.Write("Student ID: ");
            if (int.TryParse(Console.ReadLine(), out int dayscholarId))
            {
                dayscholar.StudentId = dayscholarId;
            }
            else
            {
                Console.WriteLine("Invalid input for Student ID. Defaulting to 0.");
            }

            Console.Write("Name: ");
            dayscholar.Name = Console.ReadLine();
            Resident resident = new Resident();
            Console.WriteLine("\nEnter Resident details:");
            Console.Write("Student ID: ");
            if (int.TryParse(Console.ReadLine(), out int residentId))
            {
                resident.StudentId = residentId;
            }
            else
            {
                Console.WriteLine("Invalid input for Student ID. Defaulting to 0.");
                Console.ReadLine();
            }

            Console.Write("Name: ");
            resident.Name = Console.ReadLine();
            Console.WriteLine("\nDisplaying Dayscholar details:");
            dayscholar.ShowDetails();
            Console.WriteLine("\nDisplaying Resident details:");
            resident.ShowDetails();
            Console.ReadLine();
        }
    }
}
