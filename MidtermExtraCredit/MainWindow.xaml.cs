/********************************************
* AUTHOR: 				Hal Fisher
* COURSE: 				CS 155 
* SECTION: 				Mon 5:30pm
* HOMEWORK #:			MidTerm Extra Points 
* PROJECT #:			1
* LAST MODIFIED: 		10/17/2016
********************************************/

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

namespace MidtermExtraCredit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {

        public MainWindow()
        {
            InitializeComponent();
        
            listBox.Items.Add("Th350");
            listBox.Items.Add("Th400");
            listBox.Items.Add("200-4R");
            listBox.Items.Add("700-R4");
            listBox.Items.Add("4L60");
            listBox.Items.Add("4L60E");
            listBox.Items.Add("4L80E");
            listBox.Items.Add("PCS 5-Speed");
            listBox1.Items.Add("3.04");
            listBox1.Items.Add("2.84");
            listBox1.Items.Add("3.23");
            listBox1.Items.Add("3.73");
            listBox1.Items.Add("4.10");
            listBox1.Items.Add("4.50");
                
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            if (listBox.SelectedItem.Equals("Th350"))
            {
                Transmission th350 = new Transmission("Th350", "Automatic", 2.52, 1.52, 1.00);
                textBoxFirst.Text = Convert.ToString(th350.getFirstGear());
                textBoxSecond.Text = Convert.ToString(th350.getSecondGear());
                textBoxThird.Text = Convert.ToString(th350.getThirdGear());
                textBoxFourth.Text = null;
                textBoxFifth.Text = null;
                textBoxOverdrive.Text = null;
            }

            if (listBox.SelectedItem.Equals("Th400"))
            {
                Transmission th400 = new Transmission("Th400", "Automatic", 2.48, 1.48, 1.00);
                textBoxFirst.Text = Convert.ToString(th400.getFirstGear());
                textBoxSecond.Text = Convert.ToString(th400.getSecondGear());
                textBoxThird.Text = Convert.ToString(th400.getThirdGear());
                textBoxFourth.Text = null;
                textBoxFifth.Text = null;
                textBoxOverdrive.Text = null;
            }

            if (listBox.SelectedItem.Equals("200-4R"))
            {
                Transmission r2004 = new Transmission("200-4R", "Automatic", 2.74, 1.57, 1.00, 0.67, 0.67);
                textBoxFirst.Text = Convert.ToString(r2004.getFirstGear());
                textBoxSecond.Text = Convert.ToString(r2004.getSecondGear());
                textBoxThird.Text = Convert.ToString(r2004.getThirdGear());
                textBoxFourth.Text = Convert.ToString(r2004.getFourthGear());
                textBoxFifth.Text = null;
                textBoxOverdrive.Text = Convert.ToString(r2004.getOverdrive());
            }

            if (listBox.SelectedItem.Equals("700-R4"))
            {
                Transmission r7004 = new Transmission("700-R4", "Automatic", 3.06, 1.62, 1.00, 0.75, 0.70);
                textBoxFirst.Text = Convert.ToString(r7004.getFirstGear());
                textBoxSecond.Text = Convert.ToString(r7004.getSecondGear());
                textBoxThird.Text = Convert.ToString(r7004.getThirdGear());
                textBoxFourth.Text = Convert.ToString(r7004.getFourthGear());
                textBoxFifth.Text = null;
                textBoxOverdrive.Text = Convert.ToString(r7004.getOverdrive());
            }

            if (listBox.SelectedItem.Equals("4L80E"))
            {
                Transmission l80E = new Transmission("4L80E", "Automatic", 2.48, 1.48, 1.00, 0.75, 0.75);
                textBoxFirst.Text = Convert.ToString(l80E.getFirstGear());
                textBoxSecond.Text = Convert.ToString(l80E.getSecondGear());
                textBoxThird.Text = Convert.ToString(l80E.getThirdGear());
                textBoxFourth.Text = Convert.ToString(l80E.getFourthGear());
                textBoxFifth.Text = null;
                textBoxOverdrive.Text = Convert.ToString(l80E.getOverdrive());
            }

            if (listBox.SelectedItem.Equals("PCS 5-Speed"))
            {
                Transmission pcs5speed = new Transmission("PCS 5-Speed", "Manual", 2.48, 1.86, 1.48, 1.00, 0.75, 0.75);
                textBoxFirst.Text = Convert.ToString(pcs5speed.getFirstGear());
                textBoxSecond.Text = Convert.ToString(pcs5speed.getSecondGear());
                textBoxThird.Text = Convert.ToString(pcs5speed.getThirdGear());
                textBoxFourth.Text = Convert.ToString(pcs5speed.getFourthGear());
                textBoxFifth.Text = Convert.ToString(pcs5speed.getFifthGear());
                textBoxOverdrive.Text = Convert.ToString(pcs5speed.getOverdrive());
            }

            if (listBox1.SelectedItem.Equals("3.04"))
            {
                Axle three04 = new Axle(3.04);
                textBoxAxleFirst.Text = Convert.ToString(three04.getRatio());
                textBoxAxleSecond.Text = Convert.ToString(three04.getRatio());
                textBoxAxleThird.Text = Convert.ToString(three04.getRatio());
                textBoxAxleFourth.Text = Convert.ToString(three04.getRatio());
                textBoxAxleFifth.Text = Convert.ToString(three04.getRatio());
                textBoxAxleOverdrive.Text = Convert.ToString(three04.getRatio());
            }

            if (listBox1.SelectedItem.Equals("2.84"))
            {
                Axle two84 = new Axle(3.04);
                textBoxAxleFirst.Text = Convert.ToString(two84.getRatio());
                textBoxAxleSecond.Text = Convert.ToString(two84.getRatio());
                textBoxAxleThird.Text = Convert.ToString(two84.getRatio());
                textBoxAxleFourth.Text = Convert.ToString(two84.getRatio());
                textBoxAxleFifth.Text = Convert.ToString(two84.getRatio());
                textBoxAxleOverdrive.Text = Convert.ToString(two84.getRatio());
            }

            if (listBox1.SelectedItem.Equals("3.04"))
            {
                Axle three04 = new Axle(3.04);
                textBoxAxleFirst.Text = Convert.ToString(three04.getRatio());
                textBoxAxleSecond.Text = Convert.ToString(three04.getRatio());
                textBoxAxleThird.Text = Convert.ToString(three04.getRatio());
                textBoxAxleFourth.Text = Convert.ToString(three04.getRatio());
                textBoxAxleFifth.Text = Convert.ToString(three04.getRatio());
                textBoxAxleOverdrive.Text = Convert.ToString(three04.getRatio());
            }

            if (listBox1.SelectedItem.Equals("3.04"))
            {
                Axle three04 = new Axle(3.04);
                textBoxAxleFirst.Text = Convert.ToString(three04.getRatio());
                textBoxAxleSecond.Text = Convert.ToString(three04.getRatio());
                textBoxAxleThird.Text = Convert.ToString(three04.getRatio());
                textBoxAxleFourth.Text = Convert.ToString(three04.getRatio());
                textBoxAxleFifth.Text = Convert.ToString(three04.getRatio());
                textBoxAxleOverdrive.Text = Convert.ToString(three04.getRatio());
            }

            if (listBox1.SelectedItem.Equals("3.04"))
            {
                Axle three04 = new Axle(3.04);
                textBoxAxleFirst.Text = Convert.ToString(three04.getRatio());
                textBoxAxleSecond.Text = Convert.ToString(three04.getRatio());
                textBoxAxleThird.Text = Convert.ToString(three04.getRatio());
                textBoxAxleFourth.Text = Convert.ToString(three04.getRatio());
                textBoxAxleFifth.Text = Convert.ToString(three04.getRatio());
                textBoxAxleOverdrive.Text = Convert.ToString(three04.getRatio());
            }

            if (listBox1.SelectedItem.Equals("3.04"))
            {
                Axle three04 = new Axle(3.04);
                textBoxAxleFirst.Text = Convert.ToString(three04.getRatio());
                textBoxAxleSecond.Text = Convert.ToString(three04.getRatio());
                textBoxAxleThird.Text = Convert.ToString(three04.getRatio());
                textBoxAxleFourth.Text = Convert.ToString(three04.getRatio());
                textBoxAxleFifth.Text = Convert.ToString(three04.getRatio());
                textBoxAxleOverdrive.Text = Convert.ToString(three04.getRatio());
            }


        }

    }
}
