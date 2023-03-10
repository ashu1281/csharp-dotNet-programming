namespace csharp_programming
{
    internal class DummyDerived : IDummyInterface
    {
        public string HelloProperty { get; set; }

        public void Print()
        {
            
            Console.WriteLine("From DummyDerived.Print");

        }
    }
}
