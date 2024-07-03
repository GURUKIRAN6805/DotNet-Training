using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5_2_assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a day number (1-7):");
            int dayNumber = int.Parse(Console.ReadLine());

            string dayName = "";
            if (dayNumber == 1)
            {
                dayName = "Monday";
            }
            else if (dayNumber == 2)
            {
                dayName = "Tuesday";
            }
            else if (dayNumber == 3)
            {
                dayName = "Wednesday";
            }
            else if (dayNumber == 4)
            {
                dayName = "Thursday";
            }
            else if (dayNumber == 5)
            {
                dayName = "Friday";
            }
            else if (dayNumber == 6)
            {
                dayName = "Saturday";
            }
            else if (dayNumber == 7)
            {
                dayName = "Sunday";
            }
            else
            {
                dayName = "Invalid day number. Please enter a number between 1 and 7.";
            }

            Console.WriteLine($"The day is: {dayName}");
            Console.ReadLine();
        }

    }
}
