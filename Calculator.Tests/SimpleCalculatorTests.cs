using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class SimpleCalculatorTests
    {
        [Test]
        public void ShouldAddTwoNumbers()
        {
            var sut = new SimpleCalculator();
            var expected = sut.Add(3, 5);
            var actual = Is.EqualTo(8);
            Assert.That(expected, actual);
        }

        [Test]
        public void ShouldMultiplyTwoNumbers()
        {
            var sut = new SimpleCalculator();
            var expected = sut.Multiply(2, 10);
            var actual = Is.EqualTo(20);
            Assert.That(expected, actual);
        }
    }
}