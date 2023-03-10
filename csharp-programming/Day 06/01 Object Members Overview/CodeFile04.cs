namespace csharp_programming
{
    class Integer
    {
        private int value;

        public Integer(int value)
        {
            this.value = value;
        }

        public override bool Equals(object obj)
        {
            if(obj == null || obj.GetType()!= typeof(Integer))
            {
                return false;
            }
            Integer other = (Integer)obj;

            return this.value == other.value;
        }

        public override int GetHashCode()
        {
            return value % 100;
        }

        public override string ToString()
        {
            return $"Value={value}";
        }
    }

    internal class Program
    {
        public static void Main()
        {
            Integer u = new Integer(2);
            Integer v = new Integer(2);


            Console.WriteLine(u.Equals(v));
            Console.WriteLine(Object.Equals(u, v));

            Console.WriteLine(u.GetHashCode() == v.GetHashCode());
            Console.WriteLine(Object.ReferenceEquals(u, v));

            Console.WriteLine(u.ToString());
        }
    }
}