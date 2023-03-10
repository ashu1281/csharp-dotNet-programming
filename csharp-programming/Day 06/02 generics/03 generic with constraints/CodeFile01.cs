namespace csharp_programming
{
    public class Stack<T> where T : IComparable<T>
    {
        private List<T> items = new List<T>();

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            T item = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return item;
        }

        public T Peek()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return items[items.Count - 1];
        }

        public bool IsEmpty
        {
            get { return items.Count == 0; }
        }
        public T Max()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            T max = items[0];
            foreach (T item in items)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max;
        }
    }

    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            // Compare first by age, then by name
            int result = Age.CompareTo(other.Age);
            if (result == 0)
            {
                result = Name.CompareTo(other.Name);
            }
            return result;
        }
    }

    class Car { }

    class Program
    {
        static void Main()
        {
            Stack<Person> stack = new Stack<Person>();
            stack.Push(new Person { Name = "Sameer", Age = 25 });
            stack.Push(new Person { Name = "Kshitij",Age = 30 });
            stack.Push(new Person { Name = "Prasad", Age = 20 });
            stack.Push(new Person { Name = "Sujata", Age = 25 });
            Person p = stack.Max();

            //Stack<Car> stack2 = new Stack<Car>(); //it gives error bz car is not a derived class of interface icomparable

        }
    }
}