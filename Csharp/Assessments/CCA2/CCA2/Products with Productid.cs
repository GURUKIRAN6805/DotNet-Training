using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCA2
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
    }
    class Product_Id
    {
        static void Main()
        {
            Product[] products = new Product[10];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Enter details for Product {i + 1}:");
                Product product = new Product();
                Console.Write("Product ID: ");
                product.ProductId = int.Parse(Console.ReadLine());
                Console.Write("Product Name: ");
                product.ProductName = Console.ReadLine();
                Console.Write("Price: ");
                product.Price = double.Parse(Console.ReadLine());
                products[i] = product;
                Console.WriteLine();
            }
            Array.Sort(products, (p1, p2) => p1.Price.CompareTo(p2.Price));
            Console.WriteLine("Sorted Products:");
            foreach (var product in products)
            {
                Console.WriteLine($"Product ID: {product.ProductId}, Name: {product.ProductName}, Price: {product.Price}");
            }
            Console.ReadLine(); 
        }
    }
}
