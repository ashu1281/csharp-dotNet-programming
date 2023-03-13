namespace training_basic_csharp {
    class Program {
        delegate int operation(int n);
        static void Main() {
            // single parametric lambda
            operation random = maxValue => { Random r = new Random(); return r.Next(maxValue); }; // statement lamda
            int result = random(10);
            result = random(10);
        }
    }
}