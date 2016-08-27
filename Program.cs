/***********************************************************************
 * AUTHOR:			HAL FISHER
 * COURSE:			CS 155 C#
 * SECTION:			Mon 5:30pm
 * HOMEWORK #:		1
 * PROJECT #:		1
 * LAST MODIFIED:	08.26.2016
 ***********************************************************************/
/************************************************************************
* PROGRAM DESCRIPTION: Create a text image that displays to console
* 
* PSEUDOCODE
* 0.   START PROGRAM
* 1.   WRITELINE(S) "TEXT IMAGE"
* 2.   READLINE // PAUSE 
* 3.   END PROGRAM
************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class HomeWork1
    {
        static void Main(string[] args)
        {
            // Print text image to the screen
            Console.WriteLine("       #####   \n    A| --  / |A");
            Console.WriteLine("    V|  0  0 |V\n     |    >  |");
            Console.WriteLine("      |  -- |\n         -- ");
            Console.WriteLine("     S P O C K");

            // Pause
            Console.ReadLine();
        }
    }
}
