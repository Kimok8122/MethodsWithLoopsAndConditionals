using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method that will print to the console all numbers 1000 through -1000.

            var starting1000 = 1001;

            do
            {
                starting1000 = --starting1000;
              
                Console.WriteLine("Decrease by 1:");
                Console.WriteLine(starting1000);

            } while (starting1000 >= -999);

            Console.WriteLine("");

            // Write a method that will print to the console numbers 3 through 999 by 3 each time.

            var starting3 = 3;

            do
            {
                starting3 = starting3 + 3;

                Console.WriteLine("Increase by 3:");
                Console.WriteLine(starting3);

            } while (starting3 <= 999);

        }
    }
}
