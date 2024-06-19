using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class ParamsEg
    {
        public static void Main()
        {
            ParamsEg paramseg = new ParamsEg();
            int result = paramseg.AddElements();
            Console.WriteLine("The total is :{0}", result);
            result = paramseg.AddElements(5);
            Console.WriteLine("The total is :{0}", result);
            result = paramseg.AddElements(2, 3, 5, 8, 1, 4);
            Console.WriteLine("The total is :{0}", result);

            int[] numbers = new int[3];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;

            result = paramseg.AddElements(numbers);
            Console.WriteLine("The total is :{0}", result);
            Console.WriteLine("-------------");
            Add(5, 10.6f);
            Add(10, 125.55f, 12.45, 345.56, 123456.678); ;
            Console.Read();

        }
        public int AddElements(params int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }

        public static void Add(int x, float f, params double[] d)
        {
            Console.WriteLine("{0}, {1}", x, f);
            Console.WriteLine("There are {0} number of elements in the Array", d.Length);
            foreach (double dbl in d)
            {
                Console.WriteLine(dbl);
            }
        }
    }
}


