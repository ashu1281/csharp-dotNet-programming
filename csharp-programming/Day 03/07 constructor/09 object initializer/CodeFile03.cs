namespace csharp_programming {
    class Integer {
        public int Value { get; set; }
        public Integer() {
            Value = 1;
        }
        public Integer(int value) {
            Value = value;
        }
    }
    class Program {
        static void Main() {
            Integer i = new Integer { Value = 5 }; // calls default constructor
              
        }
    }
}

/*
 * this is called object initialization 
 * this can be worked only in public property
 * 
 * this is updatation of CodeFile02 code.
 */