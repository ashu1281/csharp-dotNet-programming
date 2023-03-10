namespace csharp_programming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IDummyInterface d = new DummyDerived();
            d.Print();

            IDummyInterface2 d2 = new DummyDerived();
            d2.Print();

        }
    }
}
