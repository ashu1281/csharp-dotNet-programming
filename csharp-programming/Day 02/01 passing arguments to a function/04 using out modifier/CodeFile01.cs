using System;

namespace csharp_programming {
    class Program {
        static void Add(int a, int b, out int result) {
            result = a + b;
        }

        static void Main() {
            int u = 1, v = 2, result = 0;
            Add(u, v, out result);
            Console.WriteLine($"Sum of {u} and {v} is {result}");
        }
    }
}

/*
 * The out keyword causes arguments to be passed by reference.
 * Variables passed as out arguments do not have to be initialized before being passed in a method call.
 * However, the called method is required to assign a value before the method returns.
 */