using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_class_with_Empid
{
    public class Employee
    {
        protected int empId;
        protected string empName;
        protected float salary;
        public Employee(int empId, string empName, float salary)
        {
            this.empId = empId;
            this.empName = empName;
            this.salary = salary;
        }
        public void Display()
        {
            Console.WriteLine($"Employee ID: {empId}");
            Console.WriteLine($"Employee Name: {empName}");
            Console.WriteLine($"Salary: {salary}");
            Console.ReadLine();
        }
    }
    public class PartTimeEmployee : Employee
    {
        private float wages;
        public PartTimeEmployee(int empId, string empName, float salary, float wages)
            : base(empId, empName, salary)
        {
            this.wages = wages;
        }
        public new void Display()
        {
            base.Display();
            Console.WriteLine($"Wages: {wages}");
        }
    }
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter details for Employee:");
            Console.Write("Employee ID: ");
            int empId = int.Parse(Console.ReadLine());
            Console.Write("Employee Name: ");
            string empName = Console.ReadLine();
            Console.Write("Salary: ");
            float salary = float.Parse(Console.ReadLine());

            Employee emp = new Employee(empId, empName, salary);

            Console.WriteLine("\nEnter details for Part-Time Employee:");
            Console.Write("Employee ID: ");
            int partTimeEmpId = int.Parse(Console.ReadLine());
            Console.Write("Employee Name: ");
            string partTimeEmpName = Console.ReadLine();
            Console.Write("Salary: ");
            float partTimeSalary = float.Parse(Console.ReadLine());
            Console.Write("Wages: ");
            float wages = float.Parse(Console.ReadLine());

            PartTimeEmployee partTimeEmp = new PartTimeEmployee(partTimeEmpId, partTimeEmpName, partTimeSalary, wages);

            Console.WriteLine("\nEmployee details:");
            emp.Display();
            Console.WriteLine("\nPart-Time Employee details:");
            partTimeEmp.Display();
        }
    }
}

