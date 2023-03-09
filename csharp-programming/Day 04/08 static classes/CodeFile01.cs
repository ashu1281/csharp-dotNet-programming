namespace csharp_programming {
    static class Algorithm {
        public static int Min(int[] a) {
            if (a is null)
                throw new NullReferenceException();
            int length = a.Length;
            int min = a[0];
            for(int i = 1; i < length; i++) {
                if (a[i] < min)
                    min = a[i];
            }
            return min;
        }

        public static int Max(int[] a) {
            if (a is null)
                throw new NullReferenceException();
            int length = a.Length;
            int max = a[0];
            for (int i = 1; i < length; i++) {
                if (a[i] > max)
                    max = a[i];
            }
            return max;
        }
    }

    class Program {
        static void Main() {
            int[] a = new int[5] { 1, 6, 3, 2, 6 };
            int result = Algorithm.Min(a);
            Console.WriteLine(result);

            result = Algorithm.Max(a);
            Console.WriteLine(result);
        }
    }
}
