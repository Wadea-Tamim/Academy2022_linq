using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Academy2022_Linq.Exercises
{
    //Using this list of numbers try to implement what you've learned to extract the even numbers.
    // to test the solution of any exercise just right the class namd and the method in main and it will print your answer.
    public class Exercise1
    {
        public static List<int> listOfNumbers = new List<int> { 12, 54, 3, 9, 4, 8, 8, 3, 9, 0, 7, 8, 2, 107, 902, 5 };

        public static void Exercise1Solution()
        {
            var evenNumbers = listOfNumbers.Where(x => x % 2 == 0).ToList();
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
