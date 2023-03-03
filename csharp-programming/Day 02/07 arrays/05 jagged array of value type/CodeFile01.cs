using System;

namespace csharp_programming {
    class Program {
        static void Main() {
            int[][] jagged_arr = new int[4][];

            jagged_arr[0] = new int[] { 1, 2, 3, 4 };
            jagged_arr[1] = new int[] { 11, 34, 67 };
            jagged_arr[2] = new int[] { 89, 23 };
            jagged_arr[3] = new int[] { 0, 45, 78, 53, 99 };

            //for (int i = 0; i < jagged_arr.Length; i++) {
            //    Console.Write("Row({0}): ", i); // Print the row number
            //    foreach(var item in jagged_arr[i]) { 
            //        Console.Write("{0} ", item); // Print the elements in the row
            //    }
            //    Console.WriteLine();
            //}

            for (int i = 0; i<jagged_arr.Length; i++)
            {
                for (int j=0; j < jagged_arr[i].Length; j++) {
                    Console.Write($"{jagged_arr[i][j]},");
                }
            Console.WriteLine();
            }
        }
    }
}