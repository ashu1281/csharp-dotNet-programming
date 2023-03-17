using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming
{
    public class Calculator
    {
        public delegate double MathOperation(double x, double y);

        public double Calculate(double x, double y, MathOperation operation) {
            return operation(x,y);
        }

        public double Add(double x, double y)
        {
            return x + y;
        }
         public double Sub(double x, double y)
        {
            return x - y;
        }
         public double Mul(double x, double y)
        {
            return x * y;
        }
        public double Div(double x, double y)
        {
            return x / y;
        }
        public double Mod(double x, double y)
        {
            return x % y;
        }
    }
    public class Program
    {
        public static void Main()
        {
            Calculator calc = new Calculator();

            double a = 5.5, b = 2.0;

            double result1 = calc.Calculate(a, b, calc.Add);
            double result2 = calc.Calculate(a, b, calc.Sub);
            double result3 = calc.Calculate(a, b, calc.Mul);
            double result4 = calc.Calculate(a, b, calc.Div);
            double result5 = calc.Calculate(a, b, calc.Mod);




        }
    }

}
