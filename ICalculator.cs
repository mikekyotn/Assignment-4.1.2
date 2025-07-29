using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._1._2
{
    public interface ICalculator
    {
        double Val1 { get; set; }
        double Val2 { get; set; }
        double Add(double Val1, double Val2);
        double Subtract(double Val1, double Val2);
        double Multiply(double Val1, double Val2);
        double Divide(double Val1, double Val2);
    }
}
