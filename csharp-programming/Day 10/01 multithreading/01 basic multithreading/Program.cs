using System;
using System.Threading;
namespace csharp_programming {
    class Program {
        static void ThreadProc1() {
            for (int i = 1; i < 10; i++) {
                Console.WriteLine("Thread 1");
                Thread.Sleep(100);
            }
        }

        static void ThreadProc2() {
            for (int i = 1; i < 10; i++) {
                Console.WriteLine("\tThread 2");
                Thread.Sleep(100);
            }
        }

        static void Main(string[] args) {
            ThreadStart entrypoint1 = new ThreadStart(ThreadProc1);
            Thread thread1 = new Thread(entrypoint1);
            
            ThreadStart entrypoint2 = new ThreadStart(ThreadProc2);
            Thread thread2 = new Thread(entrypoint2);

            thread1.Start();
            thread2.Start();
        }
    }
}