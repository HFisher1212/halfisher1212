/********************************************
* AUTHOR: 				Hal Fisher
* COURSE: 				CS 155 
* SECTION: 				Mon 5:30pm
* HOMEWORK #:			5 
* PROJECT #:			2
* LAST MODIFIED: 		09/29/2016
********************************************/

/*****************************************************************************
* PROGRAM TITLE:		TryItOut
*****************************************************************************
* PROGRAM DESCRIPTION:	
* Creates a program creates a 10 digit array and fills it with integers then
*   creates a second array of the same size as the first using Length to set
*   size, then copies the contents of the first array into the second array.
*****************************************************************************
* ALGORITHM:
* 0. START PROGRAM
* 1. CREATE first integer array called firstArray and fill it with integers
* 2. CREATE second integer array called secondArray and set it to size of the
*           first array by using Length
* 3. FOR Length of first array 
* 4.    SET secondArray equal to firstArray
* 5.    DISPLAY contents of secondArray
* 6. END FOR    
* 00.END PROGRAM 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5TryItOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            int[] secondArray = new int[firstArray.Length];

            // Display Original Contents of Arrays
            Console.WriteLine(" Contents of Arrays Before Copy-");
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.WriteLine(" First array's contents at location " + i + "= " + firstArray[i]);
                Console.WriteLine(" Second array's contents at location " + i + "= " + secondArray[i]);
            }

            // Perform Array Copy
            Console.WriteLine();
            Console.WriteLine(" Start Array Copy.");
            for (int i = 0; i < firstArray.Length; i++)
            {
                secondArray[i] = firstArray[i];
            }
            Console.WriteLine(" Copy Completed.");
            Console.WriteLine();

            // Display Contents of Arrays After Copy
            Console.WriteLine(" Contents of Arrays After Copy-");
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.WriteLine(" First array's contents at location " + i + "= " + firstArray[i]);
                Console.WriteLine(" Second array's contents at location " + i + "= " + secondArray[i]);
            }

            // Pause to Display
            Console.WriteLine();
            Console.WriteLine(" Press 'Enter' to quit");
            Console.ReadLine();
        }
    }
}
