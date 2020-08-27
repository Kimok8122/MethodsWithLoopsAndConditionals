using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Exersice 1: ");

            Print1000Range();
            Console.WriteLine("");

            Console.WriteLine("Exersice 2: ");

            Print3Range();
            Console.WriteLine("");

            Console.WriteLine("Exersice 3: ");

            CheckIfEqualOrNot();
            Console.WriteLine("");

            Console.WriteLine("Exersice 4:");

            EvenOrOdd();
            Console.WriteLine("");

            Console.WriteLine("DONE");

        }


        // Write a method that will print to the console all numbers 1000 through -1000.

        public static void Print1000Range()
        {

            var starting1000 = 1001;

            do
            {
                starting1000 = --starting1000;

                Console.WriteLine("Decrease by 1:");
                Console.WriteLine(starting1000);

            } while (starting1000 >= -999);

        }

        // Write a method that will print to the console numbers 3 through 999 by 3 each time.

        public static void Print3Range()
        {
            var starting3 = 3;

            do
            {
                starting3 = starting3 + 3;

                Console.WriteLine("Increase by 3:");
                Console.WriteLine(starting3);

            } while (starting3 <= 999);


       // Class way --------------------------------

            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }

        }

        // Write a method to accept two integers as parameters and check whether they are equal or not.

        public static bool CheckIfEqualOrNot()
        {
            Console.WriteLine($"Give me a number:");
            var num1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Give me another number:");
            var num2 = int.Parse(Console.ReadLine());

            if (num1 != num2)
            {
                Console.WriteLine($"This are not the same number.");
                return false;
            }
            else
            {
                Console.WriteLine($"This is the same numbers.");
                return true;
            }


        }
        //Write a method to check whether a given number is even or odd.

        public static void EvenOrOdd()
        {
            Console.WriteLine($"Give me a number:");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput % 2 == 0)
            {
                Console.WriteLine($"That's so even!");
            }
            else
            {
                Console.WriteLine($"Hella odd number!");
            }
                
        }
    }
}
    
    


