using System;

namespace HW_conditions_task1
{
    public static class Calculator
    {
        public static double Calculate(double operand1, double operand2, string sign)
        {
            double result = 0.0;
            switch (sign)
            {
                case "+":
                    result = operand1 + operand2;
                    break;
                case "-":
                    result = operand1 - operand2;
                    break;
                case "*":
                    result = operand1 * operand2;
                    break;
                case "/":
                    if (operand2 != 0)
                    {
                        result = operand1 / operand2;
                    }
                    else
                    {
                         throw new DivideByZeroException("You can not divide on a zero!");
                    }
                    break;
                default:
                    {
                        throw new ArgumentException("This is not a valid sign.");
                    }
            }
            return result;
        }
    }
}
