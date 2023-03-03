using System.Diagnostics;

namespace csharp_programming {
    class Math {
        public static double PI { get { return 3.1428; } }
    }

    class Program {
        static void Main() {
            double pi = Math.PI;
            //Math.PI = 33.3546; // error

        }
    }
}