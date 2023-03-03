namespace csharp_programming
{
    class Math
    {

        public static int Sum(params int[] n)
        { // int have only homogenious values
            int result = 0;
            foreach (int t in n)
                result += t;
            return result;
        }
    }
    class Program
    {
        static void Main()
        {
            Math m = new Math();
            int n = Math.Sum(1, 5);//6
            //n = m.Sum(1, 5, 7); //not possible
            


        }
    }
}

/*
 * In c#, static method(class method) can be called using class only.
 * It cannot be called using instance of a class.
 */

