namespace csharp_programming
{
    class Program
    {
        static void Main()
        {
            string s = null;
            int length = s.Length;
        }
    }
}
/*
 * code fails to run as  s is null.
 * Length cannot be invoked on null reference.
 
 */