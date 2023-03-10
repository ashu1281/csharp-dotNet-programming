namespace csharp_programming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DummyDerived b = new DummyDerived();
            b.Print(); //calls DummyDerived.Print()

            DummyDerived d = new DummyDerived();
            d.Print(); // calls DummyDerived.print()

        }
    }
}
