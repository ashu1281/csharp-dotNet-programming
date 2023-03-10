namespace csharp_Programming
{
    public class Example<T>
    {
        private T value;
        public Example(T value = default) {
            this.value = value;
        }

        public void PrintValue()
        {
            Console.WriteLine($"Value is: {value}");
        }
    }

    class Program
    {
        static void Main()
        {
            Example<int> example1 = new Example<int>();
            example1.PrintValue();//Output: Value is: 0

            Example<string> example2 = new Example<string>();
            example2.PrintValue(); //Output: Value is: null

        }

    }
}
/*
 * default value expression can be used with generic types
 * to provide a default value for the type parameter.
 */