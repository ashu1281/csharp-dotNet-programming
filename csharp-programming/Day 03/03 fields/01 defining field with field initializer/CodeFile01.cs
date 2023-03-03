namespace csharp_programming {
    class Integer {
        public int value;// = 1;
    }
    class Program {
        static void Main() {
            Integer i = new Integer();
            int n = i.value; // reading field's value
            i.value = 5; // writing value to the field
        }
    }
}
