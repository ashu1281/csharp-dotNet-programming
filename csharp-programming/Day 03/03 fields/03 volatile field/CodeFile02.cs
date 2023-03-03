namespace csharp_programming {
    class Integer {
        public readonly volatile int value;
    }
    class Program {
        static void Main() {
            Integer i = new Integer();
        }
    }
}
/**
 * A readonly and volatile can not be combined together.
 */