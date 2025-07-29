using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._1._2
{    
    public class MyMath : ICalculator
    {
        public double Val1 { get; set; } = 0;
        public double Val2 { get; set; } = 0;

        public double Add(double Val1, double Val2)
        { return Val1 + Val2; }
        public double Subtract(double Val1, double Val2)
        { return Val1 - Val2; }
        public double Multiply(double Val1, double Val2)
        { return Val1 * Val2; }
        public double Divide(double Val1, double Val2)
        { return Val1 / Val2; }
    }
}
