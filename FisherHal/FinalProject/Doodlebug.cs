using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Doodlebug : Organism
    {
        // CONSTRUCTOR

        // Default Constructor
        public Doodlebug() : base()
        {  }

        // METHODS SECTION

        // Instantiate 20x20 area with doodlbugs with isAlive = false
        public static void populateDoodlebug()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int x = 0; x < 20; x++)
                {
                    doodlebug[i, x] = new Doodlebug();
                }
            }
            // Set isAlive on doodlebugs = true
            for (int x = 6; x < 7; x++)
            {
                for (int y = 5; y < doodlebugCount - 4; y++)
                {
                    doodlebug[x, y].IsAlive = true;
                }
            }
        }

        /** Move Doodlebugs */

        public static void moveNHunt()
        {
            Random random = new Random();

            // These two for loops are done to clear the true Moved setting on all doodlebugs
            for (int i = 0; i < 20; i++)
            {
                for (int x = 0; x < 20; x++)
                {
                    doodlebug[i, x].Moved = false;
                    if (doodlebug[i, x].StepCount > dbLifeSpan - 2)
                    {
                        doodlebug[i, x].IsAlive = false;
                    }
                }

            }

            // Main algorithm for doodlebug movement
            for (int i = 0; i < 20; i++)
            {
                for (int x = 0; x < 20; x++)
                {

                    // Check for available moves (hunt first, if none found then simple move)
                    if (doodlebug[i, x].IsAlive)
                    {
                        if (!doodlebug[i, x].Moved)
                        {
                            // Check to ensure some condition is met or else it may get stuck in infinite loop somewhere
                            if ((x + 1 < 20 && !doodlebug[i, x + 1].IsAlive) || (x - 1 >= 0 && !doodlebug[i, x - 1].IsAlive) || (i - 1 >= 0 && !doodlebug[i - 1, x].IsAlive) || (i + 1 < 20 && !doodlebug[i + 1, x].IsAlive))
                            {
                                // Found ant at x +1 location 
                                if (x + 1 < 20 && ant[i, x + 1].IsAlive) //&& !doodlebug[i][x].getMoved())
                                {
                                    // Set doodlebug to isAlive and kill ant (set isAlive to false) set new location to doodlebug isAlive true and moved to true
                                    if (doodlebug[i, x].BreedCount >= dbBreedCount)
                                    {
                                        ant[i, x + 1].IsAlive = false;
                                        doodlebug[i, x + 1].IsAlive = true;
                                        doodlebug[i, x + 1].Moved = true;
                                        doodlebug[i, x + 1].StepCount = 0;
                                        doodlebug[i, x + 1].BreedCount = 0;
                                        doodlebug[i, x].Moved = true;
                                        doodlebug[i, x].StepCount = 0;
                                        doodlebug[i, x].BreedCount = 0;
                                    }
                                    else
                                    {
                                        // 
                                        ant[i, x + 1].IsAlive = false;
                                        doodlebug[i, x + 1].IsAlive = true;
                                        doodlebug[i, x + 1].Moved = true;
                                        doodlebug[i, x + 1].StepCount = 0;
                                        doodlebug[i, x].IsAlive = false;
                                        doodlebug[i, x].StepCount = 0;
                                        doodlebug[i, x + 1].BreedCount = doodlebug[i, x].BreedCount + 1;
                                        doodlebug[i, x].BreedCount = 0;
                                    }
                                }
                                else if (x - 1 >= 0 && ant[i, x - 1].IsAlive) // && !doodlebug[i][x].getMoved())
                                {
                                    if (doodlebug[i, x].BreedCount >= dbBreedCount)
                                    {
                                        ant[i, x - 1].IsAlive = false;
                                        doodlebug[i, x - 1].IsAlive = true;
                                        doodlebug[i, x - 1].Moved = true;
                                        doodlebug[i, x - 1].StepCount = 0;
                                        doodlebug[i, x - 1].BreedCount = 0;
                                        doodlebug[i, x].Moved = true;
                                        doodlebug[i, x].StepCount = 0;
                                        doodlebug[i, x].BreedCount = 0;
                                    }
                                    else
                                    {
                                        ant[i, x - 1].IsAlive = false;
                                        doodlebug[i, x - 1].IsAlive = true;
                                        doodlebug[i, x - 1].Moved = true;
                                        doodlebug[i, x - 1].StepCount = 0;
                                        doodlebug[i, x].IsAlive = false;
                                        doodlebug[i, x].StepCount = 0;
                                        doodlebug[i, x - 1].BreedCount = doodlebug[i, x].BreedCount + 1;
                                        doodlebug[i, x].BreedCount = 0;
                                    }
                                }
                                else if (i - 1 >= 0 && ant[i - 1, x].IsAlive) //&& !doodlebug[i][x].getMoved())
                                {
                                    if (doodlebug[i, x].BreedCount >= dbBreedCount)
                                    {
                                        ant[i - 1, x].IsAlive = false;
                                        doodlebug[i - 1, x].IsAlive = true;
                                        doodlebug[i - 1, x].Moved = true;
                                        doodlebug[i - 1, x].StepCount= 0;
                                        doodlebug[i - 1, x].BreedCount = 0;
                                        doodlebug[i, x].Moved = true;
                                        doodlebug[i, x].StepCount = 0;
                                        doodlebug[i, x].BreedCount = 0;
                                    }
                                    else
                                    {
                                        ant[i - 1, x].IsAlive = false;
                                        doodlebug[i - 1, x].IsAlive = true;
                                        doodlebug[i - 1, x].Moved = true;
                                        doodlebug[i - 1, x].StepCount = 0;
                                        doodlebug[i, x].IsAlive = false;
                                        doodlebug[i, x].StepCount = 0;
                                        doodlebug[i - 1, x].BreedCount = doodlebug[i, x].BreedCount + 1;
                                        doodlebug[i, x].BreedCount = 0;
                                    }
                                }
                                else if (i + 1 < 20 && ant[i + 1, x].IsAlive) //&& !doodlebug[i][x].getMoved())
                                {
                                    if (doodlebug[i, x].BreedCount >= dbBreedCount)
                                    {
                                        ant[i + 1, x].IsAlive = false;
                                        doodlebug[i + 1, x].IsAlive = true;
                                        doodlebug[i + 1, x].Moved = true;
                                        doodlebug[i + 1, x].StepCount = 0;
                                        doodlebug[i + 1, x].BreedCount = 0;
                                        doodlebug[i, x].Moved = true;
                                        doodlebug[i, x].StepCount = 0;
                                        doodlebug[i, x].BreedCount = 0;
                                    }
                                    else
                                    {
                                        ant[i + 1, x].IsAlive = false;
                                        doodlebug[i + 1, x].IsAlive = true;
                                        doodlebug[i + 1, x].Moved = true;
                                        doodlebug[i + 1, x].StepCount = 0;
                                        doodlebug[i, x].IsAlive = false;
                                        doodlebug[i, x].StepCount = 0;
                                        doodlebug[i + 1, x].BreedCount = doodlebug[i, x].BreedCount + 1;
                                        doodlebug[i, x].BreedCount = 0;
                                    }
                                }
                                else
                                {
                                    int moveDir;
                                    moveDir = random.Next(8);
                                    switch (moveDir)
                                    {
                                        case 0:
                                            if (x + 1 < 20 && !doodlebug[i, x + 1].IsAlive)
                                            {
                                                doodlebug[i, x + 1].IsAlive = true;
                                                doodlebug[i, x + 1].Moved = true;
                                                doodlebug[i, x].IsAlive = false;
                                                doodlebug[i, x + 1].StepCount = (doodlebug[i, x].StepCount + 1);
                                                doodlebug[i, x + 1].BreedCount = (doodlebug[i, x].BreedCount + 1);
                                                doodlebug[i, x].BreedCount = 0;
                                                doodlebug[i, x].StepCount = 0;
                                                break;
                                            }
                                            else
                                            {
                                                moveDir = random.Next(3) + 1;
                                                break;
                                            }

                                        case 1:
                                            if (x - 1 > 0 && !doodlebug[i, x - 1].IsAlive)
                                            {
                                                doodlebug[i, x - 1].IsAlive = true;
                                                doodlebug[i, x - 1].Moved = true;
                                                doodlebug[i, x].IsAlive = false;
                                                doodlebug[i, x - 1].StepCount = doodlebug[i, x].StepCount + 1;
                                                doodlebug[i, x - 1].BreedCount = doodlebug[i, x].BreedCount + 1;
                                                doodlebug[i, x].BreedCount = 0;
                                                doodlebug[i, x].StepCount = 0;
                                                break;
                                            }
                                            else
                                            {
                                                moveDir = random.Next(4);
                                                break;
                                            }

                                        case 2:
                                            if (i - 1 > 0 && !doodlebug[i - 1, x].IsAlive)
                                            {
                                                doodlebug[i, x].IsAlive = false;
                                                doodlebug[i - 1, x].IsAlive = true;
                                                doodlebug[i - 1, x].Moved = true;
                                                doodlebug[i - 1, x].StepCount = doodlebug[i, x].StepCount + 1;
                                                doodlebug[i - 1, x].BreedCount = doodlebug[i, x].BreedCount + 1;
                                                doodlebug[i, x].BreedCount = 0;
                                                doodlebug[i, x].StepCount = 0;
                                                break;
                                            }
                                            else
                                            {
                                                moveDir = random.Next(4);
                                                break;
                                            }

                                        case 3:
                                            if (i + 1 < 20 && !doodlebug[i + 1, x].IsAlive)
                                            {
                                                doodlebug[i + 1, x].IsAlive = true;
                                                doodlebug[i + 1, x].Moved = true;
                                                doodlebug[i, x].IsAlive = false;
                                                doodlebug[i + 1, x].StepCount = doodlebug[i, x].StepCount + 1;
                                                doodlebug[i + 1, x].BreedCount = doodlebug[i, x].BreedCount + 1;
                                                doodlebug[i, x].BreedCount = 0;
                                                doodlebug[i, x].StepCount = 0;
                                                break;
                                            }
                                            else
                                            {
                                                moveDir = random.Next(3);
                                                break;
                                            }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
