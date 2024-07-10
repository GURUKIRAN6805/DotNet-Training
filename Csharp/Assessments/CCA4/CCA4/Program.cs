using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCA4
{

    class Program
    {
        static void Main()
        {
            string filePath = @"C:\Batch_june24\Csharp\Assessments\CCA4\CCA4\Myfile.txt"; 
            string textToAppend = "All the best for CCA4 code challenge.";
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(textToAppend);
                }
                Console.WriteLine("All the best for CCA4 code challenge.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            Console.ReadLine(); 
        }
    }
}

