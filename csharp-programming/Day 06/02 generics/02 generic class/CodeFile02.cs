using System.Diagnostics;

namespace csharp_programming
{
    public class Stack <T>
    {
        private T[] items;
        private int top;

        public Stack(int size)
        {
            items = new T[size];
            top = -1;
        }

        public void Push(T item)
        {
            if (top == items.Length - 1)
            {
                throw new StackOverflowException();
            }
            items[++top] = item;
        }

        public T Pop()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return items[top--];
        }

        public T Top
        {
            get
            {
                if (top == -1)
                {
                    throw new InvalidOperationException("Stack is empty");
                }
                return items[top];
            }
        }

        public bool IsEmpty => top == -1;
    }
    class Program
    {
        static void Main()
        {
            Stack<char> stack = new Stack<char>(10);
            string s = "Hello";

            foreach(char c in s)
            {
                stack.Push(c);

            }
            s = "";
            while(!stack.IsEmpty)
            {
                s += stack.Pop();
            }
            Debug.Assert(s == "olleH");
        }
    }
}