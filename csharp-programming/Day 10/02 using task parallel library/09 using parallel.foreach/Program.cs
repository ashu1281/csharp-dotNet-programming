namespace csharp_programming {
    internal class Program {
        public static void Main(string[] args) {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            Parallel.ForEach(numbers, (number) =>
            {
                // Perform some computation on each number
                Console.WriteLine($"Computation of {number} started.");
                int result = Compute(number);
                Console.WriteLine($"Factorial of {number} is {result}");
            });
        }

        private static int Compute(int number) {
            int result = 1;
            for (int i = 2; i <= number; i ++)
                result = result * i;
            return result;
        }
    }
}

/*
 * General syntax of Parallel.ForEach is
 * Parallel.ForEach(source, options, (item, state) =>
 * {
 *    // body of the loop
 * });
 */
