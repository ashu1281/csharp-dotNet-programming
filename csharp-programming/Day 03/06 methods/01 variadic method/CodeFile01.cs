namespace csharp_programming {
    class Math {

      //public int Sum(params object[] n) { // int can have heterogenious values
        public int Sum(params int[] n) { // int have only homogenious values
            int result = 0;
            foreach(int t in n)
                result += t;
            return result;
        }
    }
    class Program {
        static void Main() {
            Math m = new Math();
            int n = m.Sum(1, 5);//6
            n = m.Sum(1, 5, 7);
           // n = Math.Sum(1, 5, 7); not possible


        }
    }
}
/*
 * Non-static methos (also known as instance method) can be called using instace only.
 * It cannot be called using class.
 */