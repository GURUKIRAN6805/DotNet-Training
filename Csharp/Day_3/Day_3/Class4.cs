using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
     class Employee
    {
        //fields
        int Empid;
        string EmpName;
        DateTime DOJ;
        float Salary;

        //1. constructor
       public Employee()
        {
            Empid = 10;
            EmpName = " Infinite Ltd.";
            DOJ = Convert.ToDateTime("2/2/2024");
            Salary = 50000;
        }

        //methods/functions

        public void GetEmployeeDetails()
        {
            Console.WriteLine("Enter id, name, doj and sal :");
            Empid = Convert.ToInt32(Console.ReadLine());    
            EmpName = Console.ReadLine();
            DOJ= Convert.ToDateTime(Console.ReadLine());
            Salary = Convert.ToSingle(Console.ReadLine());
        }

        public void ShowEmpDetails()
        {
            Console.WriteLine($"Employee id{Empid}, Employee Name{EmpName}, DOJ{DOJ}, and Salary");
        }
         
        }

    class EmployeeTest
    {
        public static void main()
        {
            Employee employee = new Employee();
            employee.GetEmployeeDetails();
            employee.ShowEmpDetails();
            Console.WriteLine("--------");
            Employee employee2 = new Employee();
            employee2.GetEmployeeDetails();
            employee2.ShowEmpDetails();
            Console.Read();

        }
    }
}
