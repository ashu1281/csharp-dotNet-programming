using System;

namespace csharp_programming {
    class Program {
        static void Print(in int value) {
            Console.WriteLine(value);
        }

        static void Main() {
            int u = 1;
            Print(u);
        }
    }
}

/*
 * Variables passed as in arguments must be initialized before being passed in a method call.
 * The called method can not assign a value or modify the argument.
 */