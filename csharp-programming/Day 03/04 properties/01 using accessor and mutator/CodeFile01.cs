namespace csharp_programming {
    class Integer {
        int value;
        public int GetValue() {
            return value;
        }
        public void SetValue(int value) {
            this.value = value;
        }
    }
    class Program {
        static void Main() {
            Integer i = new Integer();
            i.SetValue(1);
            int n = i.GetValue();
        }
    }
}