using System;

namespace csharp_programming {
    class Program {
        static void Main() {
            string input;

            Console.Write("Enter first integer: ");
            input = Console.ReadLine();
            int a = Convert.ToInt32(input);

            Console.Write("Enter second integer: ");
            input = Console.ReadLine();
            int b = Convert.ToInt32(input);

            int max = 0;

            if (a > b)
                max = a;
            else
                max = b;

            Console.WriteLine("{0} is the maximum integer.", max);
        }
    }
}