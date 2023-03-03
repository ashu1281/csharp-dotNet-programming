namespace csharp_programming {
    class Integer {
        public int value;
    }

    class Program {
        static void F(out Integer u)
        {
            u.value = 5;
        }

        static void G(out Integer v) {
            v = new Integer() { value = 10 };
        }

        static void Main() {
            Integer a;// = new Integer() { value = 1 };
            F(out a);
            G(out a);
        }
    }
}
