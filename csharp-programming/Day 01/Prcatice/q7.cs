//Create a function that accepts a string of space separated numbers and returns the highest and lowest number (as a string).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_01.Prcatice
{
    internal class q7
    {
        public static string highlow(string str)
        {
            

            string[] strNums = str.Split(' ');

            //foreach(string strNum in strNums)
            //{
            //    if(string.Compare(strNum, high) > 0) {
            //        high = strNum;
            //    }
            //    if(string.Compare(strNum, low) < 0){
            //        low = strNum;
            //    }
            //}

            int[] nums = Array.ConvertAll(strNums, int.Parse);
            int high = nums.Max();
            int low = nums.Min();

            return high.ToString() + " " + low.ToString();

            
        }
       public static int Main(string[] args)
        {
            Console.WriteLine("Enter numbers : ");
            string input = Console.ReadLine();


            Console.WriteLine("The highest num and lowest number is: {0}", highlow(input));
           
            
            return 0;
        }
    }
}
