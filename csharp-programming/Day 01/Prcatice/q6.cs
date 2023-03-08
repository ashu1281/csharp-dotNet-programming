//Implement a program that finds the largest palindrome made from the product of two 
//    n-digit numbers. The program should ask the user to enter the number of digits.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming
{
    internal class q6
    {
        public static bool palindrome(int num)
        {
            int temp = num;
            int rev = 0;

            while(num > 0)
            {
                rev = (rev*10)+(num % 10);
                num/= 10;
            }
            if(rev == temp)
            {
                return true;
            }

            return false;
        }
        public static int Main(string[] args)
        {
            bool b = palindrome(9009);
            Console.Write("Enter the number of digits : ");
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);

            int first = (int)Math.Pow(10,n-1);
            int second = (int)Math.Pow(10,n)-1;

            int largest = 0;

            int p1 = 0;
            int p2 = 0;

            for (int i = first; i <= second; i++)
            {
                for (int j = first; j <= second; j++)
                {
                    if(palindrome(i*j) && ((i*j) > largest))
                    {
                        largest = i * j;
                        p1 = i;
                        p2 = j;
                    }
                }
            }



            Console.WriteLine("The largest palindrome made from the product of {0} and {1} is : {2}", p1,p2,largest);

            return 0;
        }
    }
}
