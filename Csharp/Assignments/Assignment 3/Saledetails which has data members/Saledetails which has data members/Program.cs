using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saledetails_which_has_data_members
{
    internal class Saledetails
    {
        private int SalesNo;
        private int ProductNo;
        private double Price;
        private DateTime DateofSale;
        private int Qty;
        private double TotalAmount;
        public Saledetails(int salesNo, int productNo, double price, int qty, DateTime dateofSale)
        {
            SalesNo = salesNo;
            ProductNo = productNo;
            Price = price;
            Qty = qty;
            DateofSale = dateofSale;
            CalculateTotalAmount();
        }
        private void CalculateTotalAmount()
        {
            TotalAmount = Qty * Price;
        }
        public void ShowData()
        {
            Console.WriteLine("Sales Details:");
            Console.WriteLine($"Sales No: {SalesNo}");
            Console.WriteLine($"Product No: {ProductNo}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine($"Date of Sale: {DateofSale.ToShortDateString()}");
            Console.WriteLine($"Quantity: {Qty}");
            Console.WriteLine($"Total Amount: {TotalAmount:C}"); 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sales details:");
            Console.Write("Sales No: ");
            int salesNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Product No: ");
            int productNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quantity: ");
            int qty = Convert.ToInt32(Console.ReadLine());
            Console.Write("Date of Sale (MM/DD/YYYY): ");
            DateTime dateOfSale;
            while (!DateTime.TryParseExact(Console.ReadLine(), "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out dateOfSale))
            {
                Console.WriteLine("Invalid date format. Please enter in MM/DD/YYYY format:");
                Console.Write("Date of Sale (MM/DD/YYYY): ");
                Console.ReadLine();
            }
            Saledetails sale = new Saledetails(salesNo, productNo, price, qty, dateOfSale);
            sale.ShowData();
            Console.ReadLine() ;
        }
    }
}


