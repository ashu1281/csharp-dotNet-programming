namespace csharp_programming {
    class Integer {
        int value;
        public Integer(int value) {
            this.value = value;
        }
        public Integer(Integer integer) {
            value = integer.value;
        }
    }
    class Program {
        static void Main() {
            Integer i = new Integer(1);
            Integer j = new Integer(i);
        }
    }
}