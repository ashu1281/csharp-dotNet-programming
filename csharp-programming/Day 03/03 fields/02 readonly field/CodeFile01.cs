namespace csharp_programming {
    class Integer {
        public readonly int value;
    }
    class Program {
        static void Main() {
            Integer i = new Integer();
            i.value = 1;//this will not possible
            int n = i.value;
        }
    }
}