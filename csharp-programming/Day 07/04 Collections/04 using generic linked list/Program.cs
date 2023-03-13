namespace csharp_programming
{
    internal class Program
    {
        public static void Main(string[] args) { 
            //creating linked list
            LinkedList<int> numbers = new LinkedList<int>();

            //adding elements to a linked list
            numbers.AddLast(1);
            numbers.AddLast(2);
            numbers.AddLast(3);

            //Accessing elements in a linked list
            LinkedListNode<int> secondNode = numbers.First.Next;
            int secondNumber = secondNode.Value; // 2

            //Removing elements from a linked list
            numbers.Remove(1);

            //Iterating over a linked list
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}


/*
 * In C#, the LinkedList<T> class is a generic collection class that is used to
 * store a collection of elements of the same data type T.
 * 
 * LinkedList<T> is implemented as a doubly linked list.
 * 
 * Each node in the list contains an element and references to
 * the previous and next nodes in the list. This makes inserting
 * or removing elements in the middle of the list fast, as it
 * only requires updating the references of adjacent nodes.
 * 
 * However, accessing elements by index is slower, as the list
 * must be traversed from the beginning or end to reach the
 * desired element.
 * 
 * In summary, List<T> is generally faster than LinkedList<T> for
 * accessing elements by index and performing operations at 
 * the end of the list, while LinkedList<T> is faster for inserting
 * or removing elements in the middle of the list.
 */