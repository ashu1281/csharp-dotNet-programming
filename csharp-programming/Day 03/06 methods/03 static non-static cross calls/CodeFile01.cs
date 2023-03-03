namespace csharp_programming {
    class Math {
        public int Sum(params int[] n) {
            int result = 0;
            foreach(int t in n)
                result += t;
            return result;
        }

        // instance method calling another instance method
        public double Avg(params int[] n) {
            double result = (double)Sum(n) / n.Length;
            return result;
        }
    }
    class Program {
        static void Main() {
            Math m = new Math();
            double n = m.Avg(1, 5);
            n = m.Avg(1, 5, 7);
        }
    }
}