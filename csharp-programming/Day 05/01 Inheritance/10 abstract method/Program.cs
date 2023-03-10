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
 * Abstract method can not have body.
 * Abstract mehtod can not be a member of non-abstract class.
 * Abstract class reference can be defined.
 */
