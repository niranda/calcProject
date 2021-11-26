using System;

namespace Calculator
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var ordinaryCalculator = new OrdinaryCalc();

            // обработать AdvancedCalc 
            var advancedCalculator = new AdvancedCalc();
            bool wrongValidation;
            double? answerNumber = null;
            int modeNumber, option = 0;
            do
            {
                Console.WriteLine("Enter a number of necessary calculator mode: ");
                Console.WriteLine();
                Console.WriteLine("1. Ordinary calculator");
                Console.WriteLine("2. Advanced calculator");

                var result = int.TryParse(Console.ReadLine(), out modeNumber);
                wrongValidation = !result || modeNumber > 2 || modeNumber < 1;

                if (wrongValidation)
                {
                    Console.WriteLine();
                    Console.WriteLine("Input value is incorrect, please try again. You must enter either 1 or 2");
                    Console.WriteLine();
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    do
                    {
                        switch (modeNumber)
                        {
                            case 1:
                                var calcMode = ordinaryCalculator.GetMake();
                                Console.WriteLine(calcMode);
                                Console.WriteLine();
                                Console.Write("Enter the first number: ");
                                var firstNumberValidation = double.TryParse(Console.ReadLine(), out var firstNumber);
                                if (!firstNumberValidation)
                                {
                                    Console.WriteLine("The input value isn't a number. Please, try again");
                                    Console.WriteLine();
                                    Console.WriteLine("Press 'Enter' to continue");
                                    Console.ReadLine();
                                    Console.Clear();
                                    continue;
                                }
                                else
                                {
                                    ordinaryCalculator.SetNum1(firstNumber);
                                }
                                Console.Write("Enter the second number: ");
                                var secondNumberValidation = double.TryParse(Console.ReadLine(), out var secondNumber);
                                if (!secondNumberValidation)
                                {
                                    Console.WriteLine("The input value isn't a number. Please, try again");
                                    Console.WriteLine();
                                    Console.WriteLine("Press 'Enter' to continue");
                                    Console.ReadLine();
                                    Console.Clear();
                                    continue;
                                }
                                else
                                {
                                    ordinaryCalculator.SetNum2(secondNumber);
                                }

                                Console.WriteLine("Choose the number of operation below");
                                Console.WriteLine("1. Addition (+)");
                                Console.WriteLine("2. Substraction (-)");
                                Console.WriteLine("3. Division (/)");
                                Console.WriteLine("4. Multiplication (*)");
                                Console.WriteLine();
                                Console.WriteLine("5. Back to main menu");
                                option = int.Parse(Console.ReadLine());

                                switch (option)
                                {
                                    case 1:
                                        answerNumber = ordinaryCalculator.Add();
                                        break;
                                    case 2:
                                        answerNumber = ordinaryCalculator.Sub();
                                        break;
                                    case 3:
                                        answerNumber = ordinaryCalculator.Div();
                                        break;
                                    case 4:
                                        answerNumber = ordinaryCalculator.Mul();
                                        break;
                                    case 5:
                                        break;
                                }
                                if (answerNumber != null)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"The result is {answerNumber}");
                                }
                                break;
                        }
                        answerNumber = null;
                        Console.WriteLine();
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        Console.Clear();
                    } while (option != 5);
                }
            } while (wrongValidation || option == 5);

        }
    }
}
