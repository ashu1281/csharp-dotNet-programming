namespace csharp_programming {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Main thread starting.");

            // create a new task to run some background code
            Task myTask = Task.Run(() =>
            {
                Console.WriteLine("Background task starting.");
                //simulate some work
                Task.Delay(4000).Wait();
                Console.WriteLine("Background task complete.");
            });

            // do some work in the foreground while the background task runs
            for (int i = 0; i < 5; i++) {
                Console.WriteLine($"Main thread doing work ({i + 1}/5).");
                Task.Delay(500).Wait();//if you are working with task then don't use "Thread.Sleep()" func.
            }

            // wait for the background task to complete
            myTask.Wait();

            Console.WriteLine("Main thread complete.");
        }
    }
}
