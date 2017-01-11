using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
    public class Calc : ICalc
    {
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="a">input a</param>
        /// <param name="b">input b</param>
        /// <returns>a+b</returns>
        public int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// divied
        /// </summary>
        /// <param name="a">nominator a</param>
        /// <param name="b">denominator b</param>
        /// <returns>a/b</returns>
        public double Div(double a, double b)
        {
            return a / b;
        }

        /// <summary>
        /// divide + add
        /// </summary>
        /// <param name="a">numerator</param>
        /// <param name="b">denominator</param>
        /// <param name="c">additive</param>
        /// <returns>a/b + c</returns>
        public double DivD(double a, double b, double c)
        {
            return a / b + c;
        }

        /// <summary>
        /// multiply
        /// </summary>
        /// <param name="a">a</param>
        /// <param name="x">x</param>
        /// <returns>a*x</returns>
        public double Mult(double a, double x)
        {
            return a * x;
        }
    }
}
