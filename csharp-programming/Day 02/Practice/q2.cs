//Write a recursive function that calculates the nth number in the 
//    Fibonacci sequence. The Fibonacci sequence is a series of numbers 
//    where each number is the sum of the two preceding numbers, 
//    starting with 0 and 1.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_02.Practice
{
    internal class q2
    {
        public static int Fibo(int n)
        {
            if (n <= 1)
                return n;
            else
                return Fibo(n-1)+Fibo(n-2);
            
            
        }
        public static int Main()
        {
            Console.Write("Enter the nth number of series : ");
            int n = int.Parse(Console.ReadLine());

            int result = Fibo(n);

            Console.Write("The {0}th number of fibonacci series is : {1}",n,result);
            return 0;
        }
    }
}
