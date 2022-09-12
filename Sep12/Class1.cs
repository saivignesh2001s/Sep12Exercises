using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep12
{
    public class Calculator
    {
        public double number
        {
            get;
            set;
        }
        public double Cube1(double number)
        {

            double k = number * number * number;
            return k;
        }
        public double squareroot(double number)
        {
            double ci=Math.Sqrt(number);
            return ci;
        }
    }
}
