using System;
using System.Collections.Generic;
using System.Linq;


namespace Academy2022_Linq.Exercises
{
    public class Exercise4
    {
        public static List<double> listOfNumbers = new List<double> { 125, 100, 250, 17, 266 };

        //Add 25% to all the numbers of this list.
        public static void Exercise4_Part1_Solution()
        {
            var outputList = listOfNumbers.Select(x => { x = x * 1.25; return x; }).ToList();

            foreach (var num in outputList)
            {
                Console.WriteLine(num);
            }
        }
        //Add 25% to only the even numbers of this list.
        public static void Exercise4_Part2_Solution()
        {
            var outputList = listOfNumbers.Where(x => x % 2 == 0).Select(x => { x = x * 1.25; return x; }).ToList();

            foreach (var num in outputList)
            {
                Console.WriteLine(num);
            }
        }
    }
}
