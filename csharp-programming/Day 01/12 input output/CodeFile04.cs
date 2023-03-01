using System;

namespace csharp_programming {
    class Program {
        static void Main() {
            double d = 0.234;
            Console.WriteLine("{0:#.00}", d);
            Console.WriteLine("{0:000000.0000}", d);
            Console.WriteLine("{0:###000.0000}", d);
        }
    }
}

/*
 * Refer https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-numeric-format-strings
 * for custom numeric format strings.
 */