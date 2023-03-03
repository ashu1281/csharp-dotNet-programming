using System;

namespace csharp_programming {
    class Program {
        static long Factorial(int n) {
            if (n < 0)
                return -1;

            if (n > 10)
                return -2;

            if (1 == n)
                return 1;

            return n * Factorial(n - 1);
        }

        static void Main() {
            long result = 0;
            result = Factorial(4);
            result = Factorial(-4);
            result = Factorial(40);
        }
    }
}
