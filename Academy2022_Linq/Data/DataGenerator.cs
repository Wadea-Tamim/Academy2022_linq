using Academy2022_Linq.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy2022_Linq.Data
{
    public class DataGenerator
    {
        public static List<Employee> LoadEmployees()
        {
            var employees = new List<Employee> { new Employee
            {
                Name = "Wesley Dyer",
                Email= "rutrum.fusce@aol.net",
                Company = new Company
                {
                    Name = "Sed Dui Corp.",
                    Country = "New Zealand",
                    City = "Richmond"

                }
            },
            new Employee
            {
                Name = "Ethan Gibbs",
                Email= "at.auctor@hotmail.co",
                Company = new Company
                {
                    Name = "Sed Dui Corp.",
                    Country = "New Zealand",
                    City = "Richmond"

                }
            },
            new Employee
            {
                Name = "Avram Pruitt",
                Email= "varius.ultrices@outlook.couk",
                Company = new Company
                {
                    Name = "Neque Inc.",
                    Country = "Belgium",
                    City = "Rivire"

                }
            },
            new Employee
            {
                Name = "Myles Palmer",
                Email= "egestas.blandit@aol.couk",
                Company = new Company
                {
                    Name = "Hendrerit A Arcu PC",
                    Country = "Belgium",
                    City = "Lakolam"

                }
            },
            new Employee
            {
                Name = "Shelby Wilkins",
                Email= "et.libero.proin@yahoo.org",
                Company = new Company
                {
                    Name = "Enim Company",
                    Country = "Nigeria",
                    City = "Barrhead"

                }
            },
            new Employee
            {
                Name = "Demetrius Levine",
                Email= "amet@outlook.ca",
                Company = new Company
                {
                    Name = "Penatibus Inc.",
                    Country = "Austria",
                    City = "Lillehammer"

                }
            },
            new Employee
            {
                Name = "Yoshi Bruce",
                Email= "consectetuer@yahoo.ca",
                Company = new Company
                {
                    Name = "Penatibus Inc.",
                    Country = "Philippines",
                    City = "Rae Bareli"

                }
            },
            new Employee
            {
                Name = "Hammett Stout",
                Email= "eu.tellus@google.couk",
                Company = new Company
                {
                    Name = "Penatibus Inc.",
                    Country = "Ireland",
                    City = "Pinneberg"

                }
            },
            new Employee
            {
                Name = "Keefe Heath",
                Email= "nunc.pulvinar@protonmail.ca",
                Company = new Company
                {
                    Name = "A Corporation",
                    Country = "United States",
                    City = "Westport"

                }
            },
            new Employee
            {
                Name = "Mohammad Barron",
                Email= "dapibus.rutrum@hotmail.edu",
                Company = new Company
                {
                    Name = "Luctus Felis Limited",
                    Country = "Turkey",
                    City = "Windsor"

                }
            }
            };
            return employees;
        }
    }
}
