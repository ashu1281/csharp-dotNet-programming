namespace csharp_programming {

    [Flags]
    enum Color {
        None = 0,
        Red = 1,
        Green = 2,
        Blue = 4
    }

    class Program {
        static void Main() {
            var yellowColor = Color.Red | Color.Green;
            
            Console.WriteLine(yellowColor);

            bool hasNone = yellowColor == Color.None;
            bool hasRed = yellowColor.HasFlag(Color.Red);
            bool hasGreen = yellowColor.HasFlag(Color.Green);
            bool hasBluew = yellowColor.HasFlag(Color.Blue);
        }
    }
}

/*
 * The [Flags] attribute should be used whenever the enumerable represents
 * a collection of possible values, rather than a single value.
 * Such collections are often used with bitwise operators.
 * When applied [Flags] it allows nice representation by the .ToString() method.
 * It is also important to note that [Flags] does not automatically make the
 * enum values powers of two.
 * About usage of None enumerated constant:
 * You cannot use the None enumerated constant in a bitwise AND, the result is always zero.
 * However, you can perform a logical comparison to determine whether any bits in the numeric
 * value are set.
 
 * Always use bitwise operators instead of logical operators to check the combination value assign or not.
 * 
 * for only to check none assignment happens or not then we use here only logical comparision operator bz bitwiese and gives always false with null,
 * so
 */
