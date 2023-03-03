namespace csharp_programming {
    class Integer {
        public static readonly int value;

        static Integer() {
            value = 1;
        }
    }
    class Program {
        static void Main() {
            int n = Integer.value;
        }
    }
}

/*
 * this static constructor happens only once. this is called for defining static data member
 * 
     other constructor can happens for every instance or obj.
 */