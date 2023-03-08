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
        static int value = 0;
        public static int GetNumber() { // class method
            int retval = value;
            value += 2;
            return retval;
        }
    }

    class OddNumberGenerator {
        static int value = 1;
        public static int GetNumber() { // class method
            int retval = value;
            value += 2;
            return retval;
        }
    }

    class Program {
        static void Main() {
            int[] a = new int[5];
            // method #1
            Algorithm.Generator gen = new Algorithm.Generator(OddNumberGenerator.GetNumber);
            Algorithm.Generate(a, gen);
            // method #2
            Algorithm.Generate(a, EvenNumberGenerator.GetNumber); // line 34& 37 both are same syntax.
        }
    }
}
