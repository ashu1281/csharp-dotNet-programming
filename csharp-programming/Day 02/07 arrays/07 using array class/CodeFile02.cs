using System;

namespace csharp_programming {
    class Program {
        static void Print(Array arr) {
            foreach (int n in arr)
                Console.WriteLine(n);
        }

        static void Main() {
            int[] lengths = { 3, 2 };
            int[] lowerbounds = { 1, 10 };
            Array a = Array.CreateInstance(typeof(int), lengths, lowerbounds);

            int rowstart = a.GetLowerBound(0), rowend = rowstart + a.GetLength(0);
            int colstart = a.GetLowerBound(1), colend = colstart + a.GetLength(1);

            for (int i = rowstart; i <= rowend; i++)
                for (int j = colstart; j <= colend; j++)
                    a.SetValue(i + 1 + j, i, j);

            Print(a);
        }
    }
}