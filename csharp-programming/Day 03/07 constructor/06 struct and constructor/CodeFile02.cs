namespace csharp_programming {
    struct Integer {
        public int value;
        public Integer() {
            value = 1;
        }
    }
    class Program {
        static void Main() {
            Integer i;
            i.value = 1;
            int n = i.value;
        }
    }
}

/*
 * A class can have non-public parameterless constructor.
 * A Struct cannot have non-public parameterless constructor. 
 */