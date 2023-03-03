namespace csharp_programming {
    class Integer {
        public int Value { get; set; }
    }
    class Program {
        static void Main() {
            Integer i = new Integer();
            i.Value = 21;
            int n = i.Value;
        }
    }
}