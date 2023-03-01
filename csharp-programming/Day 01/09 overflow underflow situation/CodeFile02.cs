namespace csharp_programming {
    class Program {
        static void Main() {
            sbyte a = 0, b = 0;

            checked { // checked operator will check overflow and underflow , it throws exception
                a = 127;
                b = ++a; // overflow

                a = -128;
                b = --a; // underflow
            }
        }
    }
}

/*
 * For project-wide checked setting click
 * Project > Properties > Build > Advanced > Check for arithmetic overflow/underflow
 */
