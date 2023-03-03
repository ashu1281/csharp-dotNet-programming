namespace csharp_programming {
    class Integer {
        public readonly int value = 1;

        public Integer() {
            value = 5;
        }

        public void SetValue(int value) {
           this.value = value// this is not allowed a other function can not change the value of readonly variable except constructor.
        }
    }
    class Program {
        static void Main() {
            Integer i = new Integer();
            int n = i.value;
        }
    }
}

/*
 * A field defined with ‘readonly’ modifier is readonly inside as well.
 */