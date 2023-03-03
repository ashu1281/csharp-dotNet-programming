namespace csharp_programming {
    class Integer {
        public volatile int value;
    }
    class Program {
        static void Main() {
            Integer i = new Integer();
            i.value = 1;
            int n = i.value;
        }
    }
}
/* By declaring a field volatile , we request program not to cache the variable.
 */