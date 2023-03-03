namespace csharp_programming {
    struct Integer {
        public int value;
    }
    class Program {
        static void Main() {
            Integer i; // value type variables can be used without calling new operator
            i.value = 1;
            int n = i.value;
        }
    }
}
/*
 * struct results in value type.
 * class results in refference type.
 */