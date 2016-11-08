using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec10Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;

            while (!quit)
            {
                Console.Write("\n To Enter a New Phone Number Press 1: \n To Delete Record Press 2: \n To Search Records Press 3: \n To Quit Press 'q': ");
                string answer = Console.ReadLine();
                if (answer.Equals("q") || answer.Equals("Q"))
                {
                    quit = true;
                }
                else if (answer.Equals("1"))
                {
                    Records.AddContent();
                }
                else if (answer.Equals("2"))
                {
                    Records.DeleteContent();
                }
                else if (answer.Equals("3"))
                {
                    Console.Write("\n The Phone Number is: {0} \n", Records.SearchContent());
                }
                else
                {
                    Console.WriteLine("\n ERROR: That Was Not a Valid Entry!");
                }
            }
        }
    }
}
