using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    enum cities { agra = 3, bengalur = 1, chennai = 5, delhi = 4, mumbai = 7, kolkata = 9 }
    class enumerations
    {
        enum days { sunday, monday, tuesday, wednesday, thursday, friday, saturday }
        public static void enumoper()
        {
            foreach (int x in Enum.GetValues((typeof(cities))))
            {
                if (x == 1)
                {
                    Console.WriteLine(Enum.GetName(typeof(cities), x) + "is garden city");
                }
                else if (x == 5)
                {
                    Console.WriteLine(Enum.GetName(typeof(cities), x) + "is good ");
                }
            }
            foreach (var v in Enum.GetNames(typeof(cities)))
            {
                Console.WriteLine(v);
            }
        }
    }
}