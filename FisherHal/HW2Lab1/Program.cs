/******************************************************************************* 
 * PROGRAM NAME:      HW2Lab1
 * AUTHOR:         Hal Fisher
 * DATE CREATED:   August 24, 2015
 *******************************************************************************
 * Problem Statement: Ask the user to enter three numbers, calculate the sum of
 * these three numbers, and display the sum to the screen
 * *****************************************************************************/

 /****************************************************************************** 
  * PSUEDOCODE:
  * 0. START PROGRAM
  * 1. Print an initial welcoming message to the screen
  * 2. Prompt the user for three integers
  * 3. Calculate the sum of the integers
  * 4. Print the sum of the integers to the screen
  * 5. END PROGRAM
***********************************************************************************/ 
////////////////////////////////////////////////////////////////////////////////////
////////////////////////////  START PROGRAM  ///////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // print a message to the screen
            Console.WriteLine("Hello out there.");
            Console.WriteLine("I will add three numbers for you.");
            Console.WriteLine("Enter one number and press enter, then enter second number, press enter, then enter third number:");

            // declare three integer variables
            int n1, n2, n3,sum;

            string userInput;
            userInput = Console.ReadLine();
            n1 = Int32.Parse(userInput);
            n2 = Int32.Parse(Console.ReadLine());
            n3 = Int32.Parse(Console.ReadLine());

            // calculate the sum of these two numbers
            sum = n1 + n2 + n3;

            // print a message along with the sum of the two numbers
            Console.WriteLine("The sum of those three numbers is");
            Console.WriteLine(sum);

            //Just to pause the screen.
            Console.ReadLine();

        }
    }
}
