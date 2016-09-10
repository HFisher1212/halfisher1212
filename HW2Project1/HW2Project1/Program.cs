/**
 * Reads 3 whole numbers and outputs the average of the three using type cast to show
 * decimal places.
 * 
 * PROGRAM NAME:        HW2Project1
 * @author:             Hal Fisher
 * @date:               September 9, 2016
 *
 * ************************************************************************************
 * Problem Description: Ask user for 3 numbers and display average using type cast to
 * show decimal places.
 */

/** 
 * PSUEDOCODE:
 * 0. START PROGRAM
 * 1. PROMPT user for three integers
 * 2. CALC   average using type casting to show decimal places
 * 3. OUTPUT results to console
 * 4. END PROGRAM
*/
////////////////////////////////////////////////////////////////////////////////////
////////////////////////////  START PROGRAM  ///////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            // print a message to the screen
            Console.WriteLine("Hello out there.");
            Console.WriteLine("I will average three numbers for you.");
            Console.Write("Enter one number and press enter, then enter second number, press enter, then enter third number: ");

            // declare three integer variables
            int n1, n2, n3;
            double avg;

            string userInput;
            userInput = Console.ReadLine();
            n1 = Int32.Parse(userInput);
            n2 = Int32.Parse(Console.ReadLine());
            n3 = Int32.Parse(Console.ReadLine());

            // calculate the sum of these two numbers
            avg = (n1 + n2 + n3) / (double)3;

            // print a message along with the sum of the two numbers
            Console.WriteLine("The average of those three numbers is");
            Console.WriteLine(avg);

            //Just to pause the screen.
            Console.ReadLine();

        }
        static double Method(double n, double m, double o)
        {
            return n + m + o;
        }

        static int Method(int n, int m, int o)
        {
            return ( n + m + o ) / 3;
        }

    }
}

