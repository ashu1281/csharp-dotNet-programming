namespace csharp_programming
{
    internal class Program
    {
        public static void Main(string[] args) { 
            //creating list
            List<int> numbers = new List<int>();

            //adding elements to a list
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            //Accessing elements in a list
            int secondNumber = numbers[1]; // 2

            //Removing elements from a list
            numbers.RemoveAt(1);

            //Iterating over a list
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}

/*
 * In C#, the List<T> class is a generic collection class that is used to
 * store a collection of elements of the same data type T.
 * 
 * List<T> is an implementation of a dynamic array.
 * 
 * It stores elements in contiguous memory locations, which makes accessing
 * elements by index very fast. The size of the array is automatically
 * adjusted as elements are added or removed.
 * 
 * It provides fast access to elements by index and performs well for operations
 * that involve adding or removing elements at the end of the list.
 * 
 * However, inserting or removing elements in the middle of the list can be slow,
 * as it requires shifting all the elements to maintain contiguous memory allocation.
 */
