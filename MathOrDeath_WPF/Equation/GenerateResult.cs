using System.Text.RegularExpressions;

namespace MathOrDeath_WPF.Equation
{
    class GenerateResult
    {
        public double getEquationResult(string originalEquation)
        {
            Regex regex = new Regex(@"(\d+)\s*([\+\-\*/])\s*(\d+)");
            Match match = regex.Match(originalEquation);

            double num1 = 0;
            double num2 = 0;
            char op = ' ';

            if (match.Success)
            {
                // Extract the matched groups
                num1 = int.Parse(match.Groups[1].Value);
                op = char.Parse(match.Groups[2].Value);
                num2 = int.Parse(match.Groups[3].Value);

                Console.WriteLine($"num1: {num1}, op: {op}, num2: {num2}");
            }
            else
            {
                Console.WriteLine("Invalid equation format.");
            }

            double result = -69;
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
            }


            return result;
        }
    }
}
