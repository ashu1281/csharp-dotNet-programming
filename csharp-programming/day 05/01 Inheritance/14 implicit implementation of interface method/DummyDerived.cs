namespace csharp_programming
{
    internal class DummyDerived : IDummyInterface, IDummyInterface2
    {

        public void Print()
        {
            
            Console.WriteLine("From DummyDerived.Print");

        }
    }
}
