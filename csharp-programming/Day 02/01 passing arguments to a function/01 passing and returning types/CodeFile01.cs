using System;

namespace csharp_programming {
    class Program {
        static int Add(int a, int b) {
            int c = 0;
            c = a + b;
            return c;
        }

        static void Main() {
            int u = 1, v = 2;
            int result = Add(u, v);
            Console.WriteLine($"Sum of {u} and {v} is {result}");
        }
    }
}
