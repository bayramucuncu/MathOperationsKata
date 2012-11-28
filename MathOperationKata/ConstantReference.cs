namespace MathOperationKata
{
    public class ConstantReference : IMathExpression
    {
        private readonly double value;

        public ConstantReference(double value)
        {
            this.value = value;
        }

        public double Evaluate()
        {
            return value;
        }
    }
}