using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec6Lab2
{
    class Fraction
    {
        int numerator;
        int denominator;

        // CONSTRUCTOR DEFAULT
        public Fraction(int num, int denom)
        {
            this.setNumerator(num);
            this.setDenominator(denom);
        }

        // SETTERS
        public void setNumerator(int numerator)
        {
            this.numerator = numerator;
        }

        public void setDenominator(int denominator)
        {
            this.denominator = denominator;
        }

        // GETTERS
        public int getDenominator()
        {
            return this.denominator;
        }

        public int getNumerator()
        {
            return this.numerator;
        }

        public double getValue()
        {
            return this.numerator / (double)this.denominator;
        }

        // OTHER METODS
        public override string ToString()
        {
            return String.Format("{0}/{1} = {2}", this.numerator, this.denominator, getValue());
        }

        public string reduced()
        {
            return String.Format("{0}/{1}", this.numerator / gcd(), this.denominator / gcd());
        }

        public int gcd()
        {
            int factor = 1;
            int max = 0;
            if (numerator > denominator)
            {
                max = denominator;
            }
            else
            {
                max = numerator;
            }

            for (int i = 2; i <= max; i++)
            {
                if (numerator % i == 0 && denominator % i == 0)
                {
                    factor = i;
                }
            }
            return factor;
        }
    }
}
