namespace csharp_programming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DummyBase b = new DummyDerived();
            b.Print(); 
        }
    }
}

/*
 * Sealed method cannot be overriden further.
 */
