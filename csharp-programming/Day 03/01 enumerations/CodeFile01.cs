namespace csharp_programming {
    enum Operation { Add, Sub, Mul, Div };

    class Program {
        static double Calculate(int a, int b, Operation op) {
            double result = 0.0;
            switch (op) {
                case Operation.Add:
                    result = a + b;
                    break;
                case Operation.Sub:
                    result = a - b;
                    break;
                case Operation.Mul:
                    result = a * b;
                    break;
                case Operation.Div:
                    result = (double)(a) / b;
                    break;
            }
            return result;
        }

        static void Main() {
            double result = 0.0;
            result = Calculate(9, 2, Operation.Mul);
        }
    }
}

/*
 * Proper usage of enumeration makes API difficult to misuse.
 * Enum members by default begin at 0 and increase in value by 1 
 * as they descend in the definition.
 * for all enumeration Enum is the base class.
 */