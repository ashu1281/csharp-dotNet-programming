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
            // result = Add(, , 50); // Error
            result = Add(c:50); // OK
        }
    }
}

/*
 * Named parameters provides us the relaxation to remember or to look up the order of parameters
 * in the parameter lists of called methods given by api designer.
 * 
 * 
 * The parameter for each argument can be specified by parameter name.
 */