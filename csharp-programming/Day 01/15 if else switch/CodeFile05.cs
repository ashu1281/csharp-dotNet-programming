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

            // constant multiway conditional statement
            switch (op) {
                case '+':
                    result = a + b;
                    Console.WriteLine("result = {0}", result);
                    break;
                case '-':
                    result = a - b;
                    Console.WriteLine("result = {0}", result);
                    break;
                case '*':
                case 'x': // This results into fall through
                case 'X':
                    result = a * b;
                    Console.WriteLine("result = {0}", result);
                    break;
                case '/':
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
 * For th fall through to happen from one case label to another,
 * the case (from which fall through must happen ) must be empty.
 * 
 * default must end with the break.
 * default block can be located anywhere within switch .... case construct.
 * 
 * It is executed when matching case is not found.
 *
 */