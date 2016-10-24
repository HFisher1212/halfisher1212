/********************************************
* AUTHOR: 				Hal Fisher
* COURSE: 				CS 155 
* SECTION: 				Mon 5:30pm
* HOMEWORK #:			7 
* PROJECT #:			1
* LAST MODIFIED: 		10/21/2016
********************************************/

/**
 * Define a class called Odometer that will be used to track fuel usage and miles per gallon.
 * Create two constructors, 1 constructor should be the no-argument constructor the other will
 * set the two instance variables. The class should have instance variables for mileage driven
 * and fuel used.  
 * Include a reset method that sets the mileage driven and the fuel used to zero.  Include an
 * add method which takes two parameters that add to the fuel consumed and the miles driven.
 * Finally create a method that returns the miles per gallon and an appropriate ToString method.
 * Write a driver program that tests all the methods and constructors.  Make sure that you 
 * protect against division by zero.  
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7Proj1
{
    class Odometer
    {
        /** CLASS VARIABLES
         */
        private int miles;
        private int fuel;

        /** DEFAULT CONSTRUCTOR
         */
        public Odometer()
        {
            setMiles(0);
            setFuel(0);
        }

        /** FULL CONSTRUCTOR
         */
        public Odometer(int miles, int fuel)
        {
            setMiles(miles);
            setFuel(fuel);
        }

        /** SETTER METHODS
         */

        /** SETMILES
         */
        public void setMiles(int driven)
        {
            miles += driven;
        }

        /** SETFUEL
         */
        public void setFuel(int gas)
        {
            fuel += gas;
        }

        /** SETALL
         */
        public void addFuelMiles(int gas, int driven)
        {
            setFuel(gas);
            setMiles(driven);
        }

        /** GETTER METHODS
         */

        /** GETFUEL
         */
        public double getFuel()
        {
            return fuel;
        }

        /** GETMILEAGE
         */
        public double getMiles()
        {
            return miles;
        }

        /** OTHER METHODS
         */

        /** RESET
         */
        public void resetAmounts()
        {
            miles = 0;
            fuel = 0;
        }

        /** GETMPG
         */
        public double getMileage()
        {
            if (getFuel() != 0 || getMiles() != 0)
            {
                return miles / fuel;
            }
            return 0.0;
        }

        /** TOSTRING
         */
        public override String ToString()
        {
           return " Miles Driven: " + getMiles() + "\n Fuel Used: " + getFuel();
        }
    }
}
