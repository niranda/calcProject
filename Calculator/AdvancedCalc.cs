using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class AdvancedCalc : OrdinaryCalc, IAdvanced
    {
        public static double CalcCtg(int radDegree)
        {
            double degree = radDegree * (Math.PI / 180);
            if (degree < -Math.PI || degree > Math.PI)
            {
                throw new ArgumentException();
            }
            return 1 / Math.Tan(radDegree);
        }
    }
}