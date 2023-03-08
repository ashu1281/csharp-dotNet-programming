namespace csharp_programming {
    static class Algorithm {
        public delegate int Generator();

        public static void Generate(int[] a, Generator gen) {
            int length = a.Length;
            for (int i = 0; i < length; i++) {
                a[i] = gen();
            }
        }
    }

    class Program {
        static void Main() {
            int[] a = new int[5];
            Random random = new Random();
            Algorithm.Generator gen = delegate () { return random.Next() % 10; };
            Algorithm.Generate(a, gen);
        }
    }
}