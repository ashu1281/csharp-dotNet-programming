using System;

namespace csharp_programming {
    internal class Program {
        public static void Main(string[] args) {
            object a = 1; //boxing
            int i = (int)a; //unboxing
            i = i + 5;
        }
    }
}


/*
 * Unboxing is explicit.
 * An unboxing operation involves determining whether the boxed value
 * is of the specified value type and, if so, copying the value from
 * the instance into the value-type variable. 
 * As a result, boxing and unboxing are thought to be computationally
 * expensive processes. 
 */

