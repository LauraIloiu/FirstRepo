using System;
using System.Collections.Generic;
using System.Text;

namespace Rabbit
{
    class Owner
    {
        private string firstName;
        private string lastName;
        private readonly string code;
        private string address;

        public Owner(string firstName, string lastName, string code, string address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.code = code;
            this.address = address;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Code
        {
            get { return code; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string FullName
        {
            get { return firstName + " " + lastName; }
        }
    }
}
