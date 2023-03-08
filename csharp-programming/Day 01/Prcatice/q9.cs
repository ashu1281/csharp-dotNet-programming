//Create a function that takes any non-negative number as an argument and return it with
//its digits in descending order. Descending order is when you sort from highest to lowest.
//Examples:
//SortDescending(123) ➞ 321
//SortDescending(2619805) ➞ 9865210
//SortDescending(73065) ➞ 76530
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_01.Prcatice
{
    internal class q9
    {
        public static int SortDescending(int num)
        {
            string numString = num.ToString();
            char[] numArray = numString.ToCharArray();
            Array.Sort(numArray);
            Array.Reverse(numArray);
            string sortedString = new string(numArray);

            return int.Parse(sortedString);



        }
        public static int Main()
        {
            Console.Write("Enter non-negative number : ");
            int input = int.Parse(Console.ReadLine());

            int result = SortDescending(input);
            Console.Write("The sorted number is : {0}", result);

            return 0;
        }
    }
}
