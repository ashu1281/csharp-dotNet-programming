namespace csharp_programming {
    class Program {
        class Integer {
            public int value;
        }

        static void Add(Integer a, Integer b, ref Integer result) {
            result = new Integer { value = a.value + b.value };
        }

        static void Add(Integer a, Integer b, out Integer result) {
            result = new Integer { value = a.value + b.value };
        }

        static void Main() {
            Integer i = new Integer() { value = 1 };
            Integer j = new Integer() { value = 2 };
            Integer k = new Integer() { value = 0 };
            Add(i, j, out k);

            Integer u = new Integer() { value = 1 };
            Integer v = new Integer() { value = 2 };
            Integer w = new Integer() { value = 0 };
            Add(u, v, ref w);
        }
    }
}

/*
 * Function overloading cannot happen between ref, in and out parameters.
 */
