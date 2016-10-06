/**
 * @author      Hal Fisher
 * Class        CS155 Mon 5:30
 * Project      Lec6 Lab1
 * Date         10.03.2016
 * ***********************************************
 * Algorithm
 * 1.   CREATE WPF Box
 * 2.       LISTBOX holding "+", "-", "/", "%", "*"
 * 3.       TEXTBOX to hold numerator
 * 4.       TEXTBOX to hold denominator
 * 5.       BUTTON to perform action
 * 6.       TEXTBOX to hold results
 * 7.   CALC when button is pressed
 * 8.       IF listbox equals +
 * 9.           ADD numerator and denominator and display results
 * 10.          DISPLAY results in results box
 * 11.      IF listbox equals /
 * 12.          IF denominator equals 0 display exception msg
 * 13.          ELSE divide numerator by denominator
 * 14.          DISPLAY results in results box
 * 15.      IF listbox equals -
 * 16.          SUBTRACT denominator from numerator
 * 17.          DISPLAY results in results box
 * 18.      IF listbox equals *
 * 19.          MULTIPLY numerator by denominator
 * 20.          DISPLAY results in results box
 * 21.      IF listbox equals %
 * 22.          IF denominatory equals 0 display exception msg
 * 23.          ELSE divide numerator by denominator and display remainder
 * 24.              DISPLAY results in results box
 * 25.  END PROGRAM
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

namespace Lec6Lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            operatorBox.Items.Add("+");
            operatorBox.Items.Add("-");
            operatorBox.Items.Add("*");
            operatorBox.Items.Add("/");
            operatorBox.Items.Add("%");
        }

        private void resultbutton_Click(object sender, RoutedEventArgs e)
        {
            resultBox.Text = "";

            int value = Convert.ToInt32(numeratorBox.Text);
            int value2 = Convert.ToInt32(denominatorBox.Text);

            if (operatorBox.SelectedItem.Equals("+"))
            {
                int value3 = value + value2;
                resultBox.Text = Convert.ToString(value3);
            }
            if (operatorBox.SelectedItem.Equals("/"))
            {
                try
                {
                    int value3 = value / value2;
                    resultBox.Text = Convert.ToString(value3);
                }
                catch (Exception)
                {
                    MessageBox.Show("Denominator Cannot be Zero!");

                }
            }
            if (operatorBox.SelectedItem.Equals("-"))
            {
                int value3 = value - value2;
                resultBox.Text = Convert.ToString(value3);
            }
            if (operatorBox.SelectedItem.Equals("*"))
            {
                int value3 = value * value2;
                resultBox.Text = Convert.ToString(value3);
            }
            if (operatorBox.SelectedItem.Equals("%"))
            {
                int value3 = value % value2;
                resultBox.Text = Convert.ToString(value3);
            }
        }
    }
}
