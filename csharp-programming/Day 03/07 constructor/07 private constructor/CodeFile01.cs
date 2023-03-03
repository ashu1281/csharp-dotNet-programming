namespace csharp_programming {
    class Integer {
        int value;
        private Integer() {
            value = 1;
        }
    }
    class Program {
        static void Main() {
            Integer i = new Integer(); // cannot instatiate
        }
    }
}

/*
 * A class with private constructor(s) cannot be instantiated.
 */