using System;

namespace csharp_programming {
    class Program {
        static void Main() {
            decimal i = 940.23m;
            decimal j = 73.7m;
            // following setting is necessary, in order to output currency symbol correctly.
            Console.OutputEncoding = System.Text.Encoding.Unicode; 
            Console.WriteLine(" {0,9:C4}\n+{1,9:C4}\n — — — — -\n {2,9:C4}", i, j, i + j); //c4 means four digits over number after "." .
        }
    }
}