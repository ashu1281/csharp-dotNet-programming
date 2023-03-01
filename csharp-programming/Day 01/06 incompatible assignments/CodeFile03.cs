namespace csharp_programming {
    class Program {
        static void Main() {
            bool result = false;
            string s = "3.14";

            
            double d = 0.0;
            result = double.TryParse(s, out d);// tryparse take string as a input and if string is looking like number then TryParse convert it into actual number.
                                               // s have "3.14" string so it is stored in d as a double value like  d = 3.14
            
            
            int i = 0;
            result = int.TryParse(s, out i); //here conversion not happend bz i is int type and 3.14 is double
        }
    }
}

/*
 * - If string is not in valid form, TryParse doesn't throw exception.
 */
