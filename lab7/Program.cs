/**********************************************************************
 * Assignment:		HomeWork4 Project 2
 * File Name:		HW4.java
 * Programmer:		Hal Fisher
 * Date Last Modified: 	09.20.2016
 **********************************************************************
 * PROGRAM - HW4Project2
 * FUNCTION - Tests Employee Entry System 
 * ********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4Project2
{
    class Program
    {
        // PRIVATE CLASS VARIABLES
        public const int flips = 10000;
        private static int h = 0;
        private static int t = 0;

        /* MAIN SECTION */

        /* Precondition: Requires class private variables and method setter() method
        * Postcondition: Displays results of coin toss in percentages 
        */
        static void Main(string[] args)
        {

            // MAIN BODY
            int num;
            Random generator = new Random();

            for (int i = 1; i <= flips; i++)
            {
                num = generator.Next(2);
                if (num == 1)
                {
                    h++;
                }
                else
                {
                    t++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Number of heads: " + h);
            Console.WriteLine("Number of tails: " + t);
            Console.WriteLine("Percentage heads: {0:P2}%", h / (double)flips);
            Console.WriteLine("Percent tails: {0:P2}%", t / (double)flips);
            Console.ReadKey();
        }
    }
}
