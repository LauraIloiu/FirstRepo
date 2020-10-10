using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Person
    {
        public string firstName;
        private string lastName;
        private readonly DateTime birthDate;

        public string FirstName 
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public Person(string first, string last)
        {
            firstName = first;
            lastName = last;
        }

        public enum Gender
        {
            Male,
            Female
        }
    }
}
