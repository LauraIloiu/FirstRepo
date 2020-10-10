using System;

namespace FirstOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Grivei");
            myDog.Bark();

            Beagle myBeagle = new Beagle("Max", "fetch");

            IRun human = new Human();
            human = myBeagle;
        }
    }
}
