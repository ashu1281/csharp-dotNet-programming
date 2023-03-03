namespace csharp_programming {
    class Program {
        static void Main(string[] args) {
            var person = new[] {
                new { Name = "Scott", Age = 25 },
                new { Name = "Herb", Age = 24 }
            };

            foreach (var p in person) {
                Console.WriteLine(p);
            }
        }
    }
}

/*
 * An array can be created of anonymously typed elements.
 */
