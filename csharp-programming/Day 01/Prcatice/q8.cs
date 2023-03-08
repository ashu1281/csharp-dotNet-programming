//Count the amount of ones in the binary representation of an integer.
//For example, since 12 is 1100 in binary, the return value should be 2.
//	Examples:
//	CountOnes(0) ➞ 0
//CountOnes(100) ➞ 3
//CountOnes(999) ➞ 8

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_01.Prcatice
{
    internal class q8
    {
        public static int CountOnes(int num) {
            int count = 0;
            while (num > 0)
            {
                if ((num & 1) == 1)
                {
                    count++;
                }
                num = num >> 1;
            }
            return count;
        }
    
        public static int Main(string[] args)
        {
            Console.Write("enter binary number : ");
            string input = Console.ReadLine();

            int num = Convert.ToInt32(input);
            int result = CountOnes(num);
            Console.WriteLine(result);
            return 0;
        }
    }
}
