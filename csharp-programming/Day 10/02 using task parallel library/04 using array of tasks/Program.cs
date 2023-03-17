namespace csharp_programming {
    internal class Program {
        public static async Task Main(string[] args) {
            Console.WriteLine("Main thread starting.");

            Task[] tasks = new Task[] {
                Task.Run(() => { BackgroundTask1(); }),
                Task.Run(() => { BackgroundTask2(); })
            };

            // do some work in the foreground while the background task runs
            for (int i = 0; i < 5; i++) {
                Console.WriteLine($"Main thread doing work ({i + 1}/5).");
                Task.Delay(500).Wait();
            }


            await Task.WhenAll(tasks);//it is same as Task.WhenAll(tasks).Wait();
            /* if u r using await operation in method, then method should fullfill two requiremnets
             1) u have to make method as "async" 
             2) return type should have Task //this pt not sure. R&D karo 
             */

            Console.WriteLine("Main thread complete.");
        }

        static void BackgroundTask1() {
            Console.WriteLine("Background task 1 starting.");
            // simulate some work
            Task.Delay(5000).Wait();
            Console.WriteLine("Background task 1 complete.");
        }

        static void BackgroundTask2() {
            Console.WriteLine("Background task 2 starting.");
            // simulate some work
            Task.Delay(5000).Wait();
            Console.WriteLine("Background task 2 complete.");
        }
    }
}
