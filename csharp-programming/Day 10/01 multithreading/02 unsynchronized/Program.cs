namespace csharp_programming {
    class Program {
        static int number = 0;

        static void ThreadProc() {
            for (int i = 0; i < 20; i++) {
                if (Thread.CurrentThread.Name == "thread1") {
                    Console.WriteLine("Thread1:Before Incr number={0}", number);
                    Thread.Sleep(100);
                    number++;
                    Console.WriteLine("Thread1:After Incr number={0}", number);
                }
                else if (Thread.CurrentThread.Name == "thread2") {
                    Console.WriteLine("\tThread2:Before Incr number={0}", number);
                    Thread.Sleep(100);
                    number++;
                    Console.WriteLine("\tThread2:After Incr number={0}", number);
                }
            }
        }

        static void Main(string[] args) {
            Thread thread1, thread2;

            ThreadStart entrypoint1 = new ThreadStart(ThreadProc);
            thread1 = new Thread(entrypoint1);
            thread1.Name = "thread1";

            ThreadStart entrypoint2 = new ThreadStart(ThreadProc);
            thread2 = new Thread(entrypoint2);
            thread2.Name = "thread2";

            thread1.Start();
            thread2.Start();
        }
    }
}