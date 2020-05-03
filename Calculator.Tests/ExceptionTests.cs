using System;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class ExceptionTests
    {
        [Test]
        public void ShouldErrorWhenDivideByZero()
        {
            var sut = new Calculator();
            Assert.That(() => sut.Divide(200, 0), Throws.Exception);
        }

        // Checking the exception's type:
        [Test]
        public void ShouldErrorWhenDivideByZero2()
        {
            var sut = new Calculator();
            Assert.That(() => sut.Divide(200, 0),
                Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void ShouldErrorWhenNumberTooBig_MoreExplicit()
        {
            var sut = new Calculator();
            Assert.That(() => sut.Divide(200, 2),
                Throws.TypeOf<ArgumentOutOfRangeException>()
                    .With.Matches<ArgumentOutOfRangeException>(
                        x => x.ParamName == "value"));
        }
    }
}
