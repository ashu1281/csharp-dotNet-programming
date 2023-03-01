namespace csharp_programming {
    class Program {
        static void Main() {
            string s = "3.14";
            double d = double.Parse(s);
            int i = int.Parse(s);//this line throws exception bz string have not suitable type
        }
    }
}

/*
 * - If string is not in valid form, Parse throws FormatException.
 */
