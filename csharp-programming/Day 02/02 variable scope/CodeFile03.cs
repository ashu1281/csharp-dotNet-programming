using System;

namespace csharp_programming {
    class Program {
        static int a;

        static void F() {
            a = 1;
        }

        static void Main() {
            F();
            Console.WriteLine(a);
        }
    }
}

/*
 * Class/instance wide variables are accessible across member functions.
 */