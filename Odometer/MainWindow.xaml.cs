/********************************************
* AUTHOR: 				Hal Fisher
* COURSE: 				CS 155 
* SECTION: 				Mon 5:30pm
* HOMEWORK #:			7
* PROJECT #:			1
* LAST MODIFIED: 		10/24/2016
*******************************************
*   Algorithm
* 0.    START PROGRAM
* 1.    DISPLAY input screen
* 2.    SET object value fields
* 3.    DISPLAY object field values
* 4.    SET individual mileage and fuel fields
* 5.    DISPLAY updated object values
* 6.    RESET all object fields
* 7.    DISPLAY object field values (should be zero)
* 8.    COMPARE one object to another object of same class
* 9.    DISPLAY results of compare
* 00.   END PROGRAM
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HW7Proj1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Odometer vehicle = new Odometer();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        /** User Input Add Fuel and Add Mileage
         *  Precondition- ensure neither fields are empty
         *  Postcondition- display object fields using ToString
         */

        private void update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int temp2 = Convert.ToInt32(textBoxDriven.Text);
                int temp1 = Convert.ToInt32(textBoxFuel.Text);
                if (temp2 < 0 || temp1 < 0)
                {
                    if (temp1 < 0)
                    {
                        textBoxFuel.Text = Convert.ToString(0);
                        temp1 = 0;
                        MessageBox.Show(" ERROR: Add Fuel Cannot Be Negative.");
                    }
                    if (temp2 < 0)
                    {
                        textBoxDriven.Text = Convert.ToString(0);
                        temp2 = 0;
                        MessageBox.Show(" ERROR: Add Miles Cannot Be Negative.");
                    }
                }
                else
                {
                    vehicle.addFuelMiles(temp1, temp2);
                    textBoxDriven.Text = Convert.ToString(0);
                    textBoxFuel.Text = Convert.ToString(0);
                    temp1 = 0;
                    temp2 = 0;
                }
            }
            catch(Exception)
            {
                MessageBox.Show(" ERROR: Add Fuel and Add Miles Must Contain Vaild Amounts!");
            }

            textBoxTotalFuel.Text = Convert.ToString(vehicle.getFuel());
            textBoxTotalMiles.Text = Convert.ToString(vehicle.getMiles());
        }

        /** RESET ALL FIELDS
         * Precondition- none
         * Postcondition- all fields set to zero
         */
        private void buttonReset_Click(object sender, RoutedEventArgs e)
        {
            vehicle.resetAmounts();
            textBoxTotalFuel.Text = Convert.ToString(vehicle.getFuel());
            textBoxTotalMiles.Text = Convert.ToString(vehicle.getMiles());
        }

        /** CALCULATE MPG
         * Precondition- object must have valid entries for fuel and mileage
         * Postcondition- displays value of calculation (mileage / fuel).
         */
        private void buttonMPG_Click(object sender, RoutedEventArgs e)
        {
            textBoxMPG.Text = Convert.ToString(vehicle.getMileage());
        }

        /** TOSTRING
         * Precondition- must be valid object
         * Postcondition- displays object field values
         */
        private void buttonToString_Click(object sender, RoutedEventArgs e)
        {
            textBoxToString.Text = vehicle.ToString();
        }
    }
}
