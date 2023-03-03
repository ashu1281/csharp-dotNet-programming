namespace csharp_programming {
    class Integer {
        public int Value { get; set; }// Value is a property
        public Integer() {
            Value = 1;
        }
        public Integer(int value) {
            Value = value;
        }
    }
    class Program {
        static void Main() {
            Integer i = new Integer(5); // calls parametric constructor
        }
    }
}