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
 * Sealed class cannot be inherited further.
 * Sealed class cannot have virtual members.
 */
