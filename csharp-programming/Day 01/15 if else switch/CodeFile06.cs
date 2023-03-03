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

            Console.Write("Enter operator[ADD, SUB, MUL, DIV]: ");
            input = Console.ReadLine();
            string op = input;

            double result = 0.0;

            switch (op) {
                case "ADD":
                    result = a + b;
                    Console.WriteLine("result = {0}", result);
                    break;
                case "SUB":
                    result = a - b;
                    Console.WriteLine("result = {0}", result);
                    break;
                case "MUL":
                    result = a * b;
                    Console.WriteLine("result = {0}", result);
                    break;
                case "DIV":
                    result = (double)(a) / b;
                    Console.WriteLine("result = {0}", result);
                    break;
                default:
                    Console.WriteLine("Invalid operator. Exiting program...");
                    break;
            }
        }
    }
}

/*
 * Case labels can be string literals.
 */
