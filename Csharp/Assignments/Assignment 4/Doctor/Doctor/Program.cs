using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor
{
    public class Doctor
    {
        private int regnNo;
        private string name;
        private double feesCharged;
        public int RegnNo
        {
            get { return regnNo; }
            set { regnNo = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double FeesCharged
        {
            get { return feesCharged; }
            set { feesCharged = value; }
        }
        public void DisplayDoctorDetails()
        {
            Console.WriteLine($"Doctor Details:");
            Console.WriteLine($"Registration Number: {RegnNo}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Fees Charged: {FeesCharged:C}");
            Console.ReadLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor = new Doctor();
            Console.WriteLine("Enter Doctor's Registration Number:");
            doctor.RegnNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Doctor's Name:");
            doctor.Name = Console.ReadLine();
            Console.WriteLine("Enter Fees Charged:");
            doctor.FeesCharged = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nDoctor Details Entered:");
            doctor.DisplayDoctorDetails();
            Console.ReadKey();
        }
    }
}
