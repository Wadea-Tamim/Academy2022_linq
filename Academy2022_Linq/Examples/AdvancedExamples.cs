using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Academy2022_Linq.Examples
{
    public class AdvancedExamples
    {
        public class Child
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public static List<Child> children = new List<Child> { 
            new Child { Name="Alex", Age=7 },
            new Child { Name="Mike", Age=7 },
            new Child { Name="Nathan", Age=5 },
            new Child { Name="Magnus", Age=5 },
            new Child { Name="Anders", Age=5 },
            new Child { Name="Kal", Age=4 },
        };
        

        public static void GroupByExample()
        {
            var result = children.GroupBy(child => child.Age, child => child.Name);

            foreach(var res in result)
            {
                Console.WriteLine("Age group: " + res.Key);
                foreach(var childName in res)
                {
                    Console.WriteLine("child Name: " + childName);
                }
            }
        }

        public static void AggregateExample()
        {
            //This is use to collect to values and determine what is minimum age in the list.
            var minAge = children.Aggregate(5, (younger, next) => next.Age < younger ? next.Age : younger);
            Console.WriteLine(minAge);
        }


    }
}
