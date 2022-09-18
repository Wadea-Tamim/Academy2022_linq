using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace Academy2022_Linq.Examples
{
    public class LinqToXML
    {
        public static void ReadFromXML()
        {
            XDocument xml = XDocument.Load("../../../Examples/people.xml");

            var filteredPerson = xml.Descendants("Person").Where(x => x.Attribute("Email").Value == "adowd1@bloomberg.com").FirstOrDefault();
            var name = filteredPerson.Element("FirstName").Value;
            
            Console.WriteLine(name);
        }

        //We can argue that we should have used SingOrDefault because email is unique.
    }
}
