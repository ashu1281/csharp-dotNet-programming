using System;

namespace csharp_programming {
    class Integer {
        public int value;
    }

    class Program {
        static void Main() {
            Integer[][] jagged_arr = new Integer[4][];

            jagged_arr[0] = new Integer[4] {
                new Integer() { value = 1 },
                new Integer() { value = 2 },
                new Integer() { value = 3 },
                new Integer() { value = 4 }
            };

            jagged_arr[1] = new Integer[3] {
                new Integer() { value = 11 },
                new Integer() { value = 34 },
                new Integer() { value = 67 },
            };

            jagged_arr[2] = new Integer[2] {
                new Integer() { value = 89 },
                new Integer() { value = 23 },
            };

            jagged_arr[3] = new Integer[5] {
                new Integer() { value = 0 },
                new Integer() { value = 45 },
                new Integer() { value = 78 },
                new Integer() { value = 53 },
                new Integer() { value = 99 }
            };

            for (int i = 0; i < jagged_arr.Length; i++) {
                Console.Write("Row({0}): ", i); // Print the row number
                foreach (var item in jagged_arr[i]) {
                    Console.Write("{0} ", item.value); // Print the elements in the row
                }
                Console.WriteLine();
            }
        }
    }
}