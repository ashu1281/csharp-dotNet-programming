using System;

namespace csharp_programming {
    enum Operation : byte { Add, Sub, Mul, Div };

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
            result = Calculate(5, 7, Operation.Add);
            result = Calculate(9, 2, Operation.Mul);
        }
    }
}

/*
 * By default, enum members are of int type.
 * The base type of enum members can be changed.
 */