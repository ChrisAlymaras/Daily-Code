using System;
using System.Collections.Generic;
using System.Text;

namespace StoreToList
{

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public decimal Afm { get; set; }
        public Person(string firstName,string lastName,int age,decimal afm)
        {
            FirstName = firstName;
            LastName= lastName;
            Age = age;
            Afm = afm;
        }
    }
}
