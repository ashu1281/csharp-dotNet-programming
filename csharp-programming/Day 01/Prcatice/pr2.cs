//Create a program that converts a given temperature from Celsius to Fahrenheit or from Fahrenheit to 
// Celsius. The program should ask the user to enter the temperature and the desired conversion type

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_01.Prcatice
{
    internal class pr2
    {
        public static int Main(string[] args)
        {
            double temp = 0.0;
            Console.Write("Enter temperatur : ");
            temp = Convert.ToDouble(Console.ReadLine());

            string type;
            Console.Write("Enter desired conversion type \n (Enter c : for Celsius and d : for Fahrenheit) \n Enter here : ");
            type = Console.ReadLine();
            
            char op = Convert.ToChar(type);


            switch (op)
            {
                case 'f':
                    temp = ((temp * (9.0 / 5)) + 32);
                    Console.WriteLine("Temperature converted from Celsius to Fahrenheit is: {0}", temp);
                    break;

                case 'c':
                    temp = ((temp - 32) * (5.0 / 9));
                    Console.WriteLine("Temperature converted from Celsius to Fahrenheit is: {0}", temp);
                    break;

                default:
                    Console.WriteLine("Enter valid input!");
                    break;
            }

            

            return 0;
        }
    }
}
