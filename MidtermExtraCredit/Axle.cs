using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermExtraCredit
{
    class Axle
    {
        private double ratio;

        public Axle()
        {
            ratio = 0;
        }

        public Axle(double num)
        {
            setRatio(num);
        }

        private void setRatio(double num)
        {
            ratio = num;
        }

        public double getRatio()
        {
            return ratio;
        }
    }
}
