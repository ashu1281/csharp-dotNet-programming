namespace csharp_programming {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Main thread starting.");

            // create a new task to run some background code
            Task myTask = Task.Run(() => MyMethod());

            // do some work in the foreground while the background task runs
            for (int i = 0; i < 5; i++) {
                Console.WriteLine($"Main thread doing work ({i + 1}/5).");
                Task.Delay(500).Wait();
            }

            // wait for the background task to complete
            myTask.Wait();

            Console.WriteLine("Main thread complete.");
        }

        static void MyMethod() {
            Console.WriteLine("Background task starting.");
            // simulate some work
            Task.Delay(1000).Wait();
            Console.WriteLine("Background task complete.");
        }
    }
}
