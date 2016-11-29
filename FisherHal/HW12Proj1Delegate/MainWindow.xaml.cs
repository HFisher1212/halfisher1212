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

namespace HW12Proj1Delegate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ShapeDelegator delegator;
        Shapes shape;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Square_Click(object sender, RoutedEventArgs e)
        {
            shape = new Shapes(Convert.ToInt32(textBox), Convert.ToInt32(textBox1));
            delegator = Square;
        }

        private void Circle_Click(object sender, RoutedEventArgs e)
        {
            shape = new Shapes(Convert.ToInt32(textBox3), Convert.ToInt32(textBox2));
            delegator = Circle;
        }

        private void Triangle_Click(object sender, RoutedEventArgs e)
        {
            shape = new Shapes(Convert.ToInt32(textBox4), Convert.ToInt32(textBox5));
            delegator = Triangle;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox6.Text = shape.delegate();
        }

        public double Square(int a, int b)
        {
            return a * b;
        }

        public delegate double ShapeDelegator(int a, int b);
    }
}
