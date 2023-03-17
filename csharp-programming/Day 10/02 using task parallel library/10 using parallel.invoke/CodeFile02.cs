namespace csharp_programming {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Main thread starting.");
            Task task = Task.Run(() => {
                Parallel.Invoke(
                    () => MyMethodA(),
                    () => MyMethodB(),
                    () => MyMethodC()
                );
            });
            
            // do some work in the foreground while the background task runs
            for (int i = 0; i < 5; i++) {
                Console.WriteLine($"Main thread doing work ({i + 1}/5).");
                Task.Delay(500).Wait();
            }

            task.Wait();

            Console.WriteLine("Main thread complete.");
        }

        private static void MyMethodA() {
            Console.WriteLine("Background task A starting.");
            // simulate some work
            Task.Delay(3000).Wait();
            Console.WriteLine("Background task A complete.");
        }

        private static void MyMethodB() {
            Console.WriteLine("Background task B starting.");
            // simulate some work
            Task.Delay(5000).Wait();
            Console.WriteLine("Background task B complete.");
        }

        private static void MyMethodC() {
            Console.WriteLine("Background task C starting.");
            // simulate some work
            Task.Delay(4000).Wait();
            Console.WriteLine("Background task C complete.");
        }
    }
}

/*
 * Note that Parallel.Invoke is a blocking method, meaning that 
 * it will not return until all actions have completed.
 * 
 * So it's a synchronus method
 */