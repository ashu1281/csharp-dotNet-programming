namespace csharp_programming {
    class Integer {
        int value;
        public int Value {
            get { return value; }
            set { this.value = value; } //this blue color value is a keyword not a given func/var name Value/value and this is available in only setter function.
        }
    }
    class Program {
        static void Main() {
            Integer i = new Integer();
            i.Value = 1; //called setter
            int n = i.Value; //called getter

        }
    }
}
