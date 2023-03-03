namespace csharp_programming {
    class Math {
        public static int Sum(params int[] n) {
            int result = 0;
            foreach(int t in n)
                result += t;
            return result;
        }
    }
    class Program {
        static void Main() {
            int n = Math.Sum(1, 5);
            n = Math.Sum(1, 5, 7);
        }
    }
}