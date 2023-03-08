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

    class EvenNumberGenerator {
        int value = 0;
        public int GetNumber() { // instance method
            int retval = value;
            value += 2;
            return retval;
        }
    }

    class OddNumberGenerator {
        static int value = 1;
        public int GetNumber() { // instance method
            int retval = value;
            value += 2;
            return retval;
        }
    }

    class Program {
        static void Main() {
            int[] a = new int[5];
            // method #1
            OddNumberGenerator oddNumberGenerator = new OddNumberGenerator();
            Algorithm.Generator gen = new Algorithm.Generator(oddNumberGenerator.GetNumber);
            Algorithm.Generate(a, gen);
            // method #2
            EvenNumberGenerator evenNumberGenerator = new EvenNumberGenerator();
            Algorithm.Generate(a, evenNumberGenerator.GetNumber);
        }
    }
}
