/********************************************
* AUTHOR: 				Hal Fisher
* COURSE: 				CS 155 
* SECTION: 				Mon 5:30pm
* HOMEWORK #:			5 
* PROJECT #:			3
* LAST MODIFIED: 		09/29/2016
********************************************/

/*****************************************************************************
* PROGRAM TITLE:		ReverseArrayContents
*****************************************************************************
* PROGRAM DESCRIPTION:	
* Program creates an int array of user entered length and fills it with Random
*   integers from 0 to 55 then reverses the contents and prints it out.
*****************************************************************************
* ALGORITHM:
* 0. START PROGRAM
* 1. CREATE integer array called numbers but do not instantiate.
* 2. OUTPUT request entry of array length
* 3. SET numbers array to length given
* 4. FOR length of array
* 5.    SET array index to random number from 0 to 55
* 6.    DISPLAY array contents at index
* 7. END FOR
* 8. FOR length of number array
* 9.    SET temp to number array highest index
* 10.   SET number array highest index to array's lowest index
* 11.   SET number array lowest index to temp
* 12.END FOR
* 13.DISPLAY contents of numbers array
* 14.PAUSE program to view results
* 00.END PROGRAM 
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5Part3
{
    class Program
    {
        // DECLARATION SECTION
        public static int[] numbers;

        // MAIN METHOD
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers();
            Reverse(numbers);
            PrintNumbers(numbers);
        }

        // ADDITIONAL METHODS

        /**
         * GENERATENUMBERS METHOD
         * Precondition- must be passed uninstantiated array
         * Postcondition- creates instantiated array containing random integers from 0 to 55
         */ 
        public static int[] GenerateNumbers()
        {
            Random rand = new Random();
            Console.Write("Please enter a number up to 10 to generate the size of the array: ");
            String temp = Console.ReadLine();
            int arrayLength = Convert.ToInt16(temp);
            numbers = new int[arrayLength];
            Console.WriteLine("This is the array Numbers before the reverse:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 56);
                Console.WriteLine(" " + numbers[i]);
            }
            return numbers;
        }

        /**
         * REVERSE METHOD
         * Precondition- argument must be int[]
         * Postcondition- returns argument array reversed
         */
        public static int[] Reverse(int[] numbers)
        {
            int temp;

            for (int i = numbers.Length -1, n = 0; n < numbers.Length / 2 ; i-- , n++)
            {
                temp = numbers[i];
                numbers[i] = numbers[n];
                numbers[n] = temp;
            }
            return numbers; 
        }

        /**
         * PRINTNUMBERS METHOD
         * Precondition- argument must be int[]
         * Postcondition- n/a
         */
        public static void PrintNumbers(int[] numbers)
        {
            Console.WriteLine(" This is the array Numbers after the reverse: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(" " + numbers[i]);
            }
            Console.ReadLine();
        } 
    }
}
