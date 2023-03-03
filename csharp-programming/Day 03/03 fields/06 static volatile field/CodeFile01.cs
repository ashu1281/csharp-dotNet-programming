namespace csharp_programming {
    class Integer {
        public static volatile int value;
    }
    class Program {
        static void Main() {
            Integer.value = 1;
        }
    }
}