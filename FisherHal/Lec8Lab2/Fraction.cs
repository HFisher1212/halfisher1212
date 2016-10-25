using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec8Lab2
{
    struct Fraction
    {
        int _numerator;
        int _denominator;

        // CONSTRUCTOR DEFAULT
        public Fraction(int num, int denom)
        {
            _numerator = num;
            _denominator = denom;
        }

        // PROPERTIES
        public int Numerator
        {
            get
            {
                return _numerator;
            }
            set
            {
                _numerator = value;
            }
        }

        public int Denominator
        {

            get
            {
                return _denominator;
            }
            set
            {
                _denominator = value;
            }
        }

        public int getValue()
        {
            return Numerator + Denominator;
        }



        // OTHER METODS
        public override string ToString()
        {
            return String.Format("{0}/{1} = {2}", this.Numerator, this.Denominator, getValue());
        }

        public string reduced()
        {
            return String.Format("{0}/{1}", this.Numerator / gcd, this.Denominator / gcd);
        }

        public int gcd

        {
            get
            {
                int factor = 1;
                int max = 0;
                if (Numerator > Denominator)
                {
                    max = Denominator;
                }
                else
                {
                    max = Numerator;
                }

                for (int i = 2; i <= max; i++)
                {
                    if (Numerator % i == 0 && Denominator % i == 0)
                    {
                        factor = i;
                    }
                }
                return factor;
            }
        }
    }
}
