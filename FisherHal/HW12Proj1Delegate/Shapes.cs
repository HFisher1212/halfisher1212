using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12Proj1Delegate
{
    class Shapes
    {
        public int Height { set; get; }
        public int Width { set; get; }
        public ShapeDelegator delegator;

        public Shapes()
        {
            Height = 0;
            Width = 0;
        }

        public Shapes(int a, int b)
        {
            Height = a;
            Width = b;
        }

        public double Square()
        {
            return Height * Width;
        }

        public double Triangle(int a, int b)
        {
            return (a * b) / 2; 
        }

        public double Circle(int a, int b)
        {
            return (a / 2) * 3.14;
        }

    }

}
