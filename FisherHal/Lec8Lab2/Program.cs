using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec8Lab2
{
    struct Program
    {
        static void Main(string[] args)
        {
            Fraction frac1 = new Fraction(4, 16);
            Console.WriteLine(frac1.reduced());
            Console.WriteLine(frac1);
            Console.ReadKey();
        }
    }
}
