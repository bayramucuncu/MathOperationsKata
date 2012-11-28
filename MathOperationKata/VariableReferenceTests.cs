using NUnit.Framework;

namespace MathOperationKata
{
    public class VariableReferenceTests
    {
        [Test]
        public void Evaluate_WithVariableReference_ReturnsValue()
        {
            const string variableName = "x";
            const double variableValue = 1;
            VariableReference reference=new VariableReference(variableName,variableValue);

            Assert.AreEqual(1,reference.Evaluate());
        }

        [Test]
        public void ToString_WithVariableReference_ReturnsVariableName()
        {
            const string variableName = "x";
            const double variableValue = 1;
            VariableReference reference=new VariableReference(variableName,variableValue);

            Assert.AreEqual("x",reference.ToString());
        }
    }
}