namespace training_basic_csharp {
    class Program {
        delegate int operation(int arg1, int arg2);
        static void Main() {
            // parametric lambda
            operation random = (int minValue, int maxValue) => { Random r = new Random(); return r.Next(minValue, maxValue); }; // statement lamda
            int result = random(1, 10);
            result = random(1, 10);
        }
    }
}
