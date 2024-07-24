using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CCA1

{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=ICS-LT-BQ8Q4D3\\SQLEXPRESS;Database=Employeemanagement;User Id=sa;Password=Guru6805;";

            Console.WriteLine("Employee Name:");
            string empName = Console.ReadLine();

            Console.WriteLine("Employee Salary:");
            float empSal = 0;
            while (!float.TryParse(Console.ReadLine(), out empSal) || empSal < 25000)
            {
                Console.WriteLine("Invalid input. Please enter a salary greater than or equal to 25000:");
            }

            Console.WriteLine("Employee Type (F,P):");
            char empType = ' ';
            while (!char.TryParse(Console.ReadLine(), out empType) || (empType != 'F' && empType != 'P'))
            {
                Console.WriteLine("Invalid input");
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Insert new employee using stored procedure
                    using (SqlCommand insertCommand = new SqlCommand("InsertEmployee", connection))
                    {
                        insertCommand.CommandType = CommandType.StoredProcedure;

                        insertCommand.Parameters.AddWithValue("@EmpName", empName);
                        insertCommand.Parameters.AddWithValue("@Empsal", empSal); // Corrected parameter name
                        insertCommand.Parameters.AddWithValue("@Emptype", empType); // Corrected parameter name

                        // Execute the stored procedure to insert new employee
                        int newEmpNo = (int)insertCommand.ExecuteScalar();
                        Console.WriteLine($"New employee added with EmpNo: {newEmpNo}");
                    }

                    // Display all employees after insertion
                    using (SqlCommand selectCommand = new SqlCommand("SELECT * FROM Employee_Details", connection))
                    {
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            Console.WriteLine("Employee Details:");
                            Console.WriteLine("EmpNo\tEmpName\tEmpSal\tEmpType");
                            while (reader.Read())
                            {
                                Console.WriteLine($"{reader["Empno"]}\t{reader["EmpName"]}\t{reader["Empsal"]}\t{reader["Emptype"]}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}