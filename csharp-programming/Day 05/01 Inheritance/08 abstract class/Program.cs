namespace csharp_programming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DummyDerived b = new DummyBase();
            b.Print(); //calls DummyDerived.Print()            
        }
    }
}

/*
 * Abstract class can't be instantiated.
 */
