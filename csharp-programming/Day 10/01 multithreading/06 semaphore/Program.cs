namespace csharp_programming {
    class Program {
        static Semaphore smp = null;
        static void ThreadProc() {
            smp.WaitOne(Timeout.Infinite, true);
            for (int i = 0; i < 250; i++) {
                Thread.Sleep(100);
                Console.WriteLine("Thread:number={0}", i);
            }
            smp.Release();
        }

        static void Main(string[] args) {
            Thread thread1;

            smp = new Semaphore(2, 2, "MySemaphore");

            ThreadStart entrypoint1 = new ThreadStart(ThreadProc);
            thread1 = new Thread(entrypoint1);
            thread1.Name = "thread1";

            thread1.Start();
        }
    }
}