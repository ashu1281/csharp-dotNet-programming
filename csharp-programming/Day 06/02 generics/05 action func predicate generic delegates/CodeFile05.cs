using System;
using System.Threading;

namespace csharp_programming {
    class Program {
        public static void Sort(int[] data, Func<int, int, bool> comp) {
            int len = data.Length;
            for (int i = 0; i < len; i++) {
                for (int j = 0; j < len - i - 1; j++) {
                    if (!comp(data[j], data[j + 1])) {
                        int t = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = t;
                    }
                }
            }
        }

        public static bool Ascending(int n1, int n2) {
            return n1 < n2;
        }

        public static bool Descending(int n1, int n2) {
            return n1 > n2;
        }

        static void Main() {
            int[] data = new int[] { 3, 5, 2, 6, 1, 8 };
            Sort(data, Ascending);
            Sort(data, Descending);
        }
    }
}
