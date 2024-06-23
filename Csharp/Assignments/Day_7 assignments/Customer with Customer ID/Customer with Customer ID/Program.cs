using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_with_Customer_ID
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public Customer()
        {
            Console.WriteLine("Default constructor called.");
        }
        public Customer(int customerId, string name, int age, string phone, string city)
        {
            CustomerId = customerId;
            Name = name;
            Age = age;
            Phone = phone;
            City = city;
            Console.WriteLine("Parameterized constructor called.");
        }
        public static void DisplayCustomer()
        {
            Console.WriteLine("Static method DisplayCustomer() called.");
            Console.WriteLine("This method is called directly without creating an object.");
        }
        ~Customer()
        {
            Console.WriteLine($"Destructor called for Customer {CustomerId}: {Name}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter customer details:");
            Console.Write("Customer ID: ");
            int customerId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Phone: ");
            string phone = Console.ReadLine();
            Console.Write("City: ");
            string city = Console.ReadLine();
            Customer customer = new Customer(customerId, name, age, phone, city);
            Console.WriteLine("\nDisplaying customer information:");
            Console.WriteLine($"Customer ID: {customer.CustomerId}");
            Console.WriteLine($"Name: {customer.Name}");
            Console.WriteLine($"Age: {customer.Age}");
            Console.WriteLine($"Phone: {customer.Phone}");
            Console.WriteLine($"City: {customer.City}");
            Console.ReadLine();
        }
    }
}
