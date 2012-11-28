using NUnit.Framework;

namespace MathOperationKata
{
    [TestFixture]
    public class ConstantReferenceTests
    {
        [Test]
        public void Evaluate_WithConstant_ReturnsValue()
        {
            const double value = 1;
            ConstantReference reference=new ConstantReference(value);

            Assert.AreEqual(1,reference.Evaluate());
        }
    }
}