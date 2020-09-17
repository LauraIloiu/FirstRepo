using System;
using System.Globalization;

namespace Tema1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercitiu1();
            //Exercitiu2();
            //Exercitiu3();
            //Exercitiu4();
            //Exercitiu5Conditional();
            //Exercitiu5WithoutConditional();
            //Exercitiu6();
            //Exercitiu7();
            //Exercitiu8();
            //Exercitiu9();
            //Exercitiu10();
            //Exercitiu11();
            Exercitiu12();
            //Exercitiu13();
            Exercitiu14();
        }

        static void Exercitiu1()
        {
            int firstNumber = 0, secondNumber = 0, thirdNumber = 0;
            Console.WriteLine("First number: ");
            firstNumber = ReadANumber();
            Console.WriteLine("Second number: ");
            secondNumber = ReadANumber();
            Console.WriteLine("Third number: ");
            thirdNumber = ReadANumber();
            Console.WriteLine("The sum of the three numbers is: " + (firstNumber + secondNumber + thirdNumber));
        }

        static void Exercitiu2()
        {
            int firstNumber = 0, secondNumber = 0, thirdNumber = 0, fourthNumber = 0, fifthNumber = 0;
            Console.WriteLine("First number: ");
            firstNumber = ReadANumber();
            Console.WriteLine("Second number: ");
            secondNumber = ReadANumber();
            Console.WriteLine("Third number: ");
            thirdNumber = ReadANumber();
            Console.WriteLine("Fourth number: ");
            fourthNumber = ReadANumber();
            Console.WriteLine("Fifth number: ");
            fifthNumber = ReadANumber();
            int greatestNumber = firstNumber;
            if (secondNumber > greatestNumber) greatestNumber = secondNumber;
            if (thirdNumber > greatestNumber) greatestNumber = thirdNumber;
            if (fourthNumber > greatestNumber) greatestNumber = fourthNumber;
            if (fifthNumber > greatestNumber) greatestNumber = fifthNumber;
            Console.WriteLine("The greatest number is: " + greatestNumber);
        }

        static void Exercitiu3()
        {
            double radius = 0, circumference = 0, area = 0;
            Console.WriteLine("Enter the radius of a circle: ");
            radius = ReadAPositiveNumber();
            circumference = radius * 2 * Math.PI;
            area = radius * radius * Math.PI;
            Console.WriteLine("The circumference of the circle is: " + circumference);
            Console.WriteLine("The area of the circle is: " + area);
        }

        static void Exercitiu4()
        {
            int firstNumber = 0, secondNumber = 0, aux = 0, numberCount = 0;
            string numbers = "";
            Console.WriteLine("First number: ");
            firstNumber = ReadANumber();
            Console.WriteLine("Second number: ");
            secondNumber = ReadANumber();
            if (firstNumber > secondNumber)
            {
                aux = firstNumber;
                firstNumber = secondNumber;
                secondNumber = aux;
            }
            for (int i = firstNumber; i<= secondNumber; i++)
            {
                if (i % 5 == 0)
                {
                    if (numbers == "") numbers += i;
                    else numbers += ", " + i;
                    numberCount++;
                }
            }
            Console.WriteLine($"There are {numberCount} numbers between {firstNumber} and {secondNumber} that are divisible by 5 and they are: {numbers}");
        }

        static void Exercitiu5Conditional()
        {
            int firstNumber = 0, secondNumber = 0;
            Console.WriteLine("First number: ");
            firstNumber = ReadANumber();
            Console.WriteLine("Second number: ");
            secondNumber = ReadANumber();
            if (firstNumber == secondNumber) Console.WriteLine("The numbers are equal.");
            else
            {
                Console.WriteLine("The greater number is: ");
                if (firstNumber > secondNumber) Console.WriteLine(firstNumber);
                else Console.WriteLine(secondNumber);
            }
        }

        static void Exercitiu5WithoutConditional()
        {
            int firstNumber = 0, secondNumber = 0;
            bool equalNumbers = true;
            while (equalNumbers)
            {
                Console.WriteLine("First number: ");
                firstNumber = ReadAPositiveNumber();
                Console.WriteLine("Second number: ");
                secondNumber = ReadAPositiveNumber();
                if (firstNumber == secondNumber)
                {
                    Console.WriteLine("The numbers are equal, or one of them is negative, please insert other two numbers.");
                }
                else equalNumbers = false;
            }
            Console.WriteLine("The largest number is: " + (firstNumber * ((firstNumber / secondNumber) > 0 ? 1 : 0) + secondNumber * ((secondNumber / firstNumber) > 0 ? 1 : 0)));
        }

        static void Exercitiu6()
        {
            int firstNumber = 0, secondNumber = 0, thirdNumber = 0, fourthNumber = 0, fifthNumber = 0;
            Console.WriteLine("First number: ");
            firstNumber = ReadANumber();
            Console.WriteLine("Second number: ");
            secondNumber = ReadANumber();
            Console.WriteLine("Third number: ");
            thirdNumber = ReadANumber();
            Console.WriteLine("Fourth number: ");
            fourthNumber = ReadANumber();
            Console.WriteLine("Fifth number: ");
            fifthNumber = ReadANumber();
            Console.WriteLine("The sum of the five numbers is: " + (firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber));
        }

        static void Exercitiu7()
        {
            int number = 0;
            Console.WriteLine("Please insert a positive number: ");
            number = ReadAPositiveNumber();
            for (int i = 1; i<= number; i++)
            {
                Console.WriteLine(i + " ");
            }
        }

        static void Exercitiu8()
        {
            int number = 0;
            Console.WriteLine("Please insert a positive number: ");
            number = ReadAPositiveNumber();
            for (int i = 1; i <= number; i++)
            {
                if (!(i % 3 == 0) || !(i % 7 == 0)) Console.WriteLine(i + " ");
            }
        }

        static void Exercitiu9()
        {
            int firstNumber = 0, secondNumber = 0, thirdNumber = 0, fourthNumber = 0, fifthNumber = 0, smallestNumber = 0, greatestNumber = 0;
            Console.WriteLine("First number: ");
            firstNumber = ReadANumber();
            Console.WriteLine("Second number: ");
            secondNumber = ReadANumber();
            Console.WriteLine("Third number: ");
            thirdNumber = ReadANumber();
            Console.WriteLine("Fourth number: ");
            fourthNumber = ReadANumber();
            Console.WriteLine("Fifth number: ");
            fifthNumber = ReadANumber();
            smallestNumber = firstNumber;
            greatestNumber = firstNumber;
            if (secondNumber > greatestNumber) greatestNumber = secondNumber;
            if (secondNumber < smallestNumber) smallestNumber = secondNumber;
            if (thirdNumber > greatestNumber) greatestNumber = thirdNumber;
            if (thirdNumber < smallestNumber) smallestNumber = thirdNumber;
            if (fourthNumber > greatestNumber) greatestNumber = fourthNumber;
            if (fourthNumber < smallestNumber) smallestNumber = fourthNumber;
            if (fifthNumber > greatestNumber) greatestNumber = fifthNumber;
            if (fifthNumber < smallestNumber) smallestNumber = fifthNumber;
            Console.WriteLine($"The smallest number is {smallestNumber} and the greatest number is {greatestNumber}");
        }

        static void Exercitiu10()
        {
            int number = 0;
            string stars;
            Console.WriteLine("Input a positive number: ");
            number = ReadANumber();
            for (int i = 1; i<= number; i++)
            {
                stars = "";
                for (int j = 1; j <= i; j++) stars += "* ";
                Console.WriteLine(stars);
            }
            for (int i = number-1; i > 0; i--)
            {
                stars = "";
                for (int j = 1; j <= i; j++) stars += "* ";
                Console.WriteLine(stars);
            }
        }

        static void Exercitiu11()
        {

        }

        static void Exercitiu12()
        {

        }
        static void Exercitiu13()
        {
            for (int i=1; i<=50; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0) Console.WriteLine("Fizz");
                else if (i % 5 == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(i);
            }
        }
        static void Exercitiu14()
        {

        }

        static int ReadANumber()
        {
            bool isNotNumber = true;
            string consoleRead;
            int number = 0;
            while (isNotNumber)
            {
                consoleRead = Console.ReadLine();
                if (int.TryParse(consoleRead, out number))
                {
                    isNotNumber = false;
                }
                else
                {
                    Console.WriteLine("The previous inserted value was not a number. Please insert a number: ");
                }
            }
            return number;
        }

        static int ReadAPositiveNumber()
        {
            bool isNotNumber = true;
            string consoleRead;
            int number = 0;
            while (isNotNumber)
            {
                consoleRead = Console.ReadLine();
                if (int.TryParse(consoleRead, out number))
                {
                    if (number > 0) isNotNumber = false;
                    else Console.WriteLine("The previous inserted value is not positive. Please insert a positive number: ");
                }
                else
                {
                    Console.WriteLine("The previous inserted value was not a number. Please insert a number: ");
                }
            }
            return number;
        }
    }
}
