namespace csharp_programming
{
    internal class Integer
    {
        private int value;

        public Integer(int value)
        {
            this.value = value;
        }
    }

    class Program
    {
        public static void Main()
        {
            Integer u = new Integer(1);
            Integer v = new Integer(2);

            Console.WriteLine(u.Equals(v)); // Equals method check address. 

            Console.WriteLine(Object.Equals(u, v));

        }
    }
}

/*
 * Defualt implementation of Equals Compare object by address.
 * Hence Equals return false, If two distinct object have same value.
 */