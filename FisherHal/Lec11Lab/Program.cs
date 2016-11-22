/******************************************************************
 * @author      Hal Fisher
 * @class       CS155
 * @project     lec11lab
 * @date        11.21.2016
 * ****************************************************************
 * Alogrithm
 * 0.   START PROGRAM
 * 1.   OPEN streamreader for boy file
 * 2.       WHILE readline not null
 * 3.           SET stream field 0 to boy dictionary array key
 * 4.           SET object field to stream field 1
 * 5.           SET object field to count
 * 6.           INCREMENT counter
 * 7.       END WHILE
 * 8.   OPEN streamreader for girl file
 * 9.       WHILE readline not null
 * 10.          SET stream field 0 to girl dictionary array key
 * 11.          SET object field to stream field 1
 * 12.          SET object field to count
 * 13.          INCREMENT count
 * 14.      END WHILE
 * 15.  DISPLAY request for search name
 * 16.  SET searchname to entry
 * 17.  IF boy dictionary array contains searchname
 * 18.      DISPLAY key, object rank, object count
 * 19.  ELSE
 * 20.      DISPLAY key not found
 * 21.  IF girl dictionary array contains searchname
 * 22.      DISPLAY key, object rank, object count
 * 23.  ELSE
 * 24.      DISPLAY key not found
 * 00.  END PROGRAM 
 */
 ///////////////////////////////// START PROGRAM /////////////////////
 
 // IMPORT SECTION
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec11Lab
{
    class Program
    {
        // DECLARATION AND INSTANTIATION SECTION
        private static Names boyObject;
        private static Names girlObject;
        private static Dictionary<string, dynamic> popularBoyNameRank = new Dictionary<string, dynamic>();
        private static Dictionary<string, dynamic> popularGirlNameRank = new Dictionary<string, dynamic>();
        private static string searchName;
        private static string fileName = "c://Users/Work Laptop/Desktop/";

        // MAIN SECTION
        static void Main(string[] args)
        {
            CreateBoyDictionaryArray();
            CreateGirlDictionaryArray();
            EnterName();
            //GetSearchName();
            //SearchArrays();
            Console.ReadKey();
        }

        public static void EnterName()
        {
            bool quit = false;

            while(!quit)
            {
                GetSearchName();
                if(searchName.Equals("q"))
                {
                    quit = true;
                }
                else
                {
                    SearchArrays();
                }
            }
        }

        // GETSEARCHNAME METHOD
        // Precondition- n/a
        // Postcondition- searchName field contains user entry
        public static void GetSearchName()
        {
            Console.Write("\n Enter Name For Search: ");
            searchName = Console.ReadLine();
        } 

        // SEARCHARRAYS METHODS
        // Precondition- boy and girl dictionary arrays are available
        // Postcondition- array unchanged
        public static void SearchArrays()
        {
            if (popularBoyNameRank.ContainsKey(searchName))
            {
                Names  value = popularBoyNameRank[searchName];
                Console.Write(" " + searchName + " is ranked " + value.Rank + " amoung boys with " + value.Count + " namings.");
            }
            else
            {
                Console.Write(" " + searchName + " is not ranked among the top 1000 boy names."); 
            }
            if (popularGirlNameRank.ContainsKey(searchName))
            {
                Names value = popularGirlNameRank[searchName];
                Console.Write("\n " + searchName + " is ranked " + value.Rank + " amoung girls with " + value.Count + " namings.");
            }
            else
            {
                Console.Write("\n " + searchName + " is not ranked among the top 1000 girl names.");
            }
        }

        // CREATEBOYDICTIONARRY METHOD
        // Precondition- boy dictionary array is instantiated
        // Postcondition- boy dictionary array is filled with boy file
        public static void CreateBoyDictionaryArray()
        {
            char[] delimiterChars = { ' ' };
            string[] arrayFields;
            int count = 1;

            using (StreamReader s = new StreamReader(fileName + "boynames.txt"))
            {
                string line = null;
                while ((line = s.ReadLine()) != null)
                {
                    arrayFields = line.Split(delimiterChars);
                    boyObject = new BoyNames(Convert.ToInt32(arrayFields[1]), count);
                    popularBoyNameRank.Add(arrayFields[0], boyObject);
                    count++;
                }
            }
        }

        // CREATEGIRLDICTIONARRY METHOD
        // Precondition- girl dictionary array is instantiated
        // Postcondition- girl dictionary array is filled with boy file
        public static void CreateGirlDictionaryArray()
        {
            char[] delimiterChars = { ' ' };
            string[] arrayFields;
            int count = 1;
        
            using (StreamReader s = new StreamReader(fileName + "girlnames.txt"))
            {
                string line = null;
                while ((line = s.ReadLine()) != null)
                {
                    arrayFields = line.Split(delimiterChars);
                    girlObject = new GirlNames(Convert.ToInt32(arrayFields[1]), count);
                    popularGirlNameRank.Add(arrayFields[0], girlObject);
                    count++;
                }
            }
        }
    }
}
