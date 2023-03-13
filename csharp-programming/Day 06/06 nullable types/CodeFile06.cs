namespace csharp_programming
{
    class Program
    {
        static void Main()
        {
            int? i = null;
            int j = (int)i * 5; //it throws exception.
        }
    }
}
/*
 * if i is null then it not work
 
 */