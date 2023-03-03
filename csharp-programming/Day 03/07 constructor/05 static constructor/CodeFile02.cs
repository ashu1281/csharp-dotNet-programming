namespace csharp_programming {
    class Integer {
        static int value;
        public static Integer() { // access specifier not allowed on static constructor
            value = 1;
        }
    }
    class Program {
        static void Main() {
        }
    }
}