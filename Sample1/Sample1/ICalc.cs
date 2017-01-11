using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
    public interface ICalc
    {
        int Add(int a, int b);
        double Div(double a, double b);
        double DivD(double a, double b, double c);
        double Mult(double a, double x);
    }
}
