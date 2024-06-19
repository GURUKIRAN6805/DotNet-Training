using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    public void Whileloop()
    {
        int i = 5;
        while (i < 5) ;
        Console.WriteLine(i);
        i++;

    }
        public void ForLoop()
            {
                int total = 0;
                for(int i=1; i < 5; i++) 
                {
                   if (i == 3)
                        //break;
                      continue;
                    total += i;
            }
                Console.WriteLine("Sum of all numbers {0}", total);
        }
    }

}

}

