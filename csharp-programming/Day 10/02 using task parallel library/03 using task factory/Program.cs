namespace csharp_programming {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Main thread starting.");

            // create a TaskFactory with some default options
            TaskFactory myTaskFactory = new TaskFactory();

            // create a task that runs some background code
            Task backgroundTask = myTaskFactory.StartNew(() =>
            {
                Console.WriteLine("Background task starting.");
                // simulate some work
                Task.Delay(1000).Wait();
                Console.WriteLine("Background task complete.");
            });

            // create another task that runs some foreground code and waits for the background task to complete
            Task foregroundTask = myTaskFactory.StartNew(() =>
            {
                Console.WriteLine("Foreground task starting.");
                // simulate some work
                Task.Delay(500).Wait();
                Console.WriteLine("Foreground task waiting for background task to complete.");
                backgroundTask.Wait();
                Console.WriteLine("Foreground task complete.");
            });

            Console.WriteLine("Main thread waiting for tasks to complete.");

            // wait for both tasks to complete
            Task.WaitAll(backgroundTask, foregroundTask);

            Console.WriteLine("Main thread complete.");
        }
    }
}
