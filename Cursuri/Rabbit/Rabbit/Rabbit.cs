using System;
using System.Collections.Generic;
using System.Text;

namespace Rabbit
{
    class Rabbit
    {
        private readonly Eyes eyes;
        private readonly Fur fur;
        private readonly Gender gender;
        private readonly DateTime birthDay;
        private Owner owner;

        public Rabbit(Eyes eyes, Fur fur, Gender gender, DateTime birthDay, Owner owner)
        {
            this.eyes = eyes;
            this.fur = fur;
            this.gender = gender;
            this.birthDay = birthDay;
            this.owner = owner;
        }

        public Eyes Eyes
        {
            get { return eyes; }
        }
        public Fur Fur
        {
            get { return fur; }
        }
        public Gender Gender
        {
            get { return gender; }
        }

        public DateTime BirthDay
        {
            get { return birthDay; }
        }

        public Owner Owner
        {
            get { return owner; }
        }
        public int Age
        {
            get { return (int)DateTime.Now.Year - birthDay.Year; }
        }

        public void Move()
        {
            Console.WriteLine("The rabbit is moving.");
        }

        public void Sleep()
        {
            Console.WriteLine("The rabbit is sleeping.");
        }

        public void Eat()
        {
            Console.WriteLine("The rabbit is eating.");
        }
    }

    public enum Eyes
    {
        Blue,
        Red,
        Black
    }

    public enum Fur
    {
        White,
        Brown,
        Black,
        Grey
    }

    public enum Gender
    {
        Male,
        Female
    }
}
