namespace MathOperationKata
{
    public class VariableReference:IMathExpression
    {
        private readonly string variableName;
        private readonly double variableValue;

        public VariableReference(string variableName, double variableValue)
        {
            this.variableName = variableName;
            this.variableValue = variableValue;
        }

        public double Evaluate()
        {
            return variableValue;
        }

        public override string ToString()
        {
            return variableName;
        }
    }
}