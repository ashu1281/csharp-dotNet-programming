namespace csharp_programming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DummyBase b = new DummyDerived();
            b.Print(); //calls DummyDerived.Print()            
        }
    }
}

/*
 * Abstract class reference can be defined.
 */
