namespace csharp_programming {
    class Program {
        static ManualResetEvent _event1 = new ManualResetEvent(false);
        static ManualResetEvent _event2 = new ManualResetEvent(false);

        static void Main(string[] args) {
            ThreadPool.QueueUserWorkItem(threadContext => {
                for (int i = 1; i < 50; i++) {
                    Console.WriteLine("Thread 1");
                    Thread.Sleep(100);
                }
                _event1.Set();
            });

            ThreadPool.QueueUserWorkItem(threadContex => {
                for (int i = 1; i < 50; i++) {
                    Console.WriteLine("\tThread 2");
                    Thread.Sleep(100);
                }
                _event2.Set();
            });
        }
    }
}