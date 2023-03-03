namespace csharp_programming {
    class Math {
        public static double PI {get; private set; }

        public Math() {
            PI = 3.1428;
        }
    }

    class Program {
        static void Main() {
            double pi = Math.PI;
            //Math.PI = 3.4234;//this is not possible write access only inside the class not in other function
        }
    }
}

/*
 * Public property with private mutator.
 * 
 * here you can not use readonly bz this is not a field.
 */