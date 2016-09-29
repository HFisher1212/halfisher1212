/********************************************
* AUTHOR: 				Hal Fisher
* COURSE: 				CS 155 
* SECTION: 				Mon 5:30pm
* HOMEWORK #:			5 
* PROJECT #:			1
* LAST MODIFIED: 		09/29/2016
********************************************/

/*****************************************************************************
* PROGRAM TITLE:		Pyramid
*****************************************************************************
* PROGRAM DESCRIPTION:	
* Creates a program that asks the user to enter the size of a triangle to 
* print out (an integer from 1 to 50), then print the triangle by printing
*  a series of lines consisting of asterisks.
*****************************************************************************
* ALGORITHM:
* 0. START PROGRAM
* 1. DISPLAY request for user input of number to 50
* 2. SET pyramidSize to user input.
* 3. FOR row equal to 0 run till row is equal to user input
* 4.    FOR column equal to 0 run till column is equal row
* 5.        DISPLAY '*'
* 6.        column + 1
* 7.    END FOR
* 8.    row + 1
* 9. END FOR
* 10.FOR pyramidSize greater than or equals
* 11.   FOR column equal to pyramid size while column > 0
* 12.       DISPLAY '*'
* 13.       column - 1
* 14.   END FOR
* 15.   pyramid - 1
* 16.END FOR
* 00.END PROGRAM 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int pyramidSize;
            Console.Write("Please enter a number for how big you would like your pyramid to be (up to 50): ");
            pyramidSize = Convert.ToInt16(Console.ReadLine());
            for (int row = 0; row <= pyramidSize; row++)
            {
                for (int column = 0; column <= row; column++) 
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            for (; pyramidSize >= 0; pyramidSize--)
            {
                for (int column = pyramidSize; column >= 0; column--)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
