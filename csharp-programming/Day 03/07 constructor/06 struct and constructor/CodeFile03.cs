namespace csharp_programming {
    struct Integer {
        public int value;
        public Integer(int value) { // parametric constructor is allowed in struct
            this.value = value;
        }
    }
    class Program {
        static void Main() {
            Integer i = new Integer(1);
            i.value = 1;
            int n = i.value;
        }
    }
}