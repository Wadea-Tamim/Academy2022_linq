using Academy2022_Linq.Data;
using Academy2022_Linq.Data.Model;
using Academy2022_Linq.Examples;
using Academy2022_Linq.Exercises;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Academy2022_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Less Code examples:
            //LessCodeExample.OrderByLinqExample();
            //LessCodeExample.OrderByWithoutLinq();
            #endregion

            #region Read from XML file:
            //LinqToXML.ReadFromXML();
            #endregion

            #region LINQ to lists:
            var employees = DataGenerator.LoadEmployees();

            var employeesInBelgium = employees.Where(x => x.Company.Country == "Belgium").ToList();

            //var employeesWorksAtPenatibusInc = employees.Where(x => x.Company.Name == "Penatibus Inc.").Select(x => x.Name);

            //if (employeesInBelgium.Any())
            //{
            //    foreach (Employee emp in employeesInBelgium)
            //    {
            //        Console.WriteLine(emp.Email);
            //    }
            //}

            #endregion

            #region LINQSliders:
            var firstMethodEmployee = UsefulMethods.LinqFirstMethod("Wesley Dyer");
            var firsOrDefaultMethodEmployee = UsefulMethods.LinqFirstOrDefaultMethod("Ethan Gibbs1");
            //Console.WriteLine(firstMethodEmployee.Email + "\n" + firsOrDefaultMethodEmployee?.Email);

            //Any() in prevoius region

            //employees = employees.OrderBy(x => x.Name).ToList();
            employees = employees.OrderByDescending(x => x.Name).ToList();
            //foreach (Employee emp in employees)
            //{
            //    Console.WriteLine(emp.Name);
            //}

            var listOfNumbers = new List<int> { 5, 100, 59, 7, 98, 72, 2, 9 };
            listOfNumbers = listOfNumbers.OrderByDescending(x => x).ToList();
            //foreach (int num in listOfNumbers)
            //{
            //    Console.WriteLine(num);
            //}



            var filterCompanyByCountry = UsefulMethods.LinqSelectCompanyNames("Belgium");
            //foreach (string company in filterCompanyByCountry)
            //{
            //    Console.WriteLine(company);
            //}

            var whereNolinq = UsefulMethods.WhereCityNameEqaualNoLinq("Richmond");
            var whereLinq = UsefulMethods.WhereCityNameEqaual("Richmond");
            #endregion


            //AdvancedExamples.GroupByExample();
            //AdvancedExamples.AggregateExample();
            //Exercise1.Exercise1Solution();

            Console.ReadKey();

           
        }
        
        

    }
}
