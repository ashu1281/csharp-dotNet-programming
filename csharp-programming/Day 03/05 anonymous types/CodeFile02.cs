namespace csharp_programming {
    class Program {
        static void Main(string[] args) {
            var person = new { Name = "Scott", Age = 25 };
            person.Name = "Herb";
            person.Age = 24;
        }
    }
}

/*
 * The anonymous type's properties are read-only.
 */
