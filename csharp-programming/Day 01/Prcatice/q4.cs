//Implement a program that reads a list of integers from the console and calculates 
//    the median value of the list. The median value is the middle value when the 
//    list is sorted in ascending order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_01.Prcatice
{
    internal class q4
    {
        static int Median(int[] numbers)
        {
            int result = 0;
            int sum = 0;
            for(int i=0; i<numbers.Length; i++)
            {
                sum += numbers[i];
            }
            result= sum/numbers.Length;
            return result;
        }
        public static int Main(string[] args)
        {
            string input;
            Console.Write("Enter list of integers by seperating comma's : ");
            input = Console.ReadLine();

            int[] numbers = input.Split(',').Select(int.Parse).ToArray();
            Array.Sort(numbers);

            int median = Median(numbers);

            Console.Write($"Average: {median}");
            return 0;
        }
    }
}
