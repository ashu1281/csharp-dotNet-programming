namespace csharp_programming
{
    class Program
    {
        static void Main()
        {
            int? i = null;
            int? j = 10;
            
            bool b = i.HasValue;
            b = j.HasValue;
        }
    }
}
/*
 * HasValue indicates if nullable type object has underlying value or not.
 * Returns true, if it has.
 * Returns false, if it is null.
 */