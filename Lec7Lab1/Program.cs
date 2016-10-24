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
                double score1 = Convert.ToDouble(Console.ReadLine());
                Console.Write(" What is the students quiz 2 score: ");
                double score2 = Convert.ToDouble(Console.ReadLine());
                Console.Write(" What is the students quiz 3 score: ");
                double score3 = Convert.ToDouble(Console.ReadLine());
                Console.Write(" What is the students midterm score: ");
                double midterm = Convert.ToDouble(Console.ReadLine());
                Console.Write(" What is the students final exam score: ");
                double final = Convert.ToDouble(Console.ReadLine());
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
                double total = (student[i].GetMidterm() * .35) + (student[i].GetFinal() * .40);
                if (student[i].GetQuiz1() + student[i].GetQuiz2() + student[i].GetQuiz3() > 0)
                {
                    total += ( .834 * (student[i].GetQuiz1() + student[i].GetQuiz2() + student[i].GetQuiz3()) );
                }
                Console.WriteLine(String.Format("\n Final Total is: {0}", total));
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
