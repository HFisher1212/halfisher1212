/**************************************************************************
 * @author      Hal Fisher
 * @class       CS155
 * @project     Homework 11 Project 1 Student File
 * @date        11.21.2016
 * ************************************************************************
 * Project Description- 
 * Create inner class Student Using IComparable to implement CompareTo for
 * generic Sort method. Performed file IO with 'using' for easy file IO. 
 * Single file because small elements did not warrent multiple.
 * ************************************************************************
 * Algorithm
 * 00.  START PROGRAM
 * 1.   DISPLAY request for file name to store student records
 * 2.   CREATE and open file with using() for input
 * 3.       WHILE not quit
 * 4.           ADD first name, last name, score to file
 * 5.       END WHILE 
 * 6.   READ file with using()
 * 7.       WHILE ReadLine !null
 * 8.           CREATE student objects with file contents
 * 9.           ADD student objects to array
 * 10.      END WHILE
 * 11.  CALC mean by totaling all scores and dividing by student count
 * 12.  SORT student array with generic Sort method IComparable CompareTo method
 * 13.  CALC median using sorted student array
 * 14.  CREATE StudentStat.txt containg median and mean calculations with using()
 * 00.  END PROGRAM
 */
 ///////////////////////////////  START PROGRAM  ////////////////////////////////
 // IMPORT SECTION
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11Proj1StudentFile
{
    class Program
    {
        // DECLARE AND INSTATIATE SECTION
        private const string OUTPUT_FILE = "StudentStats.txt";
        private const string DESKTOP_DIR = "c://Users/Work Laptop/Desktop/";
        private static List<Student> list = new List<Student>();
        private static double mean = 0;
        private static double median = 0;

        // MAIN METHOD
        static void Main(string[] args)
        {
            string fileName = CreateFile();
            CreateStudentArray(fileName);
            CalcMean();
            list.Sort();
            CalcMedian();
            CreateStudentStatFile();
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine(" Median: " + median);
            Console.WriteLine(" Mean: " + mean);
            Console.ReadKey();
        }

        // CALCMEDIAN METHOD
        // Precondition- n/a
        // Postcondition- calculates median private variable
        public static void CalcMedian()
        {
            if (list.Count % 2 == 0)
            {
                median = (list[(list.Count / 2)].Score + list[(list.Count / 2) - 1].Score) / 2;
            }
            else
            {
                median = list[list.Count / 2].Score;
            }  
        }

        // CALCMEAN METHOD
        // Precondition- n/a
        // Postcondition- calculates mean private variable
        public static void CalcMean()
        {
            for (int i = 0; i < list.Count; i++)
            {
                mean += list[i].Score;
            }
            mean = mean / list.Count;
        }

        // CREATESTUDENTARRAY METHOD
        // Precondition- valid file containg string, string, double must be used
        // Postcondition- student objects are added to list array
        public static void CreateStudentArray(string fileName)
        {
            Student studentRecord;

            char[] delimiterChars = { ' ' };
            string[] studentFields;

            using (StreamReader s = new StreamReader(fileName))
            {
                string line = null;
                while ((line = s.ReadLine()) != null)
                {
                    studentFields = line.Split(delimiterChars);
                    studentRecord = new Student(studentFields[0], studentFields[1], Convert.ToDouble(studentFields[2]));
                    list.Add(studentRecord);
                }
            }
        }

        // CREATEFILE METHOD
        // Precondition- if file is present it is written over
        // Postcondition- file created and user enters contents as string string double
        public static string CreateFile()
        {
            Console.Write(" Enter Name of File: ");
            string fileName = DESKTOP_DIR + Console.ReadLine();
            using (StreamWriter file = new StreamWriter(fileName))
            {
                bool quit = false;

                while (!quit)
                {
                    Console.Write(" Enter Student Name or press 'q' to Quit: ");
                    string name = Console.ReadLine();
                    if (!name.Equals("q"))
                    {
                        file.Write(name + " ");
                        Console.Write(" Enter Score: ");
                        file.WriteLine(Console.ReadLine());
                    }
                    else
                    {
                        quit = true;
                    }
                }
            }
            return fileName;
        }

        // CREATESTUDENTSTATFILE METHOD
        // Precondition- file name and location hard coded
        // Postcondition- mean and median stored in file
        public static void CreateStudentStatFile()
        {
            using (StreamWriter file = new StreamWriter(DESKTOP_DIR + OUTPUT_FILE))
            {
                file.WriteLine(" Student Score Mean: " + mean);
                file.WriteLine(" Student Score Median: " + median);
            }
        }

        // STUDENT CLASS
        private class Student : IComparable<Student>
        {
            public string FirstName { set; get; }
            public string LastName { set; get; }
            public Double Score { set; get; }

            // DEFAULT CONSTRUCTOR
            public Student()
            {
                FirstName = "First Name";
                LastName = "Last Name";
                Score = 0;
            }

            // FULL CONSTRUCTOR
            public Student(string first, string last, double score)
            {
                FirstName = first;
                LastName = last;
                Score = score;
            }

            // TOSTRING METHOD
            public override string ToString()
            {
                return " Name: " + FirstName + " " + LastName + " Score: " + Score + "\n";
            }

            // EQUALS METHOD
            public bool Equals(Student other)
            {
                return this.FirstName == other.FirstName && this.LastName == other.LastName && this.Score == other.Score;
            }

            /// <summary>
            /// EQUALS METHOD
            /// </summary>
            /// <param name="other"></param>
            /// <returns> bool </returns>
            public int CompareTo(Student other)
            {
                if (this.Score > other.Score)
                    return 1;
                else if (this.Score < other.Score)
                    return -1;
                else
                    return 0;
            }
        }
    }
}

