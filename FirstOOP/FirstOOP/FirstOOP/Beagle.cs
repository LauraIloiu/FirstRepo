using System;
using System.Collections.Generic;
using System.Text;

namespace FirstOOP
{
    public class Beagle : Dog, IRun
    {
        public Beagle(string name, string trick) : base(name)
        {
            Console.WriteLine("Constructor Beagle");
        }
        public void Hunt()
        {
            Console.WriteLine($"{Breed}");
            Console.WriteLine("I hunt");
        }

        public new void Bark()
        {
            Console.WriteLine("I am Beagle and I bark");
        }

        public void Run()
        {
            Console.WriteLine("I run, from Run method");
        }
    }
}
