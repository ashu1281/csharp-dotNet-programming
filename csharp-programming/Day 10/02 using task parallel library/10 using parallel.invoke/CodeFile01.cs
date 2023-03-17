namespace csharp_programming {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Main thread starting.");

            Parallel.Invoke(
                () => MyMethodA(),
                () => MyMethodB(),
                () => MyMethodC()
            );

            Console.WriteLine("Main thread complete.");
        }

        private static void MyMethodA() {
            Console.WriteLine("Background task A starting.");
            // simulate some work
            Task.Delay(1000).Wait();
            Console.WriteLine("Background task A complete.");
        }

        private static void MyMethodB() {
            Console.WriteLine("Background task B starting.");
            // simulate some work
            Task.Delay(2000).Wait();
            Console.WriteLine("Background task B complete.");
        }

        private static void MyMethodC() {
            Console.WriteLine("Background task C starting.");
            // simulate some work
            Task.Delay(500).Wait();
            Console.WriteLine("Background task C complete.");
        }
    }
}

/*
 * Note that Parallel.Invoke is a blocking method, meaning that 
 * it will not return until all actions have completed.
 */