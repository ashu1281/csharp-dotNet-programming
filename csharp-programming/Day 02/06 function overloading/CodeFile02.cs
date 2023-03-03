namespace csharp_programming {
    class Program {
        class Integer {
            public int value;
        }

        static void Add(Integer a, Integer b, Integer result) {
            result.value = a.value + b.value;
        }

        static void Add(Integer a, Integer b, out Integer result) {
            result = new Integer { value = a.value + b.value };
        }

        static void Main() {
            Integer i = new Integer() { value = 1 };
            Integer j = new Integer() { value = 2 };
            Integer k = new Integer() { value = 0 };
            Add(i, j, k);

            Integer u = new Integer() { value = 1 };
            Integer v = new Integer() { value = 2 };
            Integer w = null;
            Add(u, v, out w);
        }
    }
}

/*
 * Function overloading happens between by value and by out parameter
 */