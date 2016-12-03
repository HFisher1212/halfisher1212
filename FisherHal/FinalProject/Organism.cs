using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Organism
    {
        /** DECLARATION AND INSTANTIATION SECTION */

        public static int dbBreedCount = 0;
        public static int dbLifeSpan = 0;
        public static int doodlebugCount = 0;
        public static int antCount = 0;
        protected static Ant[,] ant = new Ant[20, 20];
        protected static Doodlebug[,] doodlebug = new Doodlebug[20, 20];

        /** CONSTANCES */

        public const bool IS_ALIVE = false;
	    public const int STEP_COUNT = 0;
        public const int BREED_COUNT = 0;
        public const bool MOVED = false;


        /** CONSTRUCTOR */

        // Default Constructor
        public Organism()
        {
            this.IsAlive = IS_ALIVE;
            this.StepCount = STEP_COUNT;
            this.BreedCount = BREED_COUNT;
            this.Moved = MOVED;
        }

        /** MUTATORS */

        // IsAlive Mutator
        public bool IsAlive { set; get; }

        // BreedCounter Mutator
        public int BreedCount { set; get; }

        // StepCount Mutator
        public int StepCount { set; get; }

        // Moved Mutator
        public bool Moved { set; get; }

    }
}
