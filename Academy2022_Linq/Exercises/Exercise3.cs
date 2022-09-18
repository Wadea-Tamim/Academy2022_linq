using Academy2022_Linq.Data;
using Academy2022_Linq.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Academy2022_Linq.Exercises
{
    public class Exercise3
    {
        public static List<Employee> employees = DataGenerator.LoadEmployees();
        //Print out the name of employee that works in compant in Belgium as country name and Lakolam as city.

        //outout should be : Myles Palmer
        public static void Exercise3_part1_Solution()
        {
            //Work here :D 
        }

        // using what you did earlier try to use the class EmployeeInfo to create a new employee info using Select and year of employment is 2022
        public static void Exercise3_part2_Solution()
        {
            //Work here :D 
        }
    }


    public class EmployeeInfo
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int YearOfEmployment { get; set; }
    }
}
