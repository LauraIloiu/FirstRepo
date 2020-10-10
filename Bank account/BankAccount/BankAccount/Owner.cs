using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class Owner
    {
        private string firstName;
        private string lastName;
        private readonly ulong cnp;
        private string address;

        public Owner (string firstName, string lastName, ulong cnp, string address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.cnp = cnp;
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

        public ulong CNP
        {
            get { return cnp; }
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
