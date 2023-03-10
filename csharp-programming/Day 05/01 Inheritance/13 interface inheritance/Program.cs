namespace csharp_programming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IDummyInterface d = new DummyDerived();
            d.HelloProperty = "Hello"; 
            Console.WriteLine(d.HelloProperty);
            d.Print();
        }
    }
}
