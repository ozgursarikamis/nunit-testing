namespace Calculator
{
    public class Calculator
    {
        public int AddInts(int a, int b)
        {
            return a + b;
        }

        public double AddDoubles(double a, double b)
        {
            return a + b;
        }

        public int Divide(int value, int by)
        {
            return value / by;
        }
    }

    public class SimpleCalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            // bug for demo purposes
            return a * b;
        }
    }
}
