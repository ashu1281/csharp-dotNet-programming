namespace csharp_programming {
    class Integer {
        public int value;
    }

    class Program {
        static void F(in Integer u) {
            u.value = 5;
        }

        static void G(in Integer v) {
            v = new Integer() { value = 10 };
        }

        static void Main() {
            Integer a = new Integer() { value = 1 };
            F(a);
            G(a);
        }
    }
}
