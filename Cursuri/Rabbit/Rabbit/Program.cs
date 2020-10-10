using System;

namespace Rabbit
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner firstRabitOwner = new Owner("Florin", "Solo", "01", "Romania, bla bla");
            Rabbit firstRabbit = new Rabbit(Eyes.Red, Fur.Black, Gender.Female, new DateTime(1999, 10, 2), firstRabitOwner);
            Console.WriteLine($"Eye color is: {firstRabbit.Eyes}\n" +
                $"Gender is: {firstRabbit.Gender}\n" +
                $"Fur color is: {firstRabbit.Fur}\n" +
                $"Birthday is: {firstRabbit.BirthDay.ToLongDateString()}\n" +
                $"Age is: {firstRabbit.Age}\n" +
                $"Owner is: {firstRabbit.Owner.FullName}\n" +
                $"The address of the owner is: {firstRabbit.Owner.Address}\n" +
                $"The code of the owner is: {firstRabbit.Owner.Code}");
            firstRabbit.Move();
            firstRabbit.Sleep();
            firstRabbit.Eat();

            // var myVar = new Counter() nu merge, deoarece static pe o clasa spune ca nu trebuie instantiat cu new, doar folosit
            var myVar = Counter.TVA;
        }
    }
}
