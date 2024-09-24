namespace MathOrDeath_WPF
{
    public class EquationGenerator
    {

        public string GenerateEquation(int lvl)
        {
            Random rng = new Random();
            int rawOp = rng.Next(1, 4);
            int num1 = rng.Next(1, lvl);
            int num2 = rng.Next(1, lvl);
            char op;

            switch (rawOp)
            {
                case 1:
                    op = '+';
                    break;
                case 2:
                    op = '-';
                    break;
                case 3:
                    op = '*';
                    break;
                case 4:
                    op = '/';
                    break;
                default:
                    throw new Exception();
            }
            return num1 + " " + op + " " + num2;
        }
    }
}
