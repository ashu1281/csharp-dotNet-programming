namespace csharp_programming {
    class Integer {
        int value;
        public Integer() {
            this.value = 1;
        }
        public Integer(int value) {
            this.value = value;
        }
    }
    class Program {
        static void Main() {
            Integer i = new Integer();
            Integer j = new Integer(1);
        }
    }
}