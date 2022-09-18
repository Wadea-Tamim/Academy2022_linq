using Academy2022_Linq.Data;
using Academy2022_Linq.Data.Model;
using System.Collections.Generic;
using System.Linq;

namespace Academy2022_Linq.Examples
{
    public class UsefulMethods
    {
        public static List<Employee> employees = DataGenerator.LoadEmployees();
        public static List<int> listOfNumbers = new List<int> { 10, 5, 25, 30};

        //This method can crash the app when employee not found!
        public static Employee LinqFirstMethod(string employeeName)
        {
            return employees.Where(x => x.Name == employeeName).First();
        }
        //This method will return null when employee not found.
        public static Employee LinqFirstOrDefaultMethod(string employeeName)
        {
            return employees.Where(x => x.Name == employeeName).FirstOrDefault();
        }

        //Select: Let's say we want to return a list of only the company names when a country is given.
        public static List<string> LinqSelectCompanyNames(string country)
        {
            return employees.Where(x => x.Company.Country == country).Select(x => x.Company.Name).ToList(); 
        }
        // Select: Add 5 to the list of numbers above
        public static List<int> LinqSelectAddFive()
        {
            return listOfNumbers.Select(x => { x += 5; return x; }).ToList();
        }

        //Where advantage:
        //Return a list of employees by given CityName no LINQ *** cityName = Richmond
        public static List<Employee> WhereCityNameEqaualNoLinq(string cityName)
        {
            List<Employee> matchedEmployees = new List<Employee>();

            foreach(Employee employee in employees)
            {
                if(employee.Company.City == cityName)
                {
                    matchedEmployees.Add(employee);
                }
            }
            return matchedEmployees;
        }
        //Return a list of employees by given CityName 
        public static List<Employee> WhereCityNameEqaual(string cityName)
        {
            return employees.Where(x => x.Company.City == cityName).ToList();
        }
    }
}
