namespace csharp_programming
{
    class Program
    {
        static void Main()
        {
            int? i = 5;
            int? j = i * 5;
            int k = j.Value;

        }
    }
}
/* 
 * Use Value property to assign nullable object value to non-nullable variable.
 * Operations on nullable object is possible.
 */