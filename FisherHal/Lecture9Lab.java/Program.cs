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
