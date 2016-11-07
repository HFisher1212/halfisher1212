/********************************************
* AUTHOR: 				Hal Fisher
* COURSE: 				CS 155 
* SECTION: 				Mon 5:30pm
* HOMEWORK #:			9
* PROJECT #:			1
* LAST MODIFIED: 		11/07/2016
*******************************************
* PROJECT SCOPE - Use inheritance to extend Snake, Orge,
*                   Marshhallowman from Alien class.
*   Algorithm
*   1.  CREATE AlienPack List array    
*   2.  WHILE 'q' not entered
*   3.      DISPLAY menu to allow adding aliens or display total damage
*   4.      IF add alien type is selected, 
*   5.          CREATE alien type object and add to List array
*   6.      ELSE IF display total damage is selected
*   7.          CALC total damage and display
*   8.      ELSE
*   9.          DISPLAY invalid selection message
*   10. END WHILE
*   11. DISPLAY List array aliens by name
*   12. DISPLAY total damage of List array
*   00. END PROGRAM
*/
using System;
using System.Collections.Generic;

namespace HW9Proj1Alien
{
    class Program
    {   
        // MAIN METHOD

        public static void Main(string[] args)
        {
            bool quit = false;
            string name;

            AlienPack.PackAlien();

            while (!quit)
            {
            
                Console.Write("\n What Type of Alien Would You Like to Add to The Alien Force? \n 1 for Snake Alien \n 2 for Orge Alien \n 3 for Marshmellow Man Alien \n 4 for Total Damage \n or Press 'q' to Quit: ");
                string answer = Console.ReadLine();
            
                if (answer.Equals("q"))
                {
                    quit = true;
                }
                else if (answer.Equals("1"))
                {
                    Console.Write(" Enter The Name of the Snake Alien: ");
                    name = Console.ReadLine();
                    Alien snake = new SnakeAlien(100, name);
                    AlienPack.AddAlien(snake);
                }
                else if (answer.Equals("2"))
                {
                    Console.Write(" Enter The Name of the Orge Alien: ");
                    name = Console.ReadLine();
                    Alien orge = new OrgeAlien(100, name);
                    AlienPack.AddAlien(orge);
                }
                else if (answer.Equals("3"))
                {
                    Console.Write(" Enter The Name of the Marshmellow Man Alien: ");
                    name = Console.ReadLine();
                    Alien marshmellow = new MarshallowmanAlien(100, name);
                    AlienPack.AddAlien(marshmellow);
                }
                else if (answer.Equals("4"))
                {
                    Console.WriteLine(" Total Damage: " + AlienPack.CalculateDamage());
                }
                else
                {
                    Console.Write("\n ERROR: That Was an Invalid Responce!\n");
                }
            }
            Console.Write("\n Alien Names Are: ");
            AlienPack.AlienNames();
            Console.WriteLine("\n Total Damage is: " + AlienPack.CalculateDamage());
            Console.ReadLine();
        }
    }

    // ALIEN CLASS
    // Base Class For All Aliens
    class Alien
    {

        public int Health { set; get; }
        public string Name { set; get; }

        public Alien(int health, string name)
        {
            Health = health;
            Name = name;
        }
    }

    // ALIENPACK CLASS
    class AlienPack
    {
        private static List<Alien> aliens;

        // PACKALIEN METHOD
        // Precondition- na
        // Postcondition- List array is created using base Alien
        public static void PackAlien()
        {
            aliens = new List<Alien>();
        }

        // ADDALIEN METHOD
        // Precondition- List array 'aliens' must be available
        // Postcondition alien class object added to List array
        public static void AddAlien(Alien newAlien)
        {
            aliens.Add(newAlien);
        }

        // GETALIENS METHOD
        // Precondition- aliens List array must be available
        // Postcondition- returns aliens List array
        public static List<Alien> GetAliens()
        {
            return aliens;
        }

        // ALIENNAMES METHOD
        // Precondition- aliens List array must be available
        // Postcondition- returns names from List array objects
        public static void AlienNames()
        {
            foreach (Alien a in aliens)
            {
                Console.Write(" " + a.Name);
            }
        }

        // CALCULATEDAMAGE METHOD
        // Precondition- aliens List array must be available
        // Postcondition- returns total damage from all aliens in List array
        public static int CalculateDamage()
        {
            int totalDamage = 0;

            foreach (Alien a in aliens)
            {
                if (a is OrgeAlien)
                {
                    OrgeAlien orge = (OrgeAlien)a;
                    totalDamage += orge.Damage;
                }
                else if (a is SnakeAlien)
                {
                    SnakeAlien snake = (SnakeAlien)a;
                    totalDamage += snake.Damage;
                }
                else if (a is MarshallowmanAlien)
                {
                    MarshallowmanAlien marshmellow = (MarshallowmanAlien)a;
                    totalDamage += marshmellow.Damage;
                }
            }
            return totalDamage;
        }
    }

    // MARSHALLOWMANALIEN CLASS

    class MarshallowmanAlien : Alien
    {
        private static int DAMAGE = 1;
        public int Damage { set; get; }

        public MarshallowmanAlien(int health, string name) : base(health, name)
        {
            Damage = DAMAGE;
        }
    }

    // ORGEALIEN CLASS
    class OrgeAlien : Alien
    {
        private static int DAMAGE = 6;
        public int Damage { set; get; }

        public OrgeAlien(int health, string name) : base(health, name)
        {
            Damage = DAMAGE;
        }
    }

    // SNAKEALIEN CLASS

    class SnakeAlien : Alien
    {
        public static int DAMAGE = 10;

        public int Damage { set; get; }

        public SnakeAlien(int health, string name) : base(health, name)
        {
            Damage = DAMAGE;
        }
    }
}
