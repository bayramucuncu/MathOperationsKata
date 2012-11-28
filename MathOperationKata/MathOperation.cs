using System;

namespace MathOperationKata
{
    public class MathOperation : IMathExpression
    {
        private readonly IMathExpression leftOperand;
        private readonly char operationChar;
        private readonly IMathExpression rightOperand;

        public MathOperation(IMathExpression leftOperand, char operationChar, IMathExpression rightOperand)
        {
            this.leftOperand = leftOperand;
            this.operationChar = operationChar;
            this.rightOperand = rightOperand;
        }

        public double Evaluate()
        {
            double x = leftOperand.Evaluate();
            double y = rightOperand.Evaluate();
            if (operationChar == '+')
                return x + y;
            if (operationChar == '-')
                return x - y;
            if (operationChar == '*')
                return x * y;
            if (operationChar == '/')
                return x / y;

            throw new Exception("Unknown Operation!");
        }
    }
}