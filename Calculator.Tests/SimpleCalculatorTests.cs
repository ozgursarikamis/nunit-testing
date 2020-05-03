using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void ShouldAddInts()
        {
            var sut = new Calculator();
            var result = sut.AddInts(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }
         
        [Test]
        public void ShouldAddDoubles_WithTolerance()
        {
            var sut = new Calculator();
            var result = sut.AddDoubles(1.1, 2.2);

            // Assert.That(result, Is.EqualTo(3.3));
            Assert.That(result, Is.EqualTo(3.3).Within(0.01));
        }

        [Test]
        public void ShouldAddDoubles_WithPercentageTolerance()
        {
            var sut = new Calculator();
            var result = sut.AddDoubles(50, 50);
            Assert.That(result, Is.EqualTo(101).Within(1).Percent);
        }
        [Test]
        public void ShouldAddDoubles_WithPercentageBadTolerance()
        {
            var sut = new Calculator();
            var result = sut.AddDoubles(1.1, 2.2);
            Assert.That(result, Is.EqualTo(30).Within(100).Percent);
        }
    }
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