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
        ShapeDelegator delegator;
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Square_Click(object sender, RoutedEventArgs e)
        {
        
            delegator = Square;
        }

        private void Circle_Click(object sender, RoutedEventArgs e)
        {
            delegator = Circle;
        }

        private void Triangle_Click(object sender, RoutedEventArgs e)
        {
            delegator = Triangle;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private double Square(int a, int b)

        

        public delegate double ShapeDelegator(int a, int b);
    }
}
