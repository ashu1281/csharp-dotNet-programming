
/*Create a class named ArrayExtensions that contains an extension method named GetRange that takes an array parameter, 
 * a starting index, and a length, and returns a sub-array containing the specified range of elements.*/
using System.Diagnostics;

namespace csharp_programming
{
    public static class ArrayExtensions
    {
        public static T[] GetRange<T>(this T[] array, int startInd, int length)
        {
            if (startInd < 0 || startInd >= array.Length)
                throw new ArgumentOutOfRangeException(nameof(startInd), "startInd is out of range!");
            if (length < 0 || startInd +length > array.Length)
                throw new ArgumentOutOfRangeException(nameof(length), "length is out of range!");

            T[] result = new T[length];
            Array.Copy(array, startInd, result, 0, length);
            return result;
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,5,6};
            int[] subarr = arr.GetRange(1, 3);
        }
    }
}

