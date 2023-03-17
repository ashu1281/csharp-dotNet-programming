namespace csharp_programming {
    class Program {
        static Mutex mtx = null;
        static void ThreadProc() {
            mtx.WaitOne(Timeout.Infinite, true);
            for (int i = 0; i < 250; i++) {
                Thread.Sleep(100);
                Console.WriteLine("Thread:number={0}", i);
            }
            mtx.ReleaseMutex();
        }

        static void Main(string[] args) {
            Thread thread1;

            mtx = new Mutex(false, "MyMutex");

            ThreadStart entrypoint1 = new ThreadStart(ThreadProc);
            thread1 = new Thread(entrypoint1);
            thread1.Name = "thread1";

            thread1.Start();
        }
    }
}