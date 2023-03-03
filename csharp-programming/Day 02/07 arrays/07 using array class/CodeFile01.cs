using System;

namespace csharp_programming {
    class Program {
        static void Print(Array arr) {
            foreach (int n in arr)
                Console.WriteLine(n);
        }

        static void Main() {
            int[] data = new int[10];

            Random random = new Random();
            for (int i = 0; i < data.Length; i++)
                data[i] = random.Next(100);
            
            Array.Sort(data);
            
            int location = Array.BinarySearch(data, 95);

            Array a = Array.CreateInstance(typeof(int), 3);
            for (int i = 0; i < 3; i++)
                a.SetValue(i + 1, i);
            Print(a);
        }
    }
}