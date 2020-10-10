using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate an object
            Person myPerson = new Person("Gigi", "Dev");
            var name = myPerson.FirstName;

            Console.WriteLine("Hello World!");
        }
    }
}
