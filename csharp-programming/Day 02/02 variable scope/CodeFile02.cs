using System;

namespace csharp_programming {
    class Program {
        static void Main() {
            int j = 20;
            for (int i = 0; i < 10; i++) {
                int j = 30; // Can't do this — j is still in scope
                Console.WriteLine(j + i);
            }
        }
    }
}