namespace csharp_programming {
    class Integer {
        public int Value { get; set; }
    }
    class Program {
        static void Main() {
            Integer i = new Integer { Value = 1 };
            Integer j = new Integer { Value = 2 };
            Integer k = new Integer { Value = 0 };
            k = i + j;
        }
    }
}