namespace csharp_programming
{
    class Integer
    {
        private int value;

        public Integer(int value)
        {
            this.value = value;
        }

        
        public override bool Equals(Object obj)
        {
            if(obj == null || obj.GetType() != typeof(Integer))
            {
                return false;
            }

            Integer other = (Integer)obj;

            return this.value == other.value;
            
        }
    }

    class Program
    {
        public static void Main()
        {
            Integer u = new Integer(2);
            Integer v = new Integer(3);

            Console.WriteLine(u.Equals(v));
            Console.WriteLine(Object.Equals(u, v));

            Console.WriteLine(u.GetHashCode() == v.GetHashCode());


        }
    }
}