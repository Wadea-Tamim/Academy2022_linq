using System;
using System.Collections.Generic;
using System.Linq;

namespace Academy2022_Linq.Exercises
{
    public class Exercise2
    {
        public static List<string> listOfWords = new List<string> { "office", "school" , "Cinema", "Apple", "Book"};

        //Part1 : Try to sort this list alphabetically.
        public static void Exercise2_Part1_Solution()
        {
            //Work here :D 
        }

        //Part2 : Sort the list alphabetically then print only the first Element.
        public static void Exercise2_Part2_Solution()
        {
            var t = listOfWords.OrderBy(x => x).Take(2).ToList();
            foreach(var x in t)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
        }
    }
}
