/**
 * @authoer Hal Fisher
 * Project  Lec10Lab
 * Date     11.7
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec10Lab
{
    class Records
    {
        private static Dictionary<string, long> phoneBook = new Dictionary<string, long>();

        public static void AddContent()
        {
            bool quit = false;

            while (!quit)
            {
                Console.Write("\n Please Enter the Name or Press 'q' to Quit: ");
                string name = Console.ReadLine();
                if (name.Equals("q") || name.Equals("Q"))
                {
                    quit = true;
                }
                else
                {
                    Console.Write("\n Enter Phone Number: ");
                    long number = Convert.ToInt32(Console.ReadLine());
                    phoneBook.Add(name, number);
                }
            }
        }

        public static void DeleteContent()
        {
            Console.Write("\n Please Enter the Name or Press 'q' to Quit: ");
            string name = Console.ReadLine();
            if(phoneBook.ContainsKey(name))
            {
                phoneBook.Remove(name);
            }
            else
            {
                Console.WriteLine(" ERROR: Name Not Found.");
            }
        }

        public static long SearchContent()
        {
            Console.Write("\n Please Enter the Name or Press 'q' to Quit: ");
            string name = Console.ReadLine();
            if (phoneBook.ContainsKey(name))
            {
                return phoneBook[name];
            }
            else
            {
                Console.WriteLine(" ERROR: Name Not Found.");
                return -1;
            }
        }
    }
}

