using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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

namespace HorseRaceSim
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static string FILE_NAME = "Horse Info.txt";
        private static List<Horses> _fileArray = new List<Horses>(); 
        private static List<Horses> _horseArray = new List<Horses>();
        private static List<string> _horseNames = new List<string>();
        private static Player player = new Player();
        private int check = 0;
        private static int horseNum;
        private static int HORSE_LIST_COUNT = 7;
        private static Random random = new Random(_horseArray.Count);
        private static List<Int32> numArray = new List<Int32>();
        
        public MainWindow()
        {
            InitializeComponent();
            createFileArray();
            createHorseFieldArray();
        }
        
        public void createHorseFieldArray()
        {
            bool test;
            int i = 0;
            horseNum = 0;
            numArray.Clear();
            _horseNames.Clear();
            _horseArray.Clear();
            listBox.Items.Clear();
            listBox_Odds.Items.Clear();

            while (i < HORSE_LIST_COUNT)
            {
                test = true;
                horseNum = random.Next(_fileArray.Count);
                for (int m = 0; m < numArray.Count; m++)
                {
                    if (horseNum == numArray[m])
                    {
                        test = false;
                        break;
                    }
                }
                if (test)
                {
                    numArray.Add(horseNum);
                    _fileArray[horseNum].Rank = 0;
                    _horseArray.Add(_fileArray[horseNum]);
                    _horseNames.Add(_fileArray[horseNum].Name);
                    listBox.Items.Add(_fileArray[horseNum].Name);
                    listBox_Odds.Items.Add(" " + _fileArray[horseNum].Odds + ":1 ");
                    i++;
                }
            }
        }

        public static void createFileArray()
        {
            char delimiterChar = ',';
            string[] horseFields;

            using (StreamReader s = new StreamReader(FILE_NAME))
            {
                Horses horses;
                string line = null;

                while ((line = s.ReadLine()) != null)
                {
                    horseFields = line.Split(delimiterChar);
                    horses = new Horses(horseFields[0], Convert.ToInt32(horseFields[1]), Convert.ToInt32(horseFields[2]), Convert.ToInt32(horseFields[3]), Convert.ToInt32(horseFields[4]));
                    _fileArray.Add(horses);
                }
            }
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            check = 0;
            bool test = true;

            if (test)
            {
                try
                {
                    check = Convert.ToInt32(textBox.Text);
                    if (check < 2 || check > 5000)
                    {
                        throw new FormatException();
                    }
                    else
                    {
                        test = true;
                    }
                }
                catch (FormatException)
                {
                    test = false;
                    MessageBox.Show(" ERROR: Wager Amount Must be Between $2 and $5,000.");
                }
            }

            if (test)
            {
                try
                {
                    if (listBox.SelectedItem.Equals(null))
                    {
                        throw new NullReferenceException();
                    }
                    else
                    {
                        test = true;
                    }
                }
                catch(NullReferenceException)
                {
                    test = false;
                    MessageBox.Show(" ERROR: A Horse Must Be Selected!");
                }
            }
            if (test)
            {
                if (radioButton.IsChecked.Equals(true))
                {
                    player.PlayerWagerType = 1;
                }
                else if (radioButton1.IsChecked.Equals(true))
                {
                    player.PlayerWagerType = 2;
                }
                else
                {
                    player.PlayerWagerType = 3;
                }
                
                HorseTrackDriver.setHorseArray(_horseArray);
                player.PlayerBet = check;
                player.PlayerHorse = listBox.SelectedItem.ToString();
                
                HorseTrackDriver.mainRun(player);
            }
            textBox_Copy.Text = string.Format("${0:F2}", player.getPlayerTotal());

            // next line loops program for continuous playing until Exit selected
            if (test)
            {
                createHorseFieldArray();
            }
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
