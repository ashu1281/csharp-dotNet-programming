﻿using System;

namespace csharp_programming {
    class Program {
        static int Add(int a, int b = 0) {
            int c = 0;
            c = a + b;
            return c;
        }

        static void Main() {
            int result = 0;
            result = Add(78, 97);
            result = Add(50);
        }
    }
}