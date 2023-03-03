using System;

namespace csharp_programming {
    class Program {
        static int Add(int a = 0, int b = 0, int c = 0) {
            int result = 0;
            result = a + b + c;
            return result;
        }

        static void Main() {
            int result = 0;
            result = Add(78, 97);
            result = Add(, , 50); // syntax not supported
        }
    }
}

/*
 * If far optional parameter is to be given particular value,
 * then all in between parameters must be given values.
 */