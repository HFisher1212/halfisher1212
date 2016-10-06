/**
 * @author      Hal Fisher
 * Class        CS155 Mon 5:30
 * Project      Lec6 Lab2
 * Date         10.03.2016
 * ***********************************************
 * Algorithm
 * 1.   CREATE fraction object (contains numerator, denominator integers)
 * 2.   CALC lcd
 * 3.   DISPLAY lcd
 * 3.   DISPLAY results of fraction
 * 4.  END PROGRAM
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec6Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction frac1 = new Fraction(4, 16);
            Console.WriteLine(frac1.reduced());
            Console.WriteLine(frac1);
            Console.ReadKey();
        }
    }
}
