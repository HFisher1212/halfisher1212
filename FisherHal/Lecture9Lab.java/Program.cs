using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9Lab.java
{
    class Program
    {
        static void Main(string[] args)
        {
            File newGuy = new File("c:Desktop", "more stuff");
            File oldGuy = new File("c:Documents", "more stuff");
            Email newEmail = new Email("reallynolie@yahoo.com", "Hal_Fisher@Hotmail.com", "Title", "this is new");
            Email oldEmail = new Email("Hal_Fisher@Hotmail.com", "reallynolie@yahoo.com", "Title", "this is old");
        }

        public static bool ContainsKeyword(Document docObject, string keyword)
        {
            if (docObject.ToString().IndexOf(keyword, 0) >= 0)
            {
                return true;
            }
            return false;
        }
    }
}
