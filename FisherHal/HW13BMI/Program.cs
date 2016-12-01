/*******************************************************
 * author   Hal Fisher
 * class    CS155   
 * project  Homework 13 BMI
 * due date 12.5.2016
 * *****************************************************
 * Algorithm
 * 00.  START PROGRAM
 * 1.   CREATE list using Person class objects
 * 2.   SORT full list into group above BMI of 25 using Linq query commands
 * 3.   DISPLAY sorted list
 * 4.   SORT full list into group below BMI of 20 using Linq query commands
 * 5.   DISPLAY sorted list
 * 6.   SORT full list into group between BMI 20 and 24 using Linq query commands
 * 7.   DISPLAY sorted list
 * 00.  END PROGRAM
 */////////////////////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> allPeople = new List<Person>();

            allPeople.Add(new Person("Avon", "Smith", 5, 40, 60));
            allPeople.Add(new Person("Bob", "Smith", 10, 68, 190));
            allPeople.Add(new Person("Casey", "Smith", 15, 57, 110));
            allPeople.Add(new Person("David", "Smith", 20, 76, 190));
            allPeople.Add(new Person("Emily", "Smith", 25, 69, 160));
            allPeople.Add(new Person("Frank", "Smith", 28, 70, 180));
            allPeople.Add(new Person("George", "Smith", 30, 70, 175));
            allPeople.Add(new Person("Helga", "Smith", 56, 70, 165));
            allPeople.Add(new Person("Irma", "Smith", 67, 67, 160));
            allPeople.Add(new Person("Jason", "Smith", 78, 70, 170));
            allPeople.Add(new Person("Kevin", "Smith", 88, 71, 190));
            allPeople.Add(new Person("Laura", "Smith", 100, 77, 240));
            allPeople.Add(new Person("Doris", "Smith", 56, 70, 165));
            allPeople.Add(new Person("James", "Smith", 67, 67, 160));
            allPeople.Add(new Person("Mike", "Smith", 78, 70, 170));
            allPeople.Add(new Person("Steve", "Smith", 85, 71, 170));
            allPeople.Add(new Person("Kendra", "Smith", 66, 64, 115));

            Console.WriteLine("\n People Above BMI Guide Lines-");
            IEnumerable<Person> adults = from person in allPeople
                                         where ((person.Weight * 703) / (person.Height * person.Height)) >= 25
                                         select person;

            foreach (Person adult in adults)
            {
                Console.WriteLine(adult);
            }

            Console.WriteLine("\n People below BMI Guide Lines-");
            IEnumerable<Person> adults1 = from person in allPeople
                                         where ((person.Weight * 703) / (person.Height * person.Height)) < 20
                                         select person;

            foreach (Person adult in adults1)
            {
                Console.WriteLine(adult);
            }


            Console.WriteLine("\n People Within BMI Guide Lines-");

            IEnumerable<Person> adults2 = from person in allPeople
                                          where ((person.Weight * 703) / (person.Height * person.Height)) >= 20
                                          && ((person.Weight * 703) / (person.Height * person.Height)) < 25
                                          select person;

            foreach (Person adult in adults2)
            {
                Console.WriteLine(adult);
            }

            Console.ReadKey();

        }
    }
}
