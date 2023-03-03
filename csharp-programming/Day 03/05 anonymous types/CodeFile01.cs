namespace csharp_programming {
    class Program {
        static void Main(string[] args) {
            var person = new { Name = "Scott", Age = 25 };
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }
    }
}

/*
 * - An anonymous type is a reference type that can be
 *   defined using the var keyword.
 * - It may possess one or more qualities.
 * - It cannot have fields or methods.
 */
