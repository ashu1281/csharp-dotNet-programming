using System;

namespace csharp_programming {
    class Program {
        static void Main() {
            string input;

            Console.Write("Enter first integer: ");
            input = Console.ReadLine();
            int a = Convert.ToInt32(input);

            Console.Write("Enter second integer: ");
            input = Console.ReadLine();
            int b = Convert.ToInt32(input);

            Console.Write("Enter operator[+ - * /]: ");
            input = Console.ReadLine();
            char op = Convert.ToChar(input);

            double result = 0.0;

            if ('+' == op) {
                result = a + b;
                Console.WriteLine("result = {0}", result);
            }
            else if ('-' == op) {
                result = a - b;
                Console.WriteLine("result = {0}", result);
            }
            else if ('*' == op || 'x' == op || 'X' == op) {
                result = a * b;
                Console.WriteLine("result = {0}", result);
            }
            else if ('/' == op) {
                result = (double)(a) / b;
                Console.WriteLine("result = {0}", result);
            }
            else {
                Console.WriteLine("Invalid operator. Exiting program...");
            }
        }
    }
}