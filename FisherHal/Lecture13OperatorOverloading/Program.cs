using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture13OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector a = new Vector(5, 2, 3);
            Vector b = new Vector(-3, 4, 3);

            Vector result = a + b;

            Console.WriteLine("Vector A = {0}", a);
            Console.WriteLine("Vector B = {0}", b);
            Console.WriteLine("Vector result = {0}", result);

            Vector result2 = a - b;

            Console.WriteLine("Vector A = {0}", a);
            Console.WriteLine("Vector B = {0}", b);
            Console.WriteLine("Vector result = {0}", result2);

            Vector result3 = a * 7;
            Vector result4 = b * 7;

            Console.WriteLine("Vector A = {0}", a);
            Console.WriteLine("Vector B = {0}", b);
            Console.WriteLine("Vector result = {0}", result3);
            Console.WriteLine("Vector result = {0}", result4);

            Vector result5 = a / 2;
            Vector result6 = b / 2;

            Console.WriteLine("Vector A = {0}", a);
            Console.WriteLine("Vector B = {0}", b);
            Console.WriteLine("Vector result = {0}", result5);
            Console.WriteLine("Vector result = {0}", result6);

            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);

            a[1] = 3;
            a[0] = 5;
            a[2] = 8;
            Console.WriteLine(a[0] + " " + a[1] + " " + a[2]);


            Console.ReadKey();
        }
    }
}
