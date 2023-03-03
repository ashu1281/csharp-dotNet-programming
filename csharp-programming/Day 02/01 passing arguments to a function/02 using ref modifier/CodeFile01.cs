using System;

namespace csharp_programming {
    class Program {
        static void Swap(int a, int b) {
            int c = a;
            a = b;
            b = c;
        }

        static void Main() {
            int a = 1, b = 2;
            Swap(a, b);
        }
    }
}
