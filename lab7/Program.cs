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
        public const int FLIPS = 10000;
        private static int h = 0;
        private static int t = 0;
        public enum Flips { Heads, Tails };

        /* MAIN SECTION */

        /* Precondition: Requires class private variables and method setter() method
        * Postcondition: Displays results of coin toss in percentages 
        */
        static void Main(string[] args)
        {

            // MAIN BODY
            int num;
            Random generator = new Random();
            int[] array = new int[10000];

            for (int i = 0; i < FLIPS; i++)
            {
                num = generator.Next(2);
                array[i] = num;

                if (num == 1)
                {

                    h++;
                }
                else
                {
                    t++;
                }
            }

            PrintOutput(array);
        }

        static void PrintOutput(int[] array)
        { 
            Console.WriteLine();
            Console.WriteLine("Number of heads: " + h);
            Console.WriteLine("Number of tails: " + t);
            Console.WriteLine("Percentage heads: {0:P2}%", h / (double)FLIPS);
            Console.WriteLine("Percent tails: {0:P2}%", t / (double)FLIPS);
            Console.ReadKey();
        }
    }
}
