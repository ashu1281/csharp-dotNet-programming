namespace csharp_programming {
    internal class Program {
        public static void Main(string[] args) {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int searchValue = 5;
            int index = -1;

            Parallel.For(0, array.Length, (i, loopState) =>
            {
                Console.WriteLine($"{i} iteration started");
                if (array[i] == searchValue) {
                    index = i;
                    loopState.Stop();
                }
                Console.WriteLine($"{i} iteration completed");
            });

            Console.WriteLine($"{searchValue} found at {index}");
        }
    }
}

/*
 * Parallel.For can be used when you have a computationally intensive task
 * that can be divided into independent chunks and which can be executed
 * concurrently. For example image processing, numerical computation,
 * searching operation etc.
 * 
 * General syntax of Parallel.For is
 * Parallel.For(startIndex, endIndex, (index, state) =>
 * {
 *     // loop body
 * });
 *
 * It's important to note that not all tasks can benefit from parallelization
 * using Parallel.For. Some tasks may have a lot of synchronization overhead,
 * which can reduce the overall performance gains.
 * 
 * About Search Algorithm:
 * It's important to note that not all search algorithms can be easily parallelized.
 * For some algorithms, the order in which elements are checked is important,
 * and parallelizing the search could lead to incorrect results. In these cases,
 * Parallel.For may not be the best choice for speeding up the search.
 */