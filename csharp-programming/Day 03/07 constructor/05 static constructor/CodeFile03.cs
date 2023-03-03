namespace csharp_programming {
    class Integer {
        static int value;
        static Integer(int value) { // static constructor cannot be parametric
            Integer.value = value;
        }
    }
    class Program {
        static void Main() {
        }
    }
}

/*
 * Since static constructor cannot be parametric therefore
 * static constructor overloading is not possible.
 */