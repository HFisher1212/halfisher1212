using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int r = generator.Next(0, 100);
            bool wrong = true;
            int count = 1;


            while (wrong)
            {
                Console.Write("Please guess a number between 0 and 100: ");
                string guess = Console.ReadLine();
                int g = Convert.ToInt16(guess);
                if (r == g)
                {
                    count++;
                    Console.WriteLine("You got it right!");
                    Console.Write("You tried: " + count + " times.");
                    Console.ReadLine();
                    wrong = false;
                }
                else if (g < r)
                {
                    Console.WriteLine("You're number was too low");
                    count++;

                }
                else
                {
                    Console.WriteLine("You're number was too high");
                    count++;
                }
            }


        }
    }
}

