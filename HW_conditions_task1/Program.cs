using System;

namespace HW_conditions_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter two double numbers");
            double operand1 = Convert.ToDouble(Console.ReadLine());
            double operand2 = Convert.ToDouble(Console.ReadLine());
 
            Console.WriteLine("Please, enter the sign of operation +, -, * or /");
            string sign = Console.ReadLine();
            try
            {
                Console.WriteLine(String.Format("The result of the operation is {0}", Calculator.Calculate(operand1, operand2, sign)));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid sign.");
            }
            
            Console.ReadKey();
        }
    }
}
