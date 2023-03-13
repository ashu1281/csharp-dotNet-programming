namespace csharp_programming
{
    class Program
    {
        static void Main()
        {
            string s = null;
            int? length = s?.Length ?? 0;

            s = "Hello, World!";
            length= s?.Length ?? 0;
        }
    }
}
/*
 * Null coalescing operator can be combined with Null-conditional operator
 * to ensure that expression always has a value.
 * Note length is no more nullable typed variable.
 
 */