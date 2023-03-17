namespace csharp_programming {
    internal class Program {
        public static async Task Main(string[] args) {
            Console.WriteLine("Main thread starting.");

            // create a new task to run some background code
            Task<int> myTask = MyMethod();

            // do some work in the foreground while the background task runs
            for (int i = 0; i < 5; i++) {
                Console.WriteLine($"Main thread doing work ({i + 1}/5).");
                Task.Delay(500).Wait();
            }

            // wait for the background task to complete
            int result = await myTask;

            Console.WriteLine("Main thread complete.");
        }

        static async Task<int> MyMethod() {
            Console.WriteLine("Background task starting.");
            // simulate some work
            await Task.Delay(1000);
            Console.WriteLine("Background task complete.");
            return 1;
        }
    }
}
