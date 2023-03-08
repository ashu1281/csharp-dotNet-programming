//Write a method CalculateArea that takes two optional parameters viz. 
//    width and height, and calculates the area of a rectangle. 
//    If either parameter is not provided, it should default to 1.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_02.Practice
{
    internal class q1
    {
        public static double CalculateArea(double x=0, double y = 0)
        {
            double area = 0.0;
            area = x * y;
            return area;
        }
        public static int Main()
        {
            Console.Write("Enter width of Rectangle : ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter Height of Rectangle : ");
            double height = double.Parse(Console.ReadLine());

            double Area = CalculateArea(width, height); 

            Console.WriteLine("The area of rectangle is : {0}", Area);
            

            return 0;
        }
    }
}
