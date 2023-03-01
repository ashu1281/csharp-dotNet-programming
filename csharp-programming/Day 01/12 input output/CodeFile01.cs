using System;

namespace csharp_programming {
    class Program {
        static void Main() {
            string input;

            Console.Write("Enter first number: ");
            input = Console.ReadLine();
            int a = Convert.ToInt32(input);

            Console.Write("Enter second number: ");
            input = Console.ReadLine();
            int b = Convert.ToInt32(input);

            int c = 0;
            c = a + b;

            Console.WriteLine("Sum of {0} and {1} is {2}", a, b, c);
        }
    }
}

/*
 * Note variable can be defined anywhere in the scope.
 */