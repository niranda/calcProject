using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
      abstract class AbstractCalc
    {
        public abstract string make { get; set; }
        public abstract string GetMake();
        public abstract double Add();
        public abstract double Div();
        public abstract double Mul();
        public abstract double Sub();
    }
}
