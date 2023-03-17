namespace csharp_programming {
    class Program {
        static ManualResetEvent _event1 = new ManualResetEvent(false);
        static ManualResetEvent _event2 = new ManualResetEvent(false);

        static void ThreadProc1(Object threadContext) {
            for (int i = 1; i < 50; i++) {
                Console.WriteLine("Thread 1");
                Thread.Sleep(100);
            }
            _event1.Set();
        }

        static void ThreadProc2(Object threadContext) {
            for (int i = 1; i < 50; i++) {
                Console.WriteLine("\tThread 2");
                Thread.Sleep(100);
            }
            _event2.Set();
        }

        static void Main(string[] args) {
            ThreadPool.QueueUserWorkItem(ThreadProc1);
            ThreadPool.QueueUserWorkItem(ThreadProc2);
            WaitHandle.WaitAll(new WaitHandle[] { _event1, _event2 });
        }
    }
}