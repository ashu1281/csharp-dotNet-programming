namespace csharp_programming {
    class Integer {
        int value;
        public Integer() : this(1) { //here by using "sthis" default constructor called to para constructor
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