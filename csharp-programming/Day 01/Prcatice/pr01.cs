//Write a program that checks whether a given string is a palindrome or not. A palindrome is a word, 
//    phrase, number, or other sequence of characters that reads the same forward and backward.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_01.Prcatice
{
    internal class pr01
    {
        static bool palindrome(string str)
        {
            int leftind = 0;
            int rightind = str.Length - 1;

            while(leftind < rightind)
            {
                if (str[leftind] != str[rightind])
                {
                    return false;
                }
                leftind++;
                rightind--;
            }


            return true;
        }

        public static int Main(string[] args)
        {

            string str;

            Console.Write("Enter string : ");
            str = Console.ReadLine();

            if (palindrome(str))
            {
                Console.Write("Given String is palindrome");
            }
            else { 
                Console.Write("Given String is not palindrome");
            }



            return 0;
        }

    }
}
