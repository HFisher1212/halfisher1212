using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Ant : Organism
    { 
        // CONSTRUCTORS 

        // Default Constructor
        public Ant() : base()
        {  }

        // METHODS

        // POPULATEANT METHOD
        public static void populateAnt()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int x = 0; x < 20; x++)
                {
                    ant[i, x] = new Ant();
                }
            }

            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < (antCount / 5); y++)
                {
                    ant[x, y].IsAlive = true;
                }
            }
        }

        // ANTMOVEMAIN METHOD

        public static void antMoveMain()
        {
            Random random = new Random();
            // These two for loops are done to clear the true Moved setting on all ants
            for (int i = 0; i < 20; i++)
            {
                for (int x = 0; x < 20; x++)
                {
                    ant[i, x].Moved = false;
                }
            }

            // Main logic to configure moves
            for (int i = 0; i < 20; i++)
            {
                for (int x = 0; x < 20; x++)
                {

                    // All cases must be checked first or else switch statement may cause infinit loop
                    if (ant[i, x].IsAlive && !ant[i, x].Moved && ((x + 1 < 20 && (!ant[i, x + 1].IsAlive && !doodlebug[i, x + 1].IsAlive) || (x - 1 >= 0 && (!ant[i, x - 1].IsAlive && !doodlebug[i, x - 1].IsAlive)) || (i - 1 >= 0 && (!ant[i - 1, x].IsAlive && !doodlebug[i - 1, x].IsAlive)) || (i + 1 < 20 && (!doodlebug[i + 1, x].IsAlive)))))
                    {
                        int moveDir;
                        moveDir = random.Next(4);
                        switch (moveDir)
                        {
                            case 0:
                                if (x + 1 < 20 && (!ant[i, x + 1].IsAlive && !doodlebug[i, x + 1].IsAlive))
                                {
                                    // If true breed (but regular ants don't birth???)
                                    if (ant[i, x].StepCount + 1 >= 3)
                                    {
                                        ant[i, x + 1].IsAlive = true;
                                        ant[i, x + 1].Moved = true;
                                        ant[i, x].StepCount = 0;
                                        ant[i, x + 1].StepCount = 0;
                                        break;
                                    }
                                    // Else move
                                    else
                                    {
                                        ant[i, x].IsAlive = false;
                                        ant[i, x + 1].IsAlive = true;
                                        ant[i, x + 1].Moved = true;
                                        ant[i, x + 1].StepCount = ant[i, x].StepCount + 1;
                                        ant[i, x].StepCount = 0;
                                        break;
                                    }
                                }
                                else
                                {
                                    moveDir = random.Next(3) + 1;
                                    break;
                                }

                            case 1:
                                if (x - 1 >= 0 && (!ant[i, x - 1].IsAlive && !doodlebug[i, x - 1].IsAlive))
                                {
                                    // If true breed
                                    if (ant[i, x].StepCount + 1 >= 3)
                                    {
                                        ant[i, x - 1].IsAlive = true;
                                        ant[i, x - 1].Moved = true;
                                        ant[i, x].StepCount = 0;
                                        ant[i, x - 1].StepCount = 0;
                                        break;
                                    }
                                    // Else move
                                    else
                                    {
                                        ant[i, x].IsAlive = false;
                                        ant[i, x - 1].IsAlive = true;
                                        ant[i, x - 1].Moved = true;
                                        ant[i, x - 1].StepCount = ant[i, x].StepCount + 1;
                                        ant[i, x].StepCount = 0;
                                        break;
                                    }
                                }
                                else
                                {
                                    moveDir = (int)(random.Next(4));
                                    break;
                                }

                            case 2:
                                if (i - 1 >= 0 && (!ant[i - 1, x].IsAlive && !doodlebug[i - 1, x].IsAlive))
                                {
                                    // If true breed
                                    if (ant[i, x].StepCount + 1 >= 3)
                                    {
                                        ant[i - 1, x].IsAlive = true;
                                        ant[i - 1, x].Moved = true;
                                        ant[i, x].StepCount = 0;
                                        ant[i - 1, x].StepCount = 0;
                                        break;
                                    }
                                    // Else move
                                    else
                                    {
                                        ant[i, x].IsAlive = false;
                                        ant[i - 1, x].IsAlive = true;
                                        ant[i - 1, x].Moved = true;
                                        ant[i - 1, x].StepCount = ant[i, x].StepCount + 1;
                                        ant[i, x].StepCount = 0;
                                        break;
                                    }
                                }
                                else
                                {
                                    moveDir = random.Next(4);
                                    break;
                                }

                            case 3:
                                if (i + 1 < 20 && (!ant[i + 1, x].IsAlive && !doodlebug[i + 1, x].IsAlive))
                                {
                                    // If true breed
                                    if (ant[i, x].StepCount + 1 >= 3)
                                    {
                                        ant[i + 1, x].IsAlive = true;
                                        ant[i + 1, x].Moved = true;
                                        ant[i, x].StepCount = 0;
                                        ant[i + 1, x].StepCount = 0;
                                        break;
                                    }
                                    // Else move
                                    else
                                    {
                                        ant[i, x].IsAlive = false;
                                        ant[i + 1, x].Moved = true;
                                        ant[i + 1, x].IsAlive = true;
                                        ant[i + 1, x].StepCount = ant[i, x].StepCount + 1;
                                        ant[i, x].StepCount = 0;
                                        break;
                                    }
                                }
                                else
                                {
                                    moveDir = random.Next(3);
                                    break;
                                }
                        }
                    }
                    // If no moves available, just add to counts
                    else
                    {
                        ant[i, x].StepCount = ant[i, x].StepCount + 1;
                    }
                }
            }
        }
    }
}
