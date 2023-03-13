namespace csharp_programming
{
    class Program
    {
        static void Main()
        {
            string s = null;
            int? length = s?.Length;

            s = "Hello, World!";
            length= s?.Length;
        }
    }
}
/*
 * '?.'  is known as Null-conditional operator.
 * It returns null if s is null else returns the length of the string.
 
 */