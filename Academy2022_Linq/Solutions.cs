using System;
using System.Collections.Generic;
using System.Linq;

namespace Academy2022_Linq
{
    public class Solutions
    {

        public static List<int> listOfNumbers = new List<int> { 12, 54, 3, 9, 4, 8, 8, 3, 9, 0, 7, 8, 2, 107, 902, 5 };
        public static List<string> listOfWords = new List<string> { "office", "school", "Cinema", "Apple", "Book" };

        //Exercise 1:
        public static void Exercise1Solution()
        {
            var evenNumbers = listOfNumbers.Where(x => x % 2 == 0).ToList();
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
        }
        //Exercise 2:
        public static void Exercise2_Part2_Solution()
        {
            Console.WriteLine(listOfWords.OrderBy(x => x).FirstOrDefault());
        }


        //Exercise 3:
        #region solution3:
        //public static void Exercise3_part1_Solution()
        //{
        //    Console.WriteLine(employees.Where(x => x.Company.Country == "Belgium" && x.Company.City == "Lakolam").FirstOrDefault().Name);
        //}

        //// using what you did earlier try to use the class EmployeeInfo to create a new employee info using Select and year of employment is 2022
        //public static void Exercise3_part2_Solution()
        //{
        //    var empInfo = employees.Where(x => x.Company.Country == "Belgium" && x.Company.City == "Lakolam").Select(x => new EmployeeInfo
        //    {
        //        Name = x.Name,
        //        Country = x.Company.Country,
        //        YearOfEmployment = 2022
        //    });

        //    Console.WriteLine(empInfo.FirstOrDefault().Name + "  " + empInfo.FirstOrDefault().YearOfEmployment);
        //}
        #endregion

        //Exercise 4:
        #region solution4:
        ////Add 25% to all the numbers of this list.
        //public static void Exercise4_Part1_Solution()
        //{
        //    var outputList = listOfNumbers.Select(x => { x = x * 1.25; return x; }).ToList();

        //    foreach (var num in outputList)
        //    {
        //        Console.WriteLine(num);
        //    }
        //}
        ////Add 25% to only the even numbers of this list.
        //public static void Exercise4_Part2_Solution()
        //{
        //    var outputList = listOfNumbers.Where(x => x % 2 == 0).Select(x => { x = x * 1.25; return x; }).ToList();

        //    foreach (var num in outputList)
        //    {
        //        Console.WriteLine(num);
        //    }
        //}
        #endregion

        //Exercise 5:
        //public static void Exercise5_Solution()
        //{
        //    var result = employees.GroupBy(emp => emp.Company.Country, emp => emp.Name);
        //    foreach (var res in result)
        //    {
        //        Console.WriteLine("Country of company: " + res.Key);
        //        foreach (var childName in res)
        //        {
        //            Console.WriteLine("Employee name: " + childName);
        //        }
        //    }
        //}

        //Exercise 6:
        public static void Exercise6_Solution()
        {
            var combo = listOfWords.Aggregate((current, x) => current + "/" + x);
            Console.WriteLine(combo);
        }

        //Exercise 7:
        public static void Exercise7_Solution()
        {
            var lengthAverage = listOfWords.Average(x => x.Length);
            Console.WriteLine(lengthAverage);
            //Work Here :D 
        }
    }
}
