/********************************************
* AUTHOR: 				Hal Fisher
* COURSE: 				CS 155 
* SECTION: 				Mon 5:30pm
* HOMEWORK #:			7 
* PROJECT #:			2
* LAST MODIFIED: 		10/21/2016
********************************************
*   Algorithm
* 0.    START PROGRAM
* 1.    DISPLAY application
* 2.    SET require user to set degree type and temperature
* 3.    DISPLAY object fields
* 4.    SET object degree type
* 5.    UPDATE degree type and display
* 6.    UPDATE temperature and display
* 7.    COMPARE object types 
* 8.    DISPLAY results of comparison
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

namespace HW7Proj2TempetureConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // INSTANTIATE OBJECT
        Temperature first;
        
        // CLASS VARIABLE
        private float tempValue;
       
        public MainWindow()
        {
            InitializeComponent();
            listBoxOperator.Items.Add('F');
            listBoxOperator.Items.Add('C');
            listBoxOperator2.Items.Add('F');
            listBoxOperator2.Items.Add('C');
        }
        
        /** SET OBJECT
         */
        private void buttonTemp_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (listBoxOperator.SelectedItem.Equals('F'))
                {
                    if (String.IsNullOrEmpty(textBoxAllTemp.Text))
                    {
                        MessageBox.Show(" Error: Temperature Must Have a Value");
                    }
                    else
                    {
                        tempValue = float.Parse(textBoxAllTemp.Text);
                        first = new Temperature(tempValue, 'F');
                        textBoxToString1.Text = first.ToString();
                    }
                }

                else if (listBoxOperator.SelectedItem.Equals('C'))
                {
                    if (String.IsNullOrEmpty(textBoxAllTemp.Text))
                    {
                        MessageBox.Show(" Error: Temperature Must Have a Value");
                    }
                    else
                    {
                        tempValue = float.Parse(textBoxAllTemp.Text);
                        first = new Temperature(tempValue, 'C');
                        textBoxToString1.Text = first.ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(" ERROR: Temperature Must Contain a Number Value.");
            }
        }

        /** SET DEGREE TYPE
         */
        private void buttonJustType_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (listBoxOperator2.SelectedItem.Equals('C'))
                {
                    first.setType('C');
                    textBoxToString1.Text = first.ToString();
                }
                else
                {
                    first.setType('F');
                    textBoxToString1.Text = first.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(" ERROR: Temperature Type Was Not Set First.");
            }
        }

        /** SET TEMPERATURE
         */
        private void buttonJustTemp_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tempValue = float.Parse(textBoxJustTemp.Text);
                first.setTemp(tempValue);
                textBoxToString1.Text = first.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show(" ERROR: Temperature Was Not Set First.");
            }
        }

        /** CHECK EQUALITY
         */
        private void buttonEqualCheck_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (first.Equals(first))
                {
                    textBoxToString3.Text = "This equals";
                }
            }
            catch(Exception)
            {
                MessageBox.Show(" ERROR: Temperature Was Not Set First.");
            }
        }

        /** CHECK INEQUALITY
         */
        private void buttonNotEquals_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (first.Equals("time"))
                {
                    textBoxToString3.Text = "This equals";
                }
                else
                {
                    textBoxToString3.Text = "This does not equal.";
                }
            }
            catch(Exception)
            {
                MessageBox.Show(" ERROR: Temperature Was Not Set First.");
            }
        }
    }
}
