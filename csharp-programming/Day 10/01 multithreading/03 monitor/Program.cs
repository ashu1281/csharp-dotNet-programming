using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

//Multithreading - Using Monitor (Enter/Exit)
namespace csharp_programming {
    class Program {
        static int number = 0;
        static Object obj = new Object();

        static void ThreadProc() {
            for (int i = 0; i < 20; i++) {
                lock (obj) {
                    if (Thread.CurrentThread.Name == "thread1") {
                        Console.WriteLine("Thread1:Before Incr number={0}", number);
                        Thread.Sleep(100);
                        number++;
                        Console.WriteLine("Thread1:After  Incr number={0}", number);
                    }
                    else if (Thread.CurrentThread.Name == "thread2") {
                        Console.WriteLine("\tThread2:Before Incr number={0}", number);
                        Thread.Sleep(100);
                        number++;
                        Console.WriteLine("\tThread2:After  Incr number={0}", number);
                    }

                }
            }
        }

        static void Main(string[] args) {
            Thread thread1, thread2;

            ThreadStart entrypoint = new ThreadStart(ThreadProc);
            thread1 = new Thread(entrypoint);
            thread1.Name = "thread1";

            entrypoint = new ThreadStart(ThreadProc);
            thread2 = new Thread(entrypoint);
            thread2.Name = "thread2";

            thread1.Start();
            thread2.Start();
        }
    }
}