// explict numeric conversion

namespace csharp_programming {
    class Program
    {
        static void Main()
        {
            float a = 0.0f;
            a = (float)1.23456789;// in c# there is no static cast available.
        }
    }
}

/*
 * Explicit numeric conversion
 * sbyte -> byte, ushort, uint, ulong, or char
 * byte -> Sbyte or char
 * short -> sbyte, byte, ushort, uint, ulong, or char
 * ushort -> sbyte, byte, short, or char
 * int -> sbyte, byte, short, ushort, uint, ulong,or char
 * uint -> sbyte, byte, short, ushort, int, or char
 * long -> sbyte, byte, short, ushort, int, uint, ulong, or char
 * ulong -> sbyte, byte, short, ushort, int, uint, long, or char
 * char -> sbyte, byte, or short
 * float -> sbyte, byte, short, ushort, int, uint, long, ulong, char,or decimal
 * double -> sbyte, byte, short, ushort, int, uint, long, ulong, char, float,or decimal
 * decimal -> sbyte, byte, short, ushort, int, uint, long, ulong, char, float, or double
 */

/*
 * we can not convert boolean to other by implicityly nor explicitly.
 */