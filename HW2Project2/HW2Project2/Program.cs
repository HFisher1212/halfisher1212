/**
 * User inputs fahrenheit temperature and program converts to celsius and displays.
 * 
 * PROGRAM NAME:        HW2Project2
 * @author:             Hal Fisher
 * @date:               September 9, 2016
 *
 * 
 * PROBLEM DESCRIPTION: Ask user for a tempeture expressed in fahrenheit and convert to
 *                      celsius then display output.
 */

/** 
 * PSUEDOCODE:
 * 0. START PROGRAM
 * 1. PROMPT user for number in fahrenheit
 * 2. CALC   number to celsius
 * 3. OUTPUT results to console
 * 4. END PROGRAM
*/
////////////////////////////////////////////////////////////////////////////////////
////////////////////////////  START PROGRAM  ///////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////


/** Import Section */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2Project1
{
    class Program
    {
        
        /** MAIN */
        static void Main(string[] args)
        {
            /** INSTANCE VARIABLES */
            int temp;
            double tempDouble;
            string userInput;

            /** Print a request to the screen */
            Console.Write("Please enter a temperature in fahrenheit to convert to celsius: ");
                        
            userInput = Console.ReadLine();
            temp = Int32.Parse(userInput);

            /** Calculate Number to Celsius */
            tempDouble = (5 * (temp - 32)) / (double)9;

            /** Round Number 1 Decimal Place */
            tempDouble = Math.Round(tempDouble, 1);

            /** Output to Screen */
            Console.WriteLine("The temperature in celsius is: " + tempDouble);

            //Just to pause the screen.
            Console.ReadLine();

        }
    }
}


