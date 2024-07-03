using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_accepts_two__Strings
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();
            Display(firstName, lastName);
        }
        static void Display(string firstName, string lastName)
        {
            string upperFirstName = firstName.ToUpper();
            string upperLastName = lastName.ToUpper();
            Console.WriteLine(upperFirstName + upperLastName);
            Console.ReadLine();
        }
    }
}
