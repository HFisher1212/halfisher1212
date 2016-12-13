/***********************************************************
 *  @author     Hal Fisher
 *  Class:      CS155 5:30
 *  Due Date:   12.13.16
 *  Homework:   14 Project
 *  ********************************************************
 *  Algorithm
 *  0.  START PROGRAM
 *  1.  DISPLAY request for number of duels
 *  2.  CONVERT entry to integer for duel count
 *  3.  RESET duel counters
 *  4.  SET arron skip depending on test
 *  5.  RUN duel
 *  6.      FOR duel count times
 *  7.          RESET all isAlive
 *  8.          WHILE not quit
 *  9.              IF arron isalive
 *  10.                 IF charlies isalive
 *  11.                     RANDOM kill charlie
 *  12.                     IF true
 *  13.                         SET charlie isAlive to false
 *  14.                 ELSE IF bob isAlive
 *  15.                     RANDOM kill bob
 *  16.                     IF true
 *  17.                         SET bob isAlive to false
 *  18.                 ELSE 
 *  19.                     DISPLAY arron wins
 *  20.             IF bob isAlive
 *  21.                 IF charlie isAlive
 *  22.                     RANDOM kill charlie
 *  23.                     IF true
 *  24.                         SET charlie isAliie to flase
 *  25.                 ELSE IF arron isAlive
 *  26.                     RANDDOM kill arron
 *  27.                     IF kill
 *  28.                         SET arron isAlive to false
 *  29.                 ELSE
 *  30.                      DISPLAY bob wins
 *  31              IF charlie isAlive
 *  32.                 IF bob isAlive
 *  33.                     RANDOM kill bob
 *  34.                     IF true
 *  35.                         SET bob isAlive false
 *  36.                 ELSE IF arron isAlive
 *  37.                     RANDOM kill arron
 *  38.                     IF true
 *  39.                         SET arron isAlive false
 *  40.                 ELSE
 *  41.                     DISPLAY charlie wins
 *  42.         END WHILE
 *  43.     END FOR
 *  00. END PROGRAM
 * 
 *//////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelDemo
{
    class Program
    {
        // INSTATIATIONS SECTION
        private static Duelist arron = new Duelist("Arron", .33);
        private static Duelist bob = new Duelist("Bob", .5);
        private static Duelist charlie = new Duelist("Charlie", .995);
        private static int countArron;
        private static int countBob;
        private static int countCharlie;
        private static int duelCount;
        private static bool skipArron;
        private static readonly log4net.ILog log =
log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // MAIN METHOD
        static void Main(string[] args)
        {

            Console.Write(" Enter Number of Duels: ");
            duelCount = Convert.ToInt32(Console.ReadLine());

            resetCounters();
            skipArron = false;
            Duel();
            Console.WriteLine(" FIRST TEST- ARRON ACCURACY UNCHANGED ");
            Output();

            resetCounters();
            skipArron = true;
            Duel();
            Console.WriteLine(" SECOND TEST- ARRON ACCURACY CHANGED TO MISS FIRST SHOT");
            Output();

            Console.ReadLine();
            log.Debug("Application is working");
            Console.ReadKey();
        }

        // RESETCOUNTER METHOD
        // Precondition- win counters for arron, bob, charlie, are reset
        // Postcondition- counters equal zero
        public static void resetCounters()
        {
            countArron = 0;
            countBob = 0;
            countCharlie = 0;
        }

        // RESETLIVES METHOD
        //  Precondition- boolean can be either true or false
        //  Postcondition- boolean are set to true for arron, bob, charlie
        public static void resetLives()
        {
            arron.IsAlive = true;
            bob.IsAlive = true;
            charlie.IsAlive = true;
        }

        // DUEL METHOD
        // Precondition- counter must have valid amount
        // Postcondition- isAlives and counters set to last run values.
        public static void Duel()
        {
            for(int i = 0; i < duelCount; i++)
            {
                resetLives();
                bool quit = false;
                bool shotCheck = skipArron;

                while (!quit)
                {
                    if (arron.IsAlive)
                    {
                        if (shotCheck)
                        {
                            arron.Accuracy = 0;
                            shotCheck = false;
                        }
                        else
                        {
                            arron.Accuracy = .33;
                        }
                        if (charlie.IsAlive)
                        {
                            arron.ShootAtTarget(charlie);
                        }
                        else if (bob.IsAlive)
                        {
                            arron.ShootAtTarget(bob);
                        }
                        else
                        {
                            quit = true;
                            countArron++;
                        }
                    }
                    if (bob.IsAlive)
                    {
                        if (charlie.IsAlive)
                        {
                            bob.ShootAtTarget(charlie);
                        }
                        else if (arron.IsAlive)
                        {
                            bob.ShootAtTarget(arron);
                        }
                        else
                        {
                            quit = true;
                            countBob++;
                        }
                    }
                    if (charlie.IsAlive)
                    {
                        if (bob.IsAlive)
                        {
                            charlie.ShootAtTarget(bob);
                        }
                        else if (arron.IsAlive)
                        {
                            charlie.ShootAtTarget(arron);
                        }
                        else
                        {
                            quit = true;
                            countCharlie++;
                        }
                    }
                }
            }
        }

        public static void Output()
        {
            Console.Write(" Arron Won: {0:0.00}% \n", ((countArron * 100.0) / duelCount));
            Console.Write(" Bob Won: {0:0.00}% \n", ((countBob * 100.0) / duelCount));
            Console.Write(" Charlie Won: {0:0.00}% \n", ((countCharlie * 100.0) / duelCount));
        }
    }
}
