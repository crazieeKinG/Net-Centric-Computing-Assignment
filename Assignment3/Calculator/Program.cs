using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("<--- Enter 'exit' to quit --->");
            StartCalculator();
        }

	    private static void StartCalculator()
	    {
	        while (true)
            {   
                string equation = GetEquation().Replace(" ", "");
                if (equation == "EXIT")
                    return;
                OperateTheEquation(equation);
            }
	    }

        private static void OperateTheEquation(string equation)
        {
            string result = CheckOperatorAndCalcuateResult(equation);
            Console.WriteLine($"Result = { result }");
        }

        private static string CheckOperatorAndCalcuateResult(string equation)
        {
            if (equation.Contains('+'))
                return Add(equation.Split('+')).ToString();
            else if (equation.Contains('-'))
                return Subtract(equation.Split('-')).ToString();
            else if (equation.Contains('*'))
                return Multiply(equation.Split('*')).ToString();
            else if (equation.Contains('/'))
                return Divide(equation.Split('/')).ToString();
            else
                return "Equation is invalid !!";
        }

        private static double Divide(string[] values)
        {
            return double.Parse(values[0]) / double.Parse(values[1]);
        }

        private static double Multiply(string[] values)
        {
            return double.Parse(values[0]) * double.Parse(values[1]);
        }

        private static double Subtract(string[] values)
        {
            return double.Parse(values[0]) - double.Parse(values[1]);
        }

        private static double Add(string[] values)
        {
            return double.Parse(values[0]) + double.Parse(values[1]);
        }

        private static string GetEquation()
        {
            Console.Write("Enter equation: ");
            return Console.ReadLine().ToUpper();
        }
    }
}
