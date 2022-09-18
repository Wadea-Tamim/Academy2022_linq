using System;
using System.Collections.Generic;
using System.Text;

namespace Academy2022_Linq.Data.Model
{
    public class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Company Company { get; set; }
    }
}
