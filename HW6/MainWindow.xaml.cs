/**
 * Assignment       Homework 6
 * @author          Hal Fisher
 * Class            CS155
 * Due Date         10.10.2016
 * *****************************************
 * Program Description: Define a class called Counter whose objects count things.
 *     Include single class object that is manipulated with setters to increment,
 *     decrement, and reset to zero counter object from menu (in this case a real menu).
 *     Counter can not go below zero.
 *******************************************
 * Algorithme
 * 0.   START PROGRAM
 * 1.   CREATE counter class object initialized to zero.
 * 2.   PROVIDE menu to reset, increment, decrement single counter object
 * 3.   DISPLAY counter object contents
 * 00.  END PROGRAM
 * *****************************************
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

namespace HW6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // INSTANTIATION 
        Counter counter = new Counter();

        // MAIN METHOD (DECLARED IN App.xaml)

        public MainWindow()
        {
            
            InitializeComponent();
            
        }
        // RESET EVENT METHOD
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            counter.zeroCount();
            textBox.Text = Convert.ToString(counter);
        }
        
        // INCREMENT EVENT METHOD
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            counter.addOneCount();
            textBox.Text = Convert.ToString(counter);
        }

        // DECREMENT EVENT METHOD
        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            counter.subtractOneCount();
            textBox.Text = Convert.ToString(counter);
        }
    }
}
