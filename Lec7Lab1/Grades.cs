using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec7Lab1
{
    class Grades
    {
        private double midterm;
        private double quiz1;
        private double quiz2;
        private double quiz3;
        private double final;

        public Grades()
        {
            this.midterm = 0;
            this.quiz1 = 0;
            this.quiz2 = 0;
            this.quiz3 = 0;
            this.final = 0;
        }

        public Grades(double mid, double q1, double q2, double q3, double fin)
        {
            this.SetMidterm(mid);
            this.SetQuiz1(q1);
            this.SetQuiz2(q2);
            this.SetQuiz3(q3);
            this.SetFinal(fin);
        }

        public void SetMidterm(double mid)
        {
            this.midterm = mid;
        }

        public void SetQuiz1(double score)
        {
            this.quiz1 = score;
        }

        public void SetQuiz2(double score)
        {
            this.quiz2 = score;
        }

        public void SetQuiz3(double score)
        {
            this.quiz3 = score;
        }

        public void SetFinal(double score)
        {
            this.final = score;
        }

        public double GetMidterm()
        {
            return this.midterm;
        }

        public double GetQuiz1()
        {
            return this.quiz1;
        }

        public double GetQuiz2()
        {
            return this.quiz2;
        }

        public double GetQuiz3()
        {
            return this.quiz3;
        }

        public double GetFinal()
        {
            return this.final;
        }

        public override string ToString()
        {
            return String.Format(" Students Tests Scores are - \n Quiz 1: {0} \n Quiz 2: {1} \n Quiz 3: {2} \n Midterm: {3} \n Final: {4}", this.GetQuiz1(), this.GetQuiz2(), this.GetQuiz3(), this.GetMidterm(), this.GetFinal());
        }


    }
}
