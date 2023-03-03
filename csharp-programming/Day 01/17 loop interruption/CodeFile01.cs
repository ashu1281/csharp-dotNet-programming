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

            char op;

            do {
                Console.Write("Enter operator[+ - * /]: ");
                input = Console.ReadLine();
                op = Convert.ToChar(input);

                if ('+' != op && '-' != op && '*' != op && 'x' != op && 'X' != op && '/' != op) {
                    Console.WriteLine("Invalid operator. Try again...");
                    continue;
                }
                break;
            } while (true);

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
        }
    }
}