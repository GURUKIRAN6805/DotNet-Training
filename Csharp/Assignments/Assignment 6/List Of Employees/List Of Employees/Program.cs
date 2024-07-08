using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Of_Employees
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpCity { get; set; }
        public decimal EmpSalary { get; set; }
    }
    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>();
            Console.Write("Enter number of employees: ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Employee emp = new Employee();
                Console.WriteLine($"\nEnter details for Employee {i + 1}:");
                Console.Write("EmpId: ");
                emp.EmpId = int.Parse(Console.ReadLine());
                Console.Write("EmpName: ");
                emp.EmpName = Console.ReadLine();
                Console.Write("EmpCity: ");
                emp.EmpCity = Console.ReadLine();
                Console.Write("EmpSalary: ");
                emp.EmpSalary = decimal.Parse(Console.ReadLine());
                employees.Add(emp);
            }
            Console.WriteLine("\nAll Employees:");
            DisplayEmployees(employees);
            Console.WriteLine("\nEmployees with salary greater than 45000:");
            DisplayEmployees(employees.Where(e => e.EmpSalary > 45000).ToList());
            Console.WriteLine("\nEmployees from Bangalore:");
            DisplayEmployees(employees.Where(e => e.EmpCity.Equals("Bangalore", StringComparison.OrdinalIgnoreCase)).ToList());
            Console.WriteLine("\nEmployees sorted by name (ascending):");
            DisplayEmployees(employees.OrderBy(e => e.EmpName).ToList());
            Console.ReadLine();
        }
        static void DisplayEmployees(List<Employee> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"EmpId: {emp.EmpId}, EmpName: {emp.EmpName}, EmpCity: {emp.EmpCity}, EmpSalary: {emp.EmpSalary}");
                Console.ReadLine();
            }
        }
    }
}

