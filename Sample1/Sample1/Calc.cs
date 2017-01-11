using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
    public class Calc
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
        /// <param name="a">numerator a</param>
        /// <param name="b">denominator b</param>
        /// <returns>a/b</returns>
        public double Div(double a, double b)
        {
            return a/b;
        }

        /// <summary>
        /// divide2
        /// </summary>
        /// <param name="a">denoinator a</param>
        /// <param name="b">numerator b</param>
        /// <returns></returns>
        public double DivB(double a, double b)
        {
            return b/a;
        }

    }
}
