namespace csharp_programming {
    class Integer {
        public int Value { get; set; }
        public static explicit operator Integer(double value) {
            Integer i = new Integer { Value = Convert.ToInt32(value) };
            return i;
        }
    }
    class Program {
        static void Main() {
            double d = 3.14;
            Integer i = (Integer)d;
        }
    }
}