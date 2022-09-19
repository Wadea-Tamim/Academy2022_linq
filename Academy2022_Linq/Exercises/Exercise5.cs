using Academy2022_Linq.Data;
using Academy2022_Linq.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Academy2022_Linq.Exercises
{
    public class Exercise5
    {
        public static List<Employee> employees = DataGenerator.LoadEmployees();

        //Use the list of employees to group them by the country of their company
        //Then Print the country name is the key and the employees names.
        public static void Exercise5_Solution()
        {
            var result = employees.GroupBy(emp => emp.Company.Country, emp => emp.Name);
            foreach (var res in result)
            {
                Console.WriteLine("Country of company: " + res.Key);
                foreach (var emp in res)
                {
                    Console.WriteLine("Employee name: " + emp);
                }
            }
        }
    }
}
