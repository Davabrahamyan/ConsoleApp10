using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public string city;
        public string state;
        public string country;
        public bool IsEmployed;
        public bool IsFemale;
        public int weight;
        public bool Isunderaged;

        
        public string FullName(string firstName,string lastName)
        {
            return firstName + "" + lastName;
        }
    }
}
