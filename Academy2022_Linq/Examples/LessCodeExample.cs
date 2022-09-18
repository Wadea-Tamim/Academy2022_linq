using System;
using System.Collections.Generic;
using System.Linq;

namespace Academy2022_Linq.Examples
{
    public class LessCodeExample
    {
        public class Child
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        public static List<Child> children = new List<Child> { new Child { Name="Alex", Age=13 },
                   new Child { Name="Mike", Age=7 },
                   new Child { Name="Nathan", Age=5 } };

        public static void OrderByLinqExample()
        {
            

            children = children.OrderBy(pet => pet.Age).ToList();

            foreach (Child child in children)
            {
                Console.WriteLine("{0} - {1}", child.Name, child.Age);
            }
        }

        public static void OrderByWithoutLinq()
        {
            children.Sort(delegate (Child ch1, Child ch2)
            {
                return ch1.Age.CompareTo(ch2.Age);
            });

            foreach (Child child in children)
            {
                Console.WriteLine("{0} - {1}", child.Name, child.Age);
            }
        }
    }
}
