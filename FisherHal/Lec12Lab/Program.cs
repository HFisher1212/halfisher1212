using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec12Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            ParaDelegate delegator = MeanCalc;

            int[] a = { 1, 2, 3, 4, 5 };
            double result = delegator(4,a);

            Console.Write(" Mean: {0}", result);

            delegator = Total;

            result = delegator(6,a);

            Console.Write("\n Total: {0}", result);

            Console.ReadKey();
        }


        public static double MeanCalc(int a, params int[] num)
        {
            double total = 0;
            int count = 0;

            foreach (int n in num)
            {
                total += n;
                count++;
            }
            return total / count;
        }

        public static double Total(int a, params int[] num)
        {
            int total = 0;
            foreach (int n in num)
            {
                total += n;
            }
            return total + a;
        } 
    }
}
