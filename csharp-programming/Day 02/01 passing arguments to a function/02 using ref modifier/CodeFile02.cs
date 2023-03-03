using System;

namespace csharp_programming {
    class Program {
        static void Swap(ref int a, ref int b) {
            int c = a;
            a = b;
            b = c;

        }

        static void Main() {
            int a = 1, b = 2;
            Swap(ref a, ref b);//ref on primary dt
        }
    }
}

/*
 * An argument that is passed to a ref parameter must be initialized/assigned before it's passed. 
 * 
 * Within the function, assigning to the ref parameter is optional.
 */