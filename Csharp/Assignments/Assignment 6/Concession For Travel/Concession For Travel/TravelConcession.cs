using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concession_For_Travel
{
    public class TravelConcession
    {
        private const decimal TotalFare = 500;
        public string CalculateConcession(int age)
        {
            if (age <= 5)
            {
                return "Little Champs - Free Ticket";
            }
            else if (age > 60)
            {
                decimal discountedFare = TotalFare * 0.7m;
                return $"Senior Citizen - Calculated Fare: {discountedFare:C}";
            }
            else
            {
                return $"Ticket Booked - Fare: {TotalFare:C}";
            }
        }
    }
}
