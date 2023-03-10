using System;
using System.Threading;

namespace csharp_programming {
    class Program {
        public static int Find_If(int[] data, Func<int, bool> p) {
            int len = data.Length;
            for (int i = 0; i < len; i++) {
                if (p(data[i]))
                    return i;
            }
            return -1;
        }

        public static bool IsOdd(int n) {
            return n % 2 == 1;
        }

        static void Main() {
            int[] data = new int[] { 8, 3, 5, 2, 6, 1, 8 };
            int result = Find_If(data, IsOdd);
        }
    }
}
