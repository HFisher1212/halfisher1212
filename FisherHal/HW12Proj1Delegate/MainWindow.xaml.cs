/****************************************************
 * author   Hal Fisher
 * class    CS155
 * project  Homework 12 delegates
 * due date 12.1.2016
 * ***************************************************
 * Algorithm
 * 00.  START PROGRAM
 * 1.   DISPLAY WPF calculator with circle, triangle, square selectors and dimension input box
 * 2.   INPUT dimension 
 * 3.   SELECT shape type button
 * 4.   SELECT calculation button
 * 5.   DISPLAY calculation depending on previous shape selection method
 * 00. END PROGRAM
 */////////////////////////////////////////////////////////////////

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

namespace HW12Proj1Delegate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // DECLARATION AND INSTANTIATION SECTION
        ShapeDelegator delegator;
        private int a = 0;
        private double b = 0;

        public MainWindow()
        {
            InitializeComponent();    
        }
        
        // SQUARECLICK 
        // Precondition n/a
        // Postcondition delegator method set to square method
        private void Square_Click(object sender, RoutedEventArgs e)
        {
            delegator = Square2;
        }

        // CIRCLECLICK
        // Precondition n/a
        // Postcondition delegator method set to circle method
        private void Circle_Click(object sender, RoutedEventArgs e)
        {
            delegator = Circle2;
        }

        // TRIANGLECLICK
        // Precondition n/a
        // Postcondition delegator method set to triangle method
        private void Triangle_Click(object sender, RoutedEventArgs e)
        {
            delegator = Triangle2;
        }

        // CALCULATIONCLICK
        // Precondition dimension and delegate must be set
        // Postcondition textbox3 display results of delegated method
        private void button_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(textBox3.Text);
            delegator();
            textBox6.Text = Convert.ToString(b);
        }

        // SQURARE METHOD
        // Precondition n/a
        // Postiondition n/a
        public void Square2()
        {
            b = a * a;
        }

        // TRIANGLE METHOD
        // Precondtion n/a
        // Postcondition n/a
        public void Triangle2()
        {
            b = (a * a) / 2.0;
        }

        // CIRCLE METHOD
        // Precondition n/a
        // Postcondition n/a
        public void Circle2()
        {
            b = (a / 2.0) * 3.14;
        }

        // DELEGATE METHOD
        public delegate void ShapeDelegator();

        // TOSTRING METHOD

        public override string ToString()
        {
            return " " + b;
        }
    }
}
