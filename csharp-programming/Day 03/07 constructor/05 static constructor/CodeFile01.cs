namespace csharp_programming {
    class Integer {
        public static int value;
        static Integer() {
            value = 1;
        }

        public void F() { }
    }
    class Program {
        static void Main() {
        Integer obj1 = new Integer();
        obj1.F();

        Integer obj2 = new Integer();
        obj2.F();

        int value = Integer.value;
        }
    }
}

/*
 * - Static constructor is invoked only once when any member of the class is accessed.
 */
