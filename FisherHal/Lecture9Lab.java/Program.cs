/**
 * In the attached file you will find some video game code by J. Hacker. 
 * There is an Alien class to represent a monster and an AlienPack class 
 * that represents a band of aliens and how much damage they can inflict.
 * The code is not very object oriented and does not support information 
 * hiding in the Alien class. Rewrite the code so that inheritance is used 
 * to represent the different types of aliens instead of the “type” parameter.  
 * This should result in deletion of the “type” parameter.  Also rewrite the 
 * Alien class to hide the instance variables and create a GetDamage method 
 * for each derived class that returns the amount of damage the alien inflicts.  
 * Finally, rewrite the CalculateDamage method to use GetDamage and write a Main 
 * method that tests the code.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9Lab.java
{
    class Program
    {
        private static File newFile = new File("c:Desktop", "more stuff");
        private static File oldFile = new File("c:Documents", "more stuff");
        private static Email newEmail = new Email("reallynolie@yahoo.com", "Hal_Fisher@Hotmail.com", "blank subject", "this is new");
        private static Email oldEmail = new Email("Hal_Fisher@Hotmail.com", "reallynolie@yahoo.com", "blank subject", "this is old");

        static void Main(string[] args)
        {
            TestReturns();
            TestReturns();
            TestReturns();
            TestReturns();
            Console.ReadLine();
        }

        public static bool ContainsKeyword(Document docObject, string keyword)
        {
            if (docObject.ToString().IndexOf(keyword, 0) >= 0)
            { 
                return true;
            }
            Console.WriteLine(docObject.ToString());
            return false;
        }

        
            public static void TestReturns()
            {
                Console.Write("\n\n Type to Check-\n  File: oldFile or newFile \n  Email: newEmail or oldEmail: ");
                string type = Console.ReadLine();
            Console.Write(" Keyword to Check For: ");
            string check = Console.ReadLine();
            if (type == "oldEmail")
            {
                if (ContainsKeyword(oldEmail, check))
                {
                    Console.Write(" Email: Contains the Keyword");
                }
                else
                {
                    Console.Write(" Email: Does Not Contain the Keyword");
                }
            }
            else if (type == "newEmail")
            {
                if (ContainsKeyword(newEmail, check))
                {
                    Console.Write(" Email: Contains the Keyword");
                }
                else
                {
                    Console.Write(" Email: Does Not Contain the Keyword");
                }
            }
            else if (type == "newFile")
            {
                if (ContainsKeyword(newFile, check))
                {
                    Console.Write(" File: Contains the Keyword");
                }
                else
                {
                    Console.Write(" File: Does Not Contain the Keyword");
                }
            }
            else if (type == "oldFile")
            {
                if (ContainsKeyword(oldFile, check))
                {
                    Console.Write(" File: Contains the Keyword");
                }
                else
                {
                    Console.Write(" File: Does Not Contain the Keyword");
                }
            }
        }
    }
}
