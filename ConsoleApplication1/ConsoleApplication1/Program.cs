using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello out there.");
            Console.WriteLine("I will add two numbers for you.");
            Console.WriteLine("Enter one number and press enter, then enter second number and press enter:");

            int n1, n2, sum;

            string userInput;
            userInput = Console.ReadLine();
            n1 = Int32.Parse(userInput);
            n2 = Int32.Parse(Console.ReadLine());
            sum = n1 + n2;
            Console.WriteLine(sum);
        }
    }
}
