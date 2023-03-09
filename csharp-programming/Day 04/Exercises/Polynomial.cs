//Create a class Polynomial that represents a polynomial function. 
//The class should have an indexer that allows access to the coefficients of the polynomial. 
//The class should also have a method Evaluate(x) that evaluates the polynomial at a given value of x.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_04.Exercises
{
    class Polynomial
    {
        private double[] coeffs;

        public Polynomial(params double[] coeffs) //use of "params" is to passed number of arguments to the function.
        {
            this.coeffs = coeffs;
        }

        public double this[int index]
        {
            get { return coeffs[index]; }
            set { coeffs[index] = value;}
        }

        public double Evaluate(double x)
        {
            double result = 0;
            for (int i = coeffs.Length - 1; i >= 0; i--)
            {
                result = result * x + coeffs[i];
            }
            return result;
        }

    }
}
