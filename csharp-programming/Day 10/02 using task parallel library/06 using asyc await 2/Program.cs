namespace csharp_programming {
    internal class Program {
        public static async Task Main(string[] args) {
            Console.WriteLine("Main thread starting.");

            // create a new task to run some background code
            // and immediately awaits for the same
            await MyMethod();

            // do some work in the foreground while the background task runs
            for (int i = 0; i < 5; i++) {
                Console.WriteLine($"Main thread doing work ({i + 1}/5).");
                Task.Delay(500).Wait();
            }

            Console.WriteLine("Main thread complete.");
        }

        static async Task MyMethod() {
            Console.WriteLine("Background task starting.");
            // simulate some work
            await Task.Delay(1000);
            Console.WriteLine("Background task complete.");
        }
    }
}
