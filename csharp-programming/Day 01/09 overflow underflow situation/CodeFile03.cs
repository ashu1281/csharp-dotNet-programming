namespace csharp_programming {
    class Program {
        static void Main() {
            sbyte a = 0, b = 0;

            unchecked {
                a = 127;
                b = ++a; // overflow

                a = -128;
                b = --a; // underflow
            }
        }
    }
}
