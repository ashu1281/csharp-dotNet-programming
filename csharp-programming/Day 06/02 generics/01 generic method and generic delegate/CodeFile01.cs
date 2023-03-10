namespace csharp_programming
{
    static class Algorithm
    {
        public delegate T Generator<T>();//generic delegate
        public static void Generate<T>(T[] a, Generator<T> gen)//generic method
        {
            int length = a.Length;
            for(int i = 0; i < length; i++)
            {
                a[i] = gen();
            }
        }
    }
    class EvenNumberGenerator
    {
        static int value = 0;
        public static int GetNumber()
        {
            int retval = value;
            value += 2;
            return retval;
        }
    }
    class OddNumberGenerator
    {
        static double value = 0;
        public static double GetNumber()
        {
            double retval = value;
            value += 2;
            return retval;
        }

    }

    class Program
    {
        static void Main()
        {
            int[] a = new int[5];
            Algorithm.Generate(a, EvenNumberGenerator.GetNumber);

            double[] b = new double[5];
            Algorithm.Generate(b, OddNumberGenerator.GetNumber);
        }
    }
}