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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int weight = 0;
            int height = 0;
            int bmi;

            weight = Convert.ToInt16(WeightTextBox.Text);
            height = Convert.ToInt16(HeightTextBox.Text);
            weight = weight * 720;
            height = height * height;
            bmi = weight / height;
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
