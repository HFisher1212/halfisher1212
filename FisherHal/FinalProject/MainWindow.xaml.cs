/***************************************************
 * Project:			Final Project
 * Project Name:	Bug Fight
 * Authors:			Hal Fisher
 * Class:           CS155
 * Date Created:	Dec 5, 2016
 ***************************************************
 *	Problem Statment: Create 20 x 20 array holding user set amount of ants and doodlebugs.  
 *						ants never die unless eaten and breed 3 steps. Doodlebugs
 *						die if they have not eaten an ant in user set moves and breed 
 *						every user set steps. 
 *		PSUEDOCODE
 * 
 *  0.  START PROGRAM
 *  1.  CREATE doodlebug and ant arrays
 *  2.  POPULATE arrays with 100 ants doodlebugs with 5 doodlebugs by setting isAlive
 *				to true.
 *  3.  SET ant and doodlebug Moved variable to false // so they may move 
 *  3.  MOVE each doodlebug by iteray through doodlebug array searching for isAlive = true
 *			IF doodlebug breed count equals or greater than 8 attempt to breed
 *				SEARCH area around doodlebug for an ant to consume
 *				IF no ant 
 *					SEARCH for empty location
 *				    IF no space then add to breed and move count 
 *                  ELSE IF space available change area location to isAlive true
 *						 and set breed and move count to 0 for original doodlebug
 *						 and set new doodlebug to isAlive true
 *						 set new doodlebug moved to true // so it doesn't get moved again
 *					ELSE
 *					set ant isAlive to false
 *					set doodlebug stepCount and breedCount to 0
 *					set new isAlive doodlebug moved = true // so it doesn't get moved again
 *			ELSE
 *				SEARCH area around doodlebug for an ant to consume
 *				IF no ant 
 *					SEARCH for empty location
 *				    IF no space then add 1 to breed and move count 
 *                  ELSE IF space available change area location to isAlive true
 *						 add 1 to breedCount and moveCount
 *					ELSE
 *					set ant isAlive to false
 *					set doodlebug stepCount to 0 and add to breedCount
 *	4.	MOVE each ant by iteraying through ant array searching for isAlive = true
 *			IF ant stepCount is > 2 
 *				SEARCH area around for !isAlive ants and doodlebugs
 *					IF space available
 *						set ant at available space to isAlive = true 
 *						set new ant Moved = true // do it can not move again
 *						set new and old ant to breedCount = 0
 *					ELSE
 *						if no space available add +1 ant stepCount and breedCount
 *  5.	END PROGRAM is 'q' is entered.
 *					
 ******************************************************************************/

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

namespace FinalProject
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

        private void ConsoleTextBlock_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int check = 0;
            bool test = true;

            if (test)
            {
                try
                {
                    check = Convert.ToInt32(textBox_Copy1.Text);
                    if (check < 1 || check > 8)
                    {
                        throw new FormatException();
                    }
                    else
                    {
                        Organism.dbBreedCount = check;
                        test = true;
                    }
                }
                catch (FormatException)
                {
                    test = false;
                    MessageBox.Show(" ERROR: Breed Interval Must be Between 1 and 8");
                }
            }
                
            if (test)
            {
                try
                {
                    check = Convert.ToInt32(textBox_Copy.Text);
                    if (check < 1 || check > 8)
                    {
                        throw new FormatException();
                    }
                    else
                    {
                        Organism.dbLifeSpan = check;
                        test = true;
                    }
                }
                catch (FormatException)
                {
                    test = false;
                    MessageBox.Show(" ERROR: Life Span Must be Between 1 and 8.");
                }
            }

            if(test)
            {
                try
                {
                    check = Convert.ToInt32(textBox.Text);
                    if (check < 3 || check > 15)
                    {
                        throw new FormatException();
                    }
                    else
                    {
                        Organism.doodlebugCount = 9 + check;
                        test = true;
                    }
                }
                catch (FormatException)
                {
                    test = false;
                    MessageBox.Show(" ERROR: Doodlebug Count Must be Between 3 and 15.");
                }
            }
            if(test)
            { 
                try
                {
                    check = Convert.ToInt32(textBox1.Text);
                    if (check < 30 || check > 100)
                    {
                        throw new FormatException();
                    }
                    else
                    {
                        Organism.antCount = check;
                        test = true;
                    }
                }
                catch (FormatException)
                {
                    test = false;
                    MessageBox.Show(" ERROR: Ant Count Must be Between 30 and 100.");
                }
            }
            if (test)
            {
                Controller.Control();
            }
        }
    }
}
