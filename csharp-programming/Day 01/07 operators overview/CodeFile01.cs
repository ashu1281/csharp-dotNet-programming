namespace csharp_programming {
    class Program {
        static void Main() {
            int a = 1, b = 2, c = 0;

            // arithmetic operators
            c = a + b;  // addition
            c = a - b;	// subtraction
            c = a * b;	// multiplication
            c = a / b;	// division
            c = a % b;	// remainder

            // increment decrement operators
            a = 3; b = 0;
            b = ++a; // preincrement

            a = 3; b = 0;
            b = a++; // postincrement

            a = 3; b = 0;
            b = --a; // predecrement

            a = 3; b = 0;
            b = a--; // postdecrement

            // compound assignment operators
            a = 7; b = 2;
            a += b; // a = a + (b)
            a -= b; // a = a - (b)
            a *= b; // a = a * (b)
            a /= b; // a = a / (b)
            a %= b; // a = a % (b)

            c = 5;
            c *= a + b; // c = c * (a + b)

            // bitwise operators
            a = 0B00010111; b = 0B0101_1100; c = 0;
            c = ~a; //bitwise not
            c = a & b; // " and
            c = a | b; // " or
            c = a ^ b;// " nor
            c = a << 4;// " left shift //here c= 0101110000 => 0001_0111_0000=>368
            c = b >> 3;// " right shift // here c = 0000B0101_1 => 1011 => 11


            // nested assignment
            a = b = c = 5;

            // relational operators
            bool result = false;
            a = 3; b = 4;
            result = a < b; // less than
            result = a > b; // greater than
            result = a != b; // not equal to
            result = a == b; // equal to
            result = a <= b; // less than or equal to
            result = a >= b; // greater than or equal to

            // logical operators
            result = a > 0 && a < 10; // logical and
            result = a < 0 || a > 10; // logical or
            result = !(a < 0 || a > 10); // logical not
        }
    }
}

/*
 * Note logical AND and logical OR are smart operators.
 */