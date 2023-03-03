namespace csharp_programming
{
    internal class Program
    {
        public static void Main(string[] args) {
            int[,] a = new int[3, 4];
            int rowLBound = a.GetLowerBound(0);
            int rowUBound = a.GetUpperBound(0);
            int colLBound = a.GetLowerBound(1);
            int colUBound = a.GetUpperBound(1);
        }
    }
}