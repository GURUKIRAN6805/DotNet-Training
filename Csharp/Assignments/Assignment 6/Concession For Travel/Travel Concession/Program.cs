using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concession_For_Travel;

namespace Travel_Concession
{
    class Program
    {
        private const decimal TotalFare = 500;

        static void Main()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            TravelConcession travelConcession = new TravelConcession();
            string concessionMessage = travelConcession.CalculateConcession(age);
            Console.WriteLine($"\n{name}, {concessionMessage}");
            Console.ReadLine();
        }
    }
}

