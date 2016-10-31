/********************************************
* AUTHOR: 				Hal Fisher
* COURSE: 				CS 155 
* SECTION: 				Mon 5:30pm
* HOMEWORK #:			8 
* PROJECT #:			1
* LAST MODIFIED: 		10/31/2016
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

namespace HW8Project1Odometer
{
    class Odometer
    {
        /** CLASS VARIABLES
         */
        private double _miles;
        private int _fuel;

        /** DEFAULT CONSTRUCTOR
         */
        public Odometer()
        {
            Miles = 0;
            Fuel = 0;
        }

        /** FULL CONSTRUCTOR
         */
        public Odometer(int miles, int fuel)
        {
            Miles = miles;
            Fuel = fuel;
        }

        /** SETTER METHODS
         */

        /** SETMILES
         */

        public double Miles
        {
            set
            {
                _miles = value;
            }

            get
            {
                return _miles;
            }

        }

        public void addMiles(int driven)
        {
            _miles += driven;
        }

        /** SETFUEL
         */
        public int Fuel
        {
            set
            {
                _fuel = value;
            }

            get
            {
                return _fuel;
            }
        }

        /** SETALL
         */
        public void addFuelMiles(int gas, int driven)
        {
            _fuel += gas;
            _miles += driven;
        }

        /** GETTER METHODS
         */

        /** OTHER METHODS
         */

        /** RESET
         */
        public void resetAmounts()
        {
            _miles = 0;
            _fuel = 0;
        }

        /** GETMPG
         */
        public double getMileage()
        {
            if (Fuel != 0 || Miles != 0)
            {
                return _miles / _fuel;
            }
            return 0.0;
        }

        /** TOSTRING
         */
        public override String ToString()
        {
            return " Miles Driven: " + Miles + "\n Fuel Used: " + Fuel;
        }
    }
}

