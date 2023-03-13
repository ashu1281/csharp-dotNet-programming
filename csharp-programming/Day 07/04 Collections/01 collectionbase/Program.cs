using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming { 
    internal class Progrdsam
    {
        public static void Main() { 
            MyCollection collection= new MyCollection();
            collection.Add("item 1");
            collection.Add("item 2");
            collection.Add("item 3");

            collection.Remove("item 2");
            for(int i = 0; i < collection.Count; i++)
            {
                Console.WriteLine(collection[i]);
            }

        }
    }
}

/*
 * CollectionBase is an abstract base class in C# that provides
 * a basic implementation of the IList interface.
 * 
 * The List property of CollectionBase is an ArrayList object that
 * represents the actual collection.
 * 
 * List.Add and List.Remove are used to add and remove items from the collection.
 * List[index] is used to get or set items in the collection.
 * 
 * The advantage of using CollectionBase as a base class is that it
 * provides basic implementation of methods such as Count, Clear, 
 * Contains, IndexOf, GetEnumerator etc. which are required for a collection.
 * 
 * You can simply inherit from CollectionBase and override the methods that
 * need to be customized for your specific collection type.
 * 
 * Note that CollectionBase is considered a legacy collection class in
 * .NET Framework, and it's recommended to use generic collection classes
 * such as List<T> and Dictionary<TKey, TValue> instead, which provide
 * better type safety and performance.
 */
