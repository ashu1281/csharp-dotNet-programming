namespace csharp_programming {
    class Math {
        public int Sum(params int[] n) {
            int result = 0;
            foreach(int t in n)
                result += t;
            return result;
        }

        // class method calling instance method
        public static double Avg(params int[] n) {
            double result = (double)Sum(n) / n.Length;
            return result;
        }
    }
    class Program {
        static void Main() {
            double n = Math.Avg(1, 5);
            n = Math.Avg(1, 5, 7);
        }
    }
}