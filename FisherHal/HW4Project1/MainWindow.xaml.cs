/**********************************************************************
 * Project:         Homework 4 Project 1
 * File Name:		HW4Project1.java
 * Programmer:		Hal Fisher
 * Date Last Modified: 	09.23.2016
 ***********************************************************************
 * PROGRAM -  BMI Calculator
 * FUNCTION - Calculate BMI based on height and weight with color rating 
 * *********************************************************************
 * Class Created Associations
 * Button Private Variables:
 *	double bmi; 
 *	int height, weight;
 * ---------------------------- -------------------------
 * Algorithm
 * 0. Start Program
 * 1. DISPLAY inputs for height and weight and button to fascilitate calculation
 * 2. CALC bmi when user presses button and display color depending on calculation
 * *********************************************************************/
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

namespace HW4Project1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /**
         * Precondition:  xaml contains fields for height and weight
         *              button object, and canvas to display colors
         * Postcondition: n/a
         */
        private void button_Click(object sender, RoutedEventArgs e)
        {
            int weight = 0;
            int height = 0;
            double bmi;

            weight = Convert.ToInt16(WeightTextBox.Text);
            height = Convert.ToInt16(HeightTextBox.Text);
            weight = weight * 720;
            height = height * height;
            bmi = weight / (double)height;
            BMITextBox.Text = bmi + "";

            if (bmi < 15)
            {
                ColorCanvas.Background = Brushes.Blue;
            }
            else if (bmi > 25)
            {
                ColorCanvas.Background = Brushes.Yellow;
            }
            else
            {
                ColorCanvas.Background = Brushes.Green;
            }
        
        }
    }
}
