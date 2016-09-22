using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }
        public bool IsCool { get; }

        public Person(string firstName, string lastName, int age, bool isCool)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            IsCool = isCool;
        }

    }

    
}
