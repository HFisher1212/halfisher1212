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
            }
            ListGrades();
        }

        public static void ListGrades()
        {
            for (int i = 0; i < student.Length; i++)
            {
                Console.Write(student[i]);
                String.Format("Final Total is: {1}",(student[i].GetMidterm() + student[i].GetFinal() + student[i].GetQuiz1() + student[i].GetQuiz2() + student[i].GetQuiz3()));
            }
            Console.ReadLine();
        }

    }
}
