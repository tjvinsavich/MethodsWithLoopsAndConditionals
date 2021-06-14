using System;
using System.Threading;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {

            //TODO: go back to methods and see where TryParse can be implemented for error checking

            //introduction
            Console.WriteLine("Welcome to the program! We're gonna do a bunch of stuff today.");
            Thread.Sleep(1000);
            Console.WriteLine("Brace yourself :)");
            Thread.Sleep(1000);

            //game section
            printThousands();

            printByThree();

            intsEqual();

            isEvenOrOdd();

            plusOrMinus();

            canVote();

            inRange();

            multiTable();

            //conclusion
            Console.WriteLine("Haha! Thanks for playing with me!");
            Thread.Sleep(3000);
            Console.WriteLine(".");
            Thread.Sleep(1000);
            Console.WriteLine("..");
            Thread.Sleep(1000);
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.WriteLine("Will we still be friends after all of this?");
            Thread.Sleep(3000);
            Console.WriteLine(":)");
            Thread.Sleep(3000);
            Console.WriteLine("Nevermind! I'm sure we'll see eachother again soon!");
            Thread.Sleep(2000);
            Console.WriteLine("I'll be here til then, okay?");
            Thread.Sleep(1000);

        }

        //a method that will print to the console all numbers 1000 through -1000
        public static void printThousands()
        {
            Console.WriteLine("Here come all numbers 1000 through -1000!");
            Thread.Sleep(1000);

            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

            Thread.Sleep(1000);
        }

        //a method that will print to the console numbers 3 through 999 by 3 each time
        public static void printByThree()
        {
            Console.WriteLine("Now we're gonna go from 3 to 999 but go by 3 each time!");
            Thread.Sleep(1000);

            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }

            Thread.Sleep(1000);
        }

        //a method to accept two integers as parameters and check whether they are equal or not
        public static void intsEqual()
        {
            Console.WriteLine("Okay, now give me 2 integers and I'll tell you if they are equal or not!");
            Thread.Sleep(1000);

            Console.WriteLine("First one...");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Second one...");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Nice! These integers are equal!");
            }
            else
            {
                Console.WriteLine("Sorry! Those integers aren't equal at all!");
            }

            Thread.Sleep(1000);
        }

        //a method to check whether a given number is even or odd
        public static void isEvenOrOdd()
        {
            Console.WriteLine("Alright! Gimme another integer, and I'll tell you if it's even or odd!");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is even!");
            }
            else
            {
                Console.WriteLine($"{num} is odd!");
            }

            Thread.Sleep(1000);
        }

        //a method to check whether a given number is positive or negative
        public static void plusOrMinus()
        {
            Console.WriteLine("Well done! Now give me another and I'll tell you if it's positive or negative!");
            int num = int.Parse(Console.ReadLine());

            if(num > 0)
            {
                Console.WriteLine($"{num} is positive!");
            }
            else if(num < 0)
            {
                Console.WriteLine($"{num} is negative!");
            }
            else
            {
                Console.WriteLine($"Ooo! Nice try. Zero is zero, what can I say.");
            }

            Thread.Sleep(1000);
        }

        //a method to read the age of a candidate and determine whether they can vote
        public static void canVote()
        {
            Console.WriteLine("You're doing great! Wanna know whether someone is old enough to vote (USA)? Type in an age next!");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine($"If someone is {age}, they can definitely vote!");
            }
            else
            {
                Console.WriteLine($"Unfortunately, if someone is {age}, they won't be able to vote :(");
            }

            Thread.Sleep(1000);

        }

        //a method to check if an integer (from the user) is in the range -10 to 10
        public static void inRange()
        {
            Console.WriteLine("Okay, gimme another integer and I'll tell you if it's in the range -10 to 10!");
            int num = int.Parse(Console.ReadLine());

            if (num >= -10 && num <= 10)
            {
                Console.WriteLine($"Yes! {num} is in the range -10 to 10!");
            }
            else
            {
                Console.WriteLine($"Nope! {num} is not in the range -10 to 10!");
            }

            Thread.Sleep(1000);
        }

        //a method to display the multiplication table(from 1 to 12) of a given integer
        public static void multiTable()
        {
            Console.WriteLine("One more time! Give me an integer and I'll give it's multiplication table from 1 to 12!");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num} times {i} is {num * i}");
            }

            Thread.Sleep(1000);
        }

    }
}
