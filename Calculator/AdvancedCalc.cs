using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class AdvancedCalc : OrdinaryCalc, IAdvanced
    {
        public double CalcCtg(double degree)
        {
            double radian = degree * Math.PI / 180;
            if (degree <= -180 || degree >= 180)
            {
                throw new ArgumentException();
            }
            return 1 / Math.Tan(radian);
        }
    }
}