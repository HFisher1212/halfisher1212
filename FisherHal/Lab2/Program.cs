using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.Write("Enter the amount of coupons you have won: ");
            string userInput = Console.ReadLine();
            n1 = Int32.Parse(userInput);
            Console.WriteLine("The amount of candy bars is " + n1 / 10 + " and gumballs is " + (n1 % 10) / 3 );
            Console.ReadLine();


        }
    }
}
