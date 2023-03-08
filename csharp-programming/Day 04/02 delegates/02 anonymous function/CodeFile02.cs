namespace csharp_programming {
    static class Algorithm {
        public delegate int Generator();
        public static void Generate(int[] a, Generator gen) {
            int length = a.Length;
            for (int i = 0; i < length; i++) {
                a[i] = gen();
            }
        }
    }

    class Program {
        static void Main() {
            int[] a = new int[5];
            Random random = new Random();
            Algorithm.Generate(a, delegate () { return random.Next() % 10; });
        }
    }
}

/*
 *  The scope of the parameters of an anonymous method is the anonymous-method-block. 
 *  It is an error to have a jump statement, such as goto and break inside the anonymous
 *  method block if the target is outside the block.
 *  The local variables outside anonymous method are called outer variables of the anonymous method.
 *  A reference to the outer variable ("random" in above example) is said to be captured 
 *  when the delegate is created.
 *  An anonymous method cannot access the in, ref or out parameters of an outer scope.
 */
