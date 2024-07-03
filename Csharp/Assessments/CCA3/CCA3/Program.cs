using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCA3
{
    class Cricket
    {
        public void PointsCalculation(int numberOfMatches)
        {
            int[] scores = new int[numberOfMatches];
            int sum = 0;
            for (int i = 0; i < numberOfMatches; i++)
            {
                Console.Write($"Enter score for match {i + 1}: ");
                scores[i] = int.Parse(Console.ReadLine());
                sum += scores[i];
            }
            double average = (double)sum / numberOfMatches;
            Console.WriteLine($"Sum of scores: {sum}");
            Console.WriteLine($"Average score: {average:F2}");
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of matches: ");
            int matches = int.Parse(Console.ReadLine());
            Cricket cricket = new Cricket();
            cricket.PointsCalculation(matches);
            Console.ReadLine();
        }
    }
}
