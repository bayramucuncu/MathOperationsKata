using System;
using NUnit.Framework;

namespace MathOperationKata
{
    public class MathOperationTests
    {
        [Test]
        public void Evaluate_WithSumOperation_ReturnsResult()
        {
            IMathExpression leftOperand = new VariableReference("x", 1);
            const char operationChar = '+';
            IMathExpression rightOperand = new VariableReference("y", 1);

            MathOperation operation = new MathOperation(leftOperand,
                operationChar,
                rightOperand);

            Assert.AreEqual(2, operation.Evaluate());

        }

        [Test]
        public void Evaluate_WithSubOperation_ReturnsResult()
        {
            IMathExpression leftOperand = new VariableReference("x", 1);
            const char operationChar = '-';
            IMathExpression rightOperand = new VariableReference("y", 1);

            MathOperation operation = new MathOperation(leftOperand,
                operationChar,
                rightOperand);

            Assert.AreEqual(0, operation.Evaluate());

        }
        [Test]
        public void Evaluate_WithMultOperation_ReturnsResult()
        {
            IMathExpression leftOperand = new VariableReference("x", 1);
            const char operationChar = '*';
            IMathExpression rightOperand = new VariableReference("y", 1);

            MathOperation operation = new MathOperation(leftOperand,
                operationChar,
                rightOperand);

            Assert.AreEqual(1, operation.Evaluate());

        }
        
        [Test]
        public void Evaluate_WithDivOperation_ReturnsResult()
        {
            IMathExpression leftOperand = new VariableReference("x", 4);
            const char operationChar = '/';
            IMathExpression rightOperand = new VariableReference("y", 2);

            MathOperation operation = new MathOperation(leftOperand,
                operationChar,
                rightOperand);

            Assert.AreEqual(2, operation.Evaluate());

        }     

        [Test]
        public void Evaluate_WithReferences_ReturnsResult()
        {
            // x+ (y*2)
            IMathExpression leftOperand = new VariableReference("x", 4);
            const char operationChar = '+';
            IMathExpression rightOperand = new VariableReference("y", 2);

            MathOperation operation = new MathOperation(leftOperand,
                operationChar,
                new MathOperation(rightOperand,'*',new ConstantReference(2)));

            Assert.AreEqual(8, operation.Evaluate());

        }

        [Test]
        public void Evaluate_WithReferences2_ReturnsResult()
        {
            // x+ ((y*x)/2)
            IMathExpression leftOperand = new VariableReference("x", 4);
            const char operationChar = '+';
            IMathExpression rightOperand = new VariableReference("y", 2);

            MathOperation operation = new MathOperation(leftOperand,
                operationChar,
                new MathOperation(new MathOperation(rightOperand,'*',leftOperand),'/', new ConstantReference(2) ));

            Assert.AreEqual(8, operation.Evaluate());

        }
        
        [Test]
        [ExpectedException(typeof(Exception))]
        public void Evaluate_WithInvalidOperation_ReturnsResult()
        {
            IMathExpression leftOperand = new VariableReference("x", 4);
            const char operationChar = '?';
            IMathExpression rightOperand = new VariableReference("y", 2);

            MathOperation operation = new MathOperation(leftOperand,
                operationChar,
                rightOperand);

            Assert.AreEqual(2, operation.Evaluate());
        }
    }
}