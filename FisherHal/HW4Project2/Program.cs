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
        private static String userEntry;
        private static int h = 0;
        private static int t = 0;
        private static char character;

        /* MAIN SECTION */

        /* Precondition: Requires class private variables and method setter() method
        * Postcondition: Displays results of coin toss in percentages 
        */
        static void Main(string[] args)
        {

            // MAIN BODY
            Console.WriteLine("{0}For each coin toss enter either 'h' for heads or 't' for tails.", "       ");
            Console.WriteLine();
            Console.Write("First toss: ");
            setFlipResults();
            Console.Write("Second toss: ");
            setFlipResults();
            Console.Write("Third toss: ");
            setFlipResults();
            Console.Write("Fourth toss: ");
            setFlipResults();
            Console.Write("Fifth toss: ");
            setFlipResults();
            Console.Write("Sixth toss: ");
            setFlipResults();
            Console.Write("Seventh toss: ");
            setFlipResults();
            Console.Write("Eighth toss: ");
            setFlipResults();
            Console.WriteLine();
            Console.WriteLine("Number of heads: " + h);
            Console.WriteLine("Number of tails: " + t);
            Console.WriteLine("Percentage heads: {0}%", ((h / (double)8) * 100));
            Console.WriteLine("Percent tails: {0}%", ((t / (double)8) * 100));
            Console.ReadKey();
        }

        /* METHOD SECTION */

        /* 
         * Precondition: Requires class variables and main method display prompts for input direction
         * Postcondition: input for class variables 
         */
        static void setFlipResults()
        {
            userEntry = Console.ReadLine();
            character = Convert.ToChar(userEntry);

            if (character == 'h')
            {
                h++;
            }
            else
            {
                t++;
            }
        }
    }
}
