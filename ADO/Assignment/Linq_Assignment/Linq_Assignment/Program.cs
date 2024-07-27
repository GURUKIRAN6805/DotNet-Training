using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Assignment
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }
    class Program
    {
        static void Main()
        {
            var employees = new List<Employee>
            {
            new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 6, 8), City = "Mumbai" },
            new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
            new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 4, 12), City = "Pune" },
            new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" },
            new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
            new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
            new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 6, 1), City = "Mumbai" },
            new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 6), City = "Chennai" },
            new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 8, 12), DOJ = new DateTime(2014, 12, 3), City = "Chennai" },
            new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 1, 2), City = "Pune" }
            };
            ExecuteQuery1(employees);
            ExecuteQuery2(employees);
            ExecuteQuery3(employees);
            ExecuteQuery4(employees);
            ExecuteQuery5(employees);
            ExecuteQuery6(employees);
            ExecuteQuery7(employees);
            ExecuteQuery8(employees);
            ExecuteQuery9(employees);
            ExecuteQuery10(employees);
            ExecuteQuery11(employees);
            Console.WriteLine();
            Console.ReadKey();
        }

        // Query 1
        static void ExecuteQuery1(List<Employee> employees)
        {
            var results = employees.Where(emp => emp.DOJ < new DateTime(2015, 1, 1)).ToList();
            Console.WriteLine("Query 1: Employees who joined before 1/1/2015:");
            results.ForEach(emp => Console.WriteLine($"{emp.FirstName} {emp.LastName} - Joined on: {emp.DOJ:MM/dd/yyyy}"));
            Console.WriteLine();
        }

        // Query 2
        static void ExecuteQuery2(List<Employee> employees)
        {
            var results = employees.Where(emp => emp.DOB > new DateTime(1990, 1, 1)).ToList();
            Console.WriteLine("Query 2: Employees whose DOB is after 1/1/1990:");
            results.ForEach(emp => Console.WriteLine($"{emp.FirstName} {emp.LastName} - DOB: {emp.DOB:MM/dd/yyyy}"));
            Console.WriteLine();
        }

        // Query 3
        static void ExecuteQuery3(List<Employee> employees)
        {
            var results = employees.Where(emp => emp.Title == "Consultant" || emp.Title == "Associate").ToList();
            Console.WriteLine("Query 3: Employees with designation Consultant or Associate:");
            results.ForEach(emp => Console.WriteLine($"{emp.FirstName} {emp.LastName} - Title: {emp.Title}"));
            Console.WriteLine();
        }

        // Query 4
        static void ExecuteQuery4(List<Employee> employees)
        {
            int total = employees.Count;
            Console.WriteLine($"Query 4: Total number of employees: {total}");
            Console.WriteLine();
        }

        // Query 5
        static void ExecuteQuery5(List<Employee> employees)
        {
            int totalChennai = employees.Count(emp => emp.City == "Chennai");
            Console.WriteLine($"Query 5: Total number of employees in Chennai: {totalChennai}");
            Console.WriteLine();
        }

        // Query 6
        static void ExecuteQuery6(List<Employee> employees)
        {
            int highestID = employees.Max(emp => emp.EmployeeID);
            Console.WriteLine($"Query 6: Highest Employee ID: {highestID}");
            Console.WriteLine();
        }

        // Query 7
        static void ExecuteQuery7(List<Employee> employees)
        {
            int totalAfter2015 = employees.Count(emp => emp.DOJ > new DateTime(2015, 1, 1));
            Console.WriteLine($"Query 7: Total number of employees who joined after 1/1/2015: {totalAfter2015}");
            Console.WriteLine();
        }

        // Query 8
        static void ExecuteQuery8(List<Employee> employees)
        {
            int totalNotAssociate = employees.Count(emp => emp.Title != "Associate");
            Console.WriteLine($"Query 8: Total number of employees whose designation is not Associate: {totalNotAssociate}");
            Console.WriteLine();
        }

        // Query 9
        static void ExecuteQuery9(List<Employee> employees)
        {
            var cityGroups = employees.GroupBy(emp => emp.City)
                                      .Select(g => new { City = g.Key, Count = g.Count() })
                                      .ToList();
            Console.WriteLine("Query 9: Total number of employees by City:");
            cityGroups.ForEach(g => Console.WriteLine($"{g.City}: {g.Count}"));
            Console.WriteLine();
        }

        // Query 10
        static void ExecuteQuery10(List<Employee> employees)
        {
            var cityTitleGroups = employees.GroupBy(emp => new { emp.City, emp.Title })
                                            .Select(g => new { g.Key.City, g.Key.Title, Count = g.Count() })
                                            .ToList();
            Console.WriteLine("Query 10: Total number of employees by City and Title:");
            cityTitleGroups.ForEach(g => Console.WriteLine($"{g.City} - {g.Title}: {g.Count}"));
            Console.WriteLine();
        }

        // Query 11
        static void ExecuteQuery11(List<Employee> employees)
        {
            var youngestDOB = employees.Max(emp => emp.DOB);
            var youngestEmployees = employees.Where(emp => emp.DOB == youngestDOB).ToList();
            Console.WriteLine("Query 11: Youngest employee(s):");
            youngestEmployees.ForEach(emp => Console.WriteLine($"{emp.FirstName} {emp.LastName} - DOB: {emp.DOB:MM/dd/yyyy}"));
            Console.WriteLine();
        }
    }
}
