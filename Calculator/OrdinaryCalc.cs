namespace Calculator
{
    class OrdinaryCalc : AbstractCalc
    {
        public override string make { get; set; } = "Ordinary Calulator";
        private double num1;
        private double num2;
        public double GetNum1()
        {
            return num1;
        }
        public double GetNum2()
        {
            return num2;
        }
        public void SetNum1(double num1)
        {
            this.num1 = num1;
        }
        public void SetNum2(double num2)
        {
            this.num2 = num2;
        }

        public override string GetMake()
        {
            return "This is: " + make;
        }
        public override double Add()
        {
            return num1 + num2;
        }
        public override double Div()
        {
            return num1 / num2;
        }
        public override double Mul()
        {
            return num1 * num2;
        }
        public override double Sub()
        {
            return num1 - num2;
        }
    }
}
