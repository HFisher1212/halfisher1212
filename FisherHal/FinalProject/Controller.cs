using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Controller : Organism
    {
        public static void Control()
        {
            Doodlebug.populateDoodlebug();
            Ant.populateAnt();

            Console.WriteLine("Wecome to Bug Fight!");
            Console.WriteLine("Press Enter After Each Round.");
            Console.WriteLine("To Stop Press 's'. ");
            String temp = "";
            do
            {

                Doodlebug.moveNHunt();
                Ant.antMoveMain();
                for (int x = 0; x < 20; x++)
                {
                    for (int y = 0; y < 20; y++)
                    {
                        if (ant[x, y].IsAlive)
                        {
                            Console.Write("| . ");
                        }
                        else if (doodlebug[x, y].IsAlive)
                        {
                            Console.Write("| " + doodlebug[x, y].StepCount + " ");
                        }
                        else
                        {
                            Console.Write("|   ");
                        }
                    }
                    Console.WriteLine(" |");
                }
                temp = Console.ReadLine();

            } while (!temp.Equals("s"));
        }
    }
}
