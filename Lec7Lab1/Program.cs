/**
 * Project-     Lec7 Lab
 * author-      Hal Fisher
 * date-        10.24.2016
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec7Lab1
{
    class Program
    {
        private static Grades[] student;

        static void Main(string[] args)
        {
            Console.Write(" How many students are in your class?");
            int size = Convert.ToInt32(Console.ReadLine());
            student = new Grades[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write(" What is the students quiz 1 score: ");
                int score1 = Convert.ToInt32(Console.ReadLine());
                Console.Write(" What is the students quiz 2 score: ");
                int score2 = Convert.ToInt32(Console.ReadLine());
                Console.Write(" What is the students quiz 3 score: ");
                int score3 = Convert.ToInt32(Console.ReadLine());
                Console.Write(" What is the students midterm score: ");
                int midterm = Convert.ToInt32(Console.ReadLine());
                Console.Write(" What is the students final exam score: ");
                int final = Convert.ToInt32(Console.ReadLine());
                student[i] = new Grades(midterm, score1, score2, score3, final);
                Console.WriteLine();
            }
            ListGrades();
        }

        public static void ListGrades()
        {
            int count = 1;
            for (int i = 0; i < student.Length; i++)
            {
                string peach;

                Console.WriteLine("\n Student " + count );
                Console.WriteLine(student[i]);
                double total = ((student[i].GetMidterm() / 100) * .35) + ((student[i].GetFinal() / 100) * .40);
                if (student[i].GetQuiz1() + student[i].GetQuiz2() + student[i].GetQuiz3() > 0)
                {
                    total += (  ((student[i].GetQuiz1() + student[i].GetQuiz2() + student[i].GetQuiz3()) / 30) * .25 );
                    total *= 100;
                }
                Console.WriteLine(String.Format("\n Final Total is: {0}", total.ToString("##.##")));
                if (total >= 90)
                {
                    peach = "A";
                }
                else if (total >= 80)
                {
                    peach = "A";
                }
                else if (total >= 70)
                {
                    peach = "C";
                }
                else if (total >= 60)
                {
                    peach = "D";
                }
                else
                {
                    peach = "F";
                }
                Console.Write(String.Format("\n Final Grade is: {0}", peach));
                count++;
            }
            Console.ReadLine();
        }

    }
}
