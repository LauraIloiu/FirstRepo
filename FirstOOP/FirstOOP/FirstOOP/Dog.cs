using System;
using System.Collections.Generic;
using System.Text;

namespace FirstOOP
{
    public class Dog
    {
        public Dog(string name)
        {
            Name = name;
            Console.WriteLine("Constructor Dog");
        }
        public string Name { get; set; }

        protected string Breed { get; set; }

        public void Bark()
        {
            Console.WriteLine($"My breed is {Breed}");
            Console.WriteLine($"I am {Name} and I bark");
        }
    }
}
