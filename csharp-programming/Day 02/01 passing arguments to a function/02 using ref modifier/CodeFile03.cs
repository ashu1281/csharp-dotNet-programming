namespace csharp_programming {
    class Integer {
        public int value;
    }

    class Program {
        static void F(ref Integer u) {
            u.value = 5;
        }

        static void G(ref Integer v) {
            v = new Integer() { value = 10 };
        }

        static void Main() {
            Integer a = new Integer() { value = 1 };//ref on udt
            F(ref a);
            G(ref a);
        }
    }
}

/*
 * Using ref with reference type.
 */