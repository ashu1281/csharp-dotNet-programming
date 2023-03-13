using System;

namespace csharp_programming {
    internal class Program {
        public static void Main(string[] args) {
            object a = 1; //boxing

            int i = 5;

            object b = i;

            i += 10;// Note the value contained in the box didn't change.
        }
    }
}

/*
 * When the CLR boxes a value type, it wraps the value inside a System.Object 
 * and stores it on the managed heap.
 * Boxing is implicit.
 */

