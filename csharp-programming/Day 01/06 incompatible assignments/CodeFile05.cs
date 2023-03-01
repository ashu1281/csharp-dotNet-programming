using System;

namespace csharp_programming {
    class Program {
        static void Main() {
            string s = "3.14";
            double d = Convert.ToDouble(s);
            int i = Convert.ToInt32(s); // Exception
            i = Convert.ToInt32(3.14); // OK
        }
    }
}

/*
 * - If string is not in valid form, Convert throws FormatException.
 */
