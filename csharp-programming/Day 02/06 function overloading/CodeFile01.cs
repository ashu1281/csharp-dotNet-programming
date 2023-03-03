namespace csharp_programming {
    class Program {
        class Integer {
            public int value;
        }

        class Real {
            public double value;
        }

        static void Add(Integer a, Integer b, Integer result) {
            result.value = a.value + b.value;
        }

        static void Add(Real a, Real b, Real result) {
            result.value = a.value + b.value;
        }

        static void Main() {
            Integer i = new Integer() { value = 1 };
            Integer j = new Integer() { value = 2 };
            Integer k = new Integer() { value = 0 };
            Add(i, j, k);

            Real u = new Real() { value = 1.0 };
            Real v = new Real() { value = 2.0 };
            Real w = new Real() { value = 0.0 };
            Add(u, v, w);
        }
    }
}